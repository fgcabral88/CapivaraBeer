using AutoMapper;
using CapivaraBeer.Domain.Interfaces.Repositories;
using CapivaraBeer.Domain.Interfaces.Services;
using CapivaraBeer.Application.Dtos.Cursos;
using CapivaraBeer.Shared.Constants;
using CapivaraBeer.Domain.Enums;
using CapivaraBeer.Shared.Utils;
using Microsoft.Extensions.Configuration;

namespace CapivaraBeer.Domain.Services
{
    public class CursosService : ICursosService
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly ICursosRepository _cursosRepository;

        public CursosService(IConfiguration configuration, IMapper mapper, ICursosRepository cursosRepository)
        {
            _configuration = configuration;
            _mapper = mapper;
            _cursosRepository = cursosRepository;
        }


        public async Task<ResponseMessages<List<CursosListarDto>>> RetornarCursosAsync()
        {
            var cursosDB = await _cursosRepository.RetornarCursosRepositorioAsync();

            if (!cursosDB.Any())
                return new ResponseMessages<List<CursosListarDto>>(new List<CursosListarDto>(), ResponseStatusEnum.NotFound.GetDescription(), false);

            var cursosMap = _mapper.Map<List<CursosListarDto>>(cursosDB);

            return new ResponseMessages<List<CursosListarDto>>(cursosMap, ResponseStatusEnum.OperationSucceeded.GetDescription(), true);
        }

        public Task<ResponseMessages<CursosListarDto>> RetornarCursosIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> AdicionarCursosAsync(CursosCriarDto cursosCriarDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> DeletarCursosAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> EditarCursosAsync(CursosEditarDto cursosEditarDto)
        {
            throw new NotImplementedException();
        }
    }
}
