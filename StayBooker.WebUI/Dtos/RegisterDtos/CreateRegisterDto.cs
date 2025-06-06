using System.ComponentModel.DataAnnotations;

namespace StayBooker.WebUI.Dtos.RegisterDtos
{
    public class CreateRegisterDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-Mail is required")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Pasword is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password repeatis required")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
