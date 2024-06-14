using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class CreateFilmeDto
    {
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caractéres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos.")]
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
    }
}
