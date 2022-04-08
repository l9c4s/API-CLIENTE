using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IClienteRepository
    {
        Task<string> CreateCli(Cliente cliente);

        Task<Cliente> Get(int id);
       
    }
}
