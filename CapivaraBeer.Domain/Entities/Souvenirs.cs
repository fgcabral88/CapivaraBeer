using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Souvenirs : Base
    {
        public required string NomeSouvenir { get; set; }
        public required string DescricaoSouvenir { get; set; }
        public required decimal PrecoSouvenir { get; set; }
        public required int QuantidadeSouvenir { get; set; }
        public required DisponivelSouvenirEnum DisponivelSouvenir { get; set; }
        public required string ImagemSouvenir { get; set; }
        public required TipoSouvenirEnum TipoSouvenir { get; set; }
        public required DateTime DataCadastroSouvenir { get; set; }
        public required DateTime DataAlteracaoSouvenir { get; set; }
        public required StatusSouvenirEnum StatusSouvenir { get; set; }
        public required Promocoes PromocaoSouvenir { get; set; }

        public Souvenirs(){}

        public Souvenirs(string nomeSouvenir, string descricaoSouvenir, decimal precoSouvenir, int quantidadeSouvenir, 
            DisponivelSouvenirEnum disponivelSouvenir, string imagemSouvenir, TipoSouvenirEnum tipoSouvenir, 
            DateTime dataCadastroSouvenir, DateTime dataAlteracaoSouvenir, StatusSouvenirEnum statusSouvenir)
        {
            NomeSouvenir = nomeSouvenir;
            DescricaoSouvenir = descricaoSouvenir;
            PrecoSouvenir = precoSouvenir;
            QuantidadeSouvenir = quantidadeSouvenir;
            DisponivelSouvenir = disponivelSouvenir;
            ImagemSouvenir = imagemSouvenir;
            TipoSouvenir = tipoSouvenir;
            DataCadastroSouvenir = dataCadastroSouvenir;
            DataAlteracaoSouvenir = dataAlteracaoSouvenir;
            StatusSouvenir = statusSouvenir;
        }
    }
}
