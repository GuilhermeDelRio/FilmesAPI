using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Filme;
using FilmesAPI.Models;
using FluentResults;

namespace FilmesAPI.Services
{
    public class FilmeService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public FilmeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadFilmeDto AdicionarFilme(CreateFilmeDto filmeDto)
        {
            ModelFilme filme = _mapper.Map<ModelFilme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return _mapper.Map<ReadFilmeDto>(filme);
        }

        public List<ReadFilmeDto> RecuperarFilmes(int? classificacaoEtaria)
        {
            List<ModelFilme> filmes;
            if (classificacaoEtaria == null)
            {
                filmes = _context.Filmes.ToList();
            }
            else
            {
                filmes = _context.Filmes.Where(filme => filme.ClassificacaoEtaria <= classificacaoEtaria).ToList();
            }

            if (filmes != null)
            {
                List<ReadFilmeDto> readDto = _mapper.Map<List<ReadFilmeDto>>(filmes);
                return readDto;
            }

            return null!;
        }

        public ReadFilmeDto RecuperaFilmePorId(int id)
        {
            ModelFilme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id)!;
            if (filme != null)
            {
                ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);

                return filmeDto;
            }

            return null!;
        }

        public Result AtualizaFilme(int id, UpdateFilmeDto filmedto)
        {
            ModelFilme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id)!;

            if (filme == null) return Result.Fail("Filme não encontrado");
            _mapper.Map(filmedto, filme);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaFilme(int id)
        {
            ModelFilme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id)!;

            if (filme == null) return Result.Fail("Filme não encontrado");
            _context.Remove(filme);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
