using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Please Enter Name and SurName")]
        public string NameSurname { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Display(Name = "Again Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "EMail Address")]
        [Required(ErrorMessage = "Please Enter EMail")]
        public string Mail { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserName { get; set; }
    }
}
