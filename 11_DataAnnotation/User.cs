using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _11_DataAnnotation
{
    public class User
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório.")]
        public string Name { get; set; }
        //[Required(ErrorMessageResourceType = typeof(Languages.Language), ErrorMessage = "MSG_OBRIGATORIO"), EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required,  StringLength(10, MinimumLength = 6)]
        [ValidationCustomer(ErrorMessage = "O campo senha deve possuir 10 caracteres.")]
        public string Password { get; set; }
    }
}
