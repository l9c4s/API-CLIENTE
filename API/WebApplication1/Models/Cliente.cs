using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    //tornando campos unicos
    [Index(nameof(Documento),IsUnique =true)]
    [Index(nameof(ChavePix), IsUnique = true)]
    public class Cliente
    {
        // objeto cliente espelho da tabela do banco

        [Required(ErrorMessage = "Chave pix obrigatório")]
        [StringLength(30, MinimumLength = 11, ErrorMessage = "O nome de usuario deve conter no minimo 11 carateres")]
        public string ChavePix { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "O nome de usuario deve conter no minimo 5 carateres")]
        public string Nome { get; set; }


        [Key]
        [Required(ErrorMessage = "Documento obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O documento deve conter 11 carateres")]
        public int Documento { get; set; }
    }
}
