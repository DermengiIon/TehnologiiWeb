using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eUseControl.Models
{
    public class UserRegister
    {
        [
            Required(ErrorMessage = "Acest câmp este obligatoriu"),
            StringLength(30),
            Display(Name = "Numele complet")
            
        ]
        public string FullName { get; set; }
        [
            Required(ErrorMessage = "Acest câmp este obligatoriu."),
            StringLength(30),
            Display(Name = "Adresa de email"),
            DataType(DataType.EmailAddress, ErrorMessage = "Introduce-ți o adresă de email validă.")
        ]
        public string EmailAddress { get; set; }
        [
            Required(ErrorMessage = "Acest câmp este obligatoriu."),
            Display(Name = "Parola"),
            MinLength(8, ErrorMessage = "Lungimea minimă: 8 caractere."),
            DataType(DataType.Password)
        ]
        public string Password { get; set; }
    }
}