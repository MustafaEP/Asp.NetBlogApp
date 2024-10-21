using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string password { get; set; }
    }
}
