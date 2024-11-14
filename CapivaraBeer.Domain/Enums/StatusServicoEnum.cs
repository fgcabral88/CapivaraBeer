using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum StatusServicoEnum
    {
        [Description("Ativo")]
        Ativo,

        [Description("Inativo")]
        Inativo,

        [Description("Cancelado")]
        Cancelado,

        [Description("Finalizado")]
        Finalizado,

        [Description("Suspenso")]
        Suspenso,

        [Description("Aguardando Pagamento")]
        AguardandoPagamento
    }
}
