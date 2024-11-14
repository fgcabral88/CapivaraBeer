using CapivaraBeer.Application.Dtos.Cursos;
using CapivaraBeer.Domain.Entities;
using CapivaraBeer.Domain.Interfaces.Repositories;
using CapivaraBeer.Shared.Constants;
using Dapper;
using System.Data;

namespace CapivaraBeer.infrastructure.Repositories
{
    public class CursosRepository : ICursosRepository, IDisposable
    {
        private readonly IDbConnection _dbConnection;
        private bool _disposed = false;

        public CursosRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<CursosListarDto>> RetornarCursosRepositorioAsync()
        {
            var query = "SELECT * FROM Cursos";

            return await _dbConnection.QueryAsync<CursosListarDto>(query);
        }

        public Task<CursosListarDto> RetornarCursosIdRepositorioAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> AdicionarCursosRepositorioAsync(CursosCriarDto cursosCriarDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<CursosListarDto>>> EditarUsuarioRespositorioAsync(CursosEditarDto cursosEditarDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<bool>> RemoverCursosRepositorioAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessages<List<Cursos>>> ListarCursosRepositorioAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _dbConnection?.Dispose();
                _disposed = true;
            }
        }
    }
}
