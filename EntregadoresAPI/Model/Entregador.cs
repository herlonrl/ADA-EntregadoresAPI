using System.ComponentModel.DataAnnotations;

namespace EntregadoresAPI.Model
{
    public class Entregador
    {
        [Required]
        [MaxLength(11, ErrorMessage = "O CPF precisa ter 11 dígitos")]
        [MinLength(11)]
        public string CPF {  get;  set; }
        [Required]
        public string Nome { get;  set; }
        [Required]
        public string Cidade { get;  set; }
    }
}
