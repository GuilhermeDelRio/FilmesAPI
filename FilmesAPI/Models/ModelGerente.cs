using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class ModelGerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public virtual List<Cinema> Cinemas { get; set; }
    }
}
