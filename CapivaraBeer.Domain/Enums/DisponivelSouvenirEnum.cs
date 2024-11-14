using System.ComponentModel;

namespace CapivaraBeer.Domain.Enums
{
    public enum DisponivelSouvenirEnum
    {
        [Description("Disponível")]
        Disponivel,

        [Description("Indisponível")]
        Indisponivel,

        [Description("Reservado")]
        Reservado,

        [Description("Entregue")]
        Entregue,

        [Description("Cancelado")]
        Cancelado,

        [Description("Vendido")]
        Vendido,

        [Description("Comprado")]
        Comprado,

        [Description("Aguardando Pagamento")]
        AguardandoPagamento,

        [Description("Aguardando Entrega")]
        AguardandoEntrega,

        [Description("Aguardando Recebimento")]
        AguardandoRecebimento,

        [Description("Aguardando Retirada")]
        AguardandoRetirada,

        [Description("Aguardando Envio")]
        AguardandoEnvio,

        [Description("Aguardando Devolução")]
        AguardandoDevolucao,

        [Description("Devolvido")]
        Devolvido,

        [Description("Retirado")]
        Retirado,

        [Description("Enviado")]
        Enviado
    }
}
