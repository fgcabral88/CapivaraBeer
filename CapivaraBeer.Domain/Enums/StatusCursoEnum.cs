using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum StatusCursoEnum
    {
        [Description("Inativo")]
        Inativo = 0,

        [Description("Ativo")]
        Ativo = 1,

        [Description("Finalizado")]
        Finalizado = 2,

        [Description("Cancelado")]
        Cancelado = 3,

        [Description("Suspenso")]
        Suspenso = 4
    }
}
