using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
 
    public class ClienteRepository : IClienteRepository
    {
        public readonly AppContext _context;
        public ClienteRepository(AppContext context)
        {
            _context = context;
        }

        //Function list all cliente
        public async Task<IEnumerable<Cliente>> GetAllCli()
        {
            return await _context.Clientes.ToListAsync();
        }

        //Function Create Cliente
        public async Task<Cliente> CreateCli(Cliente cliente)
        {
           _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }

        //Function search Cliente by Documento
        public async Task<Cliente> GetCli(int Documento)
        {
            return await _context.Clientes.FindAsync(Documento);
        }
    }
}
