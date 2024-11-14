using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Parceiros
    {
        public required string NomeParceiro { get; set; }
        public required string RamoAtuacaoParceiro { get; set; }
        public required string DescricaoParceiro { get; set; }
        public required string EnderecoParceiro { get; set; }
        public required string EstadoParceiro { get; set; }
        public required string CidadeParceiro { get; set; }
        public required string BairroParceiro { get; set; }
        public required string CepParceiro { get; set; }
        public required string NumeroParceiro { get; set; }
        public required string TelefoneParceiro { get; set; }
        public required string EmailParceiro { get; set; }
        public required string SiteParceiro { get; set; }
        public required string LogoParceiro { get; set; }
        public required DateTime DataCadastroParceiro { get; set; }
        public required DateTime DataAlteracaoParceiro { get; set; }
        public required DateTime DataExclusaoParceiro { get; set; }
        public required string CnpjParceiro { get; set; }
        public required StatusParceiroEnum StatusParceiro { get; set; }

        public Parceiros(){}

        public Parceiros(string nomeParceiro, string ramoAtuacaoParceiro, string descricaoParceiro, string enderecoParceiro,
            string estadoParceiro, string cidadeParceiro, string bairroParceiro, string cepParceiro, string numeroParceiro,
            string telefoneParceiro, string emailParceiro, string siteParceiro, string logoParceiro, DateTime dataCadastroParceiro,
            DateTime dataAlteracaoParceiro, DateTime dataExclusaoParceiro, string cnpjParceiro, StatusParceiroEnum statusParceiro)
        {
            NomeParceiro = nomeParceiro;
            RamoAtuacaoParceiro = ramoAtuacaoParceiro;
            DescricaoParceiro = descricaoParceiro;
            EnderecoParceiro = enderecoParceiro;
            EstadoParceiro = estadoParceiro;
            CidadeParceiro = cidadeParceiro;
            BairroParceiro = bairroParceiro;
            CepParceiro = cepParceiro;
            NumeroParceiro = numeroParceiro;
            TelefoneParceiro = telefoneParceiro;
            EmailParceiro = emailParceiro;
            SiteParceiro = siteParceiro;
            LogoParceiro = logoParceiro;
            DataCadastroParceiro = dataCadastroParceiro;
            DataAlteracaoParceiro = dataAlteracaoParceiro;
            DataExclusaoParceiro = dataExclusaoParceiro;
            CnpjParceiro = cnpjParceiro;
            StatusParceiro = statusParceiro;
        }
    }
}
