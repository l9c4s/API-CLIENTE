using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Transferencia
    {
        // objeto tranferencia espelho da tabela do banco
        public int id { get; set; }
        [Required]
        public string ChavePixOri { get; set; }
        [Required]
        public double valor { get; set; }
        [Required]
        public string ChavePixdest { get; set; }
        
    }
}
