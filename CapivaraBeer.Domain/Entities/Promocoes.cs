using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Promocoes : Base
    {
        public required IEnumerable<Produtos> ProdutoPromocao { get; set; }
        public required string NomePromocao { get; set; }
        public required string DescricaoPromocao { get; set; }
        public required decimal PercentualDescontoPromocao { get; set; }
        public required DateTime DataInicioPromocao { get; set; }
        public required DateTime DataFimPromocao { get; set; }
        public required string ImagemPromocao { get; set; }
        public required StatusPromocaoEnum StatusPromocao { get; set; }

        public Promocoes(){}

        public Promocoes(string nomePromocao, string descricaoPromocao, decimal percentualDescontoPromocao, 
            DateTime dataInicioPromocao, DateTime dataFimPromocao, string imagemPromocao, StatusPromocaoEnum statusPromocao)
        {
            NomePromocao = nomePromocao;
            DescricaoPromocao = descricaoPromocao;
            PercentualDescontoPromocao = percentualDescontoPromocao;
            DataInicioPromocao = dataInicioPromocao;
            DataFimPromocao = dataFimPromocao;
            ImagemPromocao = imagemPromocao;
            StatusPromocao = statusPromocao;
        }
    }
}
