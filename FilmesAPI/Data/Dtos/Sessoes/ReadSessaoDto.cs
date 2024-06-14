using FilmesAPI.Models;

namespace FilmesAPI.Data.Dtos.Sessoes
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Cinema Cinema { get; set; }
        public ModelFilme Filme { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }
    }
}
