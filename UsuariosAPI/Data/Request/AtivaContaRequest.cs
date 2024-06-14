using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.Request
{
    public class AtivaContaRequest
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string CodigoDeAtivacao { get; set; }
    }
}
