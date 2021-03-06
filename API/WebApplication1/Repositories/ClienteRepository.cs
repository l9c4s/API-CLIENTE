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

        //Function search Cliente by id
        public async Task<Cliente> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }


        //Function Create Cliente
        public async Task<string> CreateCli(Cliente cliente)
        {
           _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();


            return "Cliente cadastrado com sucesso";
        }

        
    }
}
