using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        public readonly AppContext _context;
        public TransferRepository(AppContext context)
        {
            _context = context;
        }

        public async Task<Transferencia> GetTranf(int id)
        {
            return await _context.Transferencias.FindAsync(id);
        }

        public async Task<Transferencia> Transfer(Transferencia transferencia)
        {
            _context.Transferencias.Add(transferencia);
            await _context.SaveChangesAsync();

            return transferencia;
        }
    }
}
