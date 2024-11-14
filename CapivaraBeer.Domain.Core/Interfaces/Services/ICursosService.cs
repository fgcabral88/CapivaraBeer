using CapivaraBeer.Application.Dtos.Cursos;
using CapivaraBeer.Shared.Constants;

namespace CapivaraBeer.Domain.Interfaces.Services
{
    public interface ICursosService
    {
        Task<ResponseMessages<List<CursosListarDto>>> RetornarCursosAsync();
        Task<ResponseMessages<CursosListarDto>> RetornarCursosIdAsync(Guid Id);
        Task<ResponseMessages<List<CursosListarDto>>> AdicionarCursosAsync(CursosCriarDto cursosCriarDto);
        Task<ResponseMessages<List<CursosListarDto>>> EditarCursosAsync(CursosEditarDto cursosEditarDto);
        Task<ResponseMessages<List<CursosListarDto>>> DeletarCursosAsync(Guid Id);
    }
}
