using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> GetCli(int documento);
        Task<string> CreateCli(Cliente cliente);
    }
}
