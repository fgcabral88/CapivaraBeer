using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum StatusPromocaoEnum
    {
        [Description("Ativo")]
        Ativo,

        [Description("Inativo")]
        Inativo,

        [Description("Cancelado")]
        Cancelado,

        [Description("Finalizado")]
        Finalizado,

        [Description("Suspensa")]
        Suspensa
    }
}
