using System.ComponentModel.DataAnnotations;

namespace Conversor_de_Divisas.Models
{
    public class ConversionModels
    {
        [Required]
        public decimal Monto { get; set; }

        public decimal Resultado { get; set; }
    }
}
