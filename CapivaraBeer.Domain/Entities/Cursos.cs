using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Cursos : Base
    {
        public required string NomeCurso { get; set; }
        public required string DescricaoCurso { get; set; }
        public required decimal PrecoCurso { get; set; }
        public required DateTime DataInicioCurso { get; set; }
        public required DateTime DataFimCurso { get; set; }
        public required string ImagemCurso { get; set; }
        public required StatusCursoEnum StatusCurso { get; set; }
        public  Parceiros? ParceiroResponsavelCurso { get; set; }
        public required IEnumerable<Usuarios> UsuariosResponsavelCurso { get; set; }

        public Cursos(){}

        public Cursos(string nomeCurso, string descricaoCurso, decimal precoCurso, DateTime dataInicioCurso, DateTime dataFimCurso,
            string imagemCurso, StatusCursoEnum statusCurso)
        {
            NomeCurso = nomeCurso;
            DescricaoCurso = descricaoCurso;
            PrecoCurso = precoCurso;
            DataInicioCurso = dataInicioCurso;
            DataFimCurso = dataFimCurso;
            ImagemCurso = imagemCurso;
            StatusCurso = statusCurso;
        }
    }
}
