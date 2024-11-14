using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum StatusCursoEnum
    {
        [Description("Ativo")]
        Ativo,

        [Description("Inativo")]
        Inativo,

        [Description("Finalizado")]
        Finalizado,

        [Description("Cancelado")]
        Cancelado,

        [Description("Suspenso")]
        Suspenso
    }
}
