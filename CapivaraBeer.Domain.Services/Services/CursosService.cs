using AutoMapper;
using CapivaraBeer.Domain.Interfaces.Repositories;
using CapivaraBeer.Domain.Interfaces.Services;
using Castle.Core.Configuration;
using CapivaraBeer.Application.Dtos.Cursos;
using CapivaraBeer.Shared.Constants;

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
            ResponseMessages<List<CursosListarDto>> response = new ResponseMessages<List<CursosListarDto>>();

            var cursosDB = await _cursosRepository.RetornarCursosRepositorioAsync(); 

            if (!cursosDB.Any())
            {
                //response.Mensagem = "Nenhum usuário encontrado. Tente novamente!";
                //response.Status = false;
                return response;
            }

            var cursosMap = _mapper.Map<List<CursosListarDto>>(cursosDB);
            //response.Dados = usuariosMap;
            //response.Mensagem = "Usuários retornados com sucesso";
            //response.Status = true;

            return response;
        }

        public Task<ResponseMessages<CursosListarDto>> RetornarCursosIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> AdicionarCursosAsync(CursosCriarDto cursosCriarDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> DeletarCursosAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> EditarCursosAsync(CursosEditarDto cursosEditarDto)
        {
            throw new NotImplementedException();
        }
    }
}
