using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Transferencia 
    {
        // objeto tranferencia espelho da tabela do banco
        public int id { get; set; }
        public string ChavePixOri { get; set; }
        public double valor { get; set; }
        public string ChavePixdest { get; set; }
        
    }
}
