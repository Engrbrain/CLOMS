using System.ComponentModel.DataAnnotations;

namespace LOMS.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
