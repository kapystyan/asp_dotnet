using System.ComponentModel.DataAnnotations;

namespace dotnet.Models
{
    public class RegistrationModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "empty field")]
        [MaxLength(15, ErrorMessage ="max lengh 15")]
		[MinLength(6, ErrorMessage = "min lengh 6")]
		public string _login { get; set; }

		[Display(Name = "Password")]
		[Required(ErrorMessage = "empty field")]
		[MaxLength(20, ErrorMessage = "max lengh 20")]
		[MinLength(8, ErrorMessage = "min lengh 8")]
		public string _password { get; set; }

		[Display(Name = "Email")]
		[Required(ErrorMessage = "empty field")]
		[MaxLength(50, ErrorMessage = "max lengh 50")]
		[MinLength(8, ErrorMessage = "min lengh 8")]
		public string _email { get; set; }
    }
}
