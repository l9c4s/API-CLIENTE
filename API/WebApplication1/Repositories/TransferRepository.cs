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

        public async Task<Cliente> GetChavePix(string pix)
        {
           return await _context.Clientes.FindAsync(pix);
        }

        public async Task<Transferencia> GetTranf(int id)
        {
            return await _context.Transferencias.FindAsync(id);
        }

        public async Task<Transferencia> Transfer(Transferencia transferencia)
        {
            var valpix1 = await GetChavePix(transferencia.ChavePixOri);
            var valpix2 = await GetChavePix(transferencia.ChavePixdest);
            
            if (valpix1 == null || valpix2 == null)
                return null;

            _context.Transferencias.Add(transferencia);
            await _context.SaveChangesAsync();

            return transferencia;
        }
    }
}
