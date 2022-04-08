using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _ClienterRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _ClienterRepository = clienteRepository;
        }
        // Request cliente by Documento
        [HttpGet("{Documento}")]
        public async Task<ActionResult<Cliente>> GetCli(int Documento)
        {
            return await _ClienterRepository.GetCli(Documento);
        }
        // Post new cliente
        [HttpPost]
        public async Task<ActionResult<Cliente>> PosTCli(Cliente cliente)
        {
            var newcli = await _ClienterRepository.CreateCli(cliente);
            return CreatedAtAction(nameof(GetCli), new{ id = newcli }, newcli);          
        }
    }
}
