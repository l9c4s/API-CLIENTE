using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        public async Task<string> Transfer(Transferencia transferencia)
        {
            string result;
            var pix1 = _context.Clientes.SingleOrDefault(pix1 => pix1.ChavePix == transferencia.ChavePixOri);
            var pix2 = _context.Clientes.SingleOrDefault(pix1 => pix1.ChavePix == transferencia.ChavePixdest);

            if (pix1 == null || pix2 == null)
            {
               result = "pix de origem ou de destina invalido";
               return result;
            }
               


            _context.Transferencias.Add(transferencia);
            await _context.SaveChangesAsync();
            result = "transferencia concluida";

            return result;
        }
    }
}
