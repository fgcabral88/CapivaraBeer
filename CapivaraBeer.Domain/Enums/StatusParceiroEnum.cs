using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum StatusParceiroEnum
    {
        [Description("Ativo")]
        Ativo,

        [Description("Inativo")]
        Inativo,

        [Description("Finalizado")]
        Finalizado
    }
}
