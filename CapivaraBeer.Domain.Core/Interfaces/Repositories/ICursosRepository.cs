﻿using CapivaraBeer.Application.Dtos.Cursos;
using CapivaraBeer.Domain.Entities;
using CapivaraBeer.Shared.Constants;

namespace CapivaraBeer.Domain.Interfaces.Repositories
{
    public interface ICursosRepository : IDisposable
    {
        Task<IEnumerable<CursosListarDto>> RetornarCursosRepositorioAsync();
        Task<CursosListarDto> RetornarCursosIdRepositorioAsync(int id);
        Task<ResponseMessages<List<CursosListarDto>>> AdicionarCursosRepositorioAsync(CursosCriarDto cursosCriarDto);
        Task<ResponseMessages<List<CursosListarDto>>> EditarUsuarioRespositorioAsync(CursosEditarDto cursosEditarDto);
        Task<ResponseMessages<bool>> RemoverCursosRepositorioAsync(int id);
        Task<ResponseMessages<List<Cursos>>> ListarCursosRepositorioAsync();
    }
}
