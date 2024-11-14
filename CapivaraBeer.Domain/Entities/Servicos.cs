using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Servicos : Base
    {
        public required string NomeServico { get; set; }
        public required string DescricaoServico { get; set; }
        public required decimal PrecoServico { get; set; }
        public required DateTime DataInicioServico { get; set; }
        public required DateTime DataFimServico { get; set; }
        public required TimeSpan DuracaoServico { get; set; }
        public required StatusServicoEnum StatusServico { get; set; }

        public Servicos(){}

        public Servicos(string nomeServico, string descricaoServico, decimal precoServico, DateTime dataInicioServico, 
            DateTime dataFimServico, TimeSpan duracaoServico, StatusServicoEnum statusServico)
        {
            NomeServico = nomeServico;
            DescricaoServico = descricaoServico;
            PrecoServico = precoServico;
            DataInicioServico = dataInicioServico;
            DataFimServico = dataFimServico;
            DuracaoServico = duracaoServico;
            StatusServico = statusServico;
        }
    }
}
