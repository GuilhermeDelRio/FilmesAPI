using AutoMapper;
using FilmesAPI.Data.Dtos.Filme;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, ModelFilme>();
            CreateMap<ModelFilme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, ModelFilme>();
        }
    }
}
