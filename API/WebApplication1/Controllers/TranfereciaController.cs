using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranfereciaController : ControllerBase
    {
        private readonly ITransferRepository _TransferenciaRepository;

        public TranfereciaController(ITransferRepository transferencia, IClienteRepository _ClienterRepository)
        {
            _TransferenciaRepository = transferencia;
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult<Transferencia>> GetTranf(int ID)
        {
            return await _TransferenciaRepository.GetTranf(ID);
        }

        [HttpPost]
        public async Task<ActionResult<Transferencia>> PostTranfer(Transferencia Transferencia)
        {

            var newtranf = await _TransferenciaRepository.Transfer(Transferencia);
            return CreatedAtAction(nameof(GetTranf), new { id = newtranf }, newtranf);
        }
    }
}
