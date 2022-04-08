﻿using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface ITransferRepository 
    {
        Task<Transferencia> Transfer(Transferencia transferencia);

        Task<Transferencia> GetTranf(int id);

        Task<Cliente> GetChavePix(string pix);
    }
}
