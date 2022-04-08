using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllCli();
        Task<Cliente> GetCli(int documento);
        Task<Cliente> CreateCli(Cliente cliente);
    }
}
