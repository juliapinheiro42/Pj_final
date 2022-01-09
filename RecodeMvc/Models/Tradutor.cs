using RecodeMvc.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Tradutor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Por favor, preencha com seu nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, preencha com um e-mail para contato")]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(13)]
        [Required(ErrorMessage = "Por favor, preencha com um telefone para contato")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor, preencha com a sua idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Por favor, é necessário que informe seu nível de espanhol")]
        public NivelEspanhol NivelEspanhol { get; set; }
    }
}
