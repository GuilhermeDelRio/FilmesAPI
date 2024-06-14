using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.Request
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
