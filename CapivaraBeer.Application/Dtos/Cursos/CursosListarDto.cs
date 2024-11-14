using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Application.Dtos.Cursos
{
    public class CursosListarDto : BaseDto
    {
        public required string NomeCurso { get; set; }
        public required string DescricaoCurso { get; set; }
        public required decimal PrecoCurso { get; set; }
        public required DateTime DataInicioCurso { get; set; }
        public required DateTime DataFimCurso { get; set; }
        public required string ImagemCurso { get; set; }
        public required StatusCursoEnum StatusCursoEnum { get; set; } 
        public required Domain.Entities.Parceiros? ParceiroResponsavelCurso { get; set; }
        public required IEnumerable<Domain.Entities.Usuarios> UsuariosResponsavelCurso { get; set; }
    }
}
