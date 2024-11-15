﻿using CapivaraBeer.Domain.Enums;

namespace CapivaraBeer.Domain.Entities
{
    public class Produtos : Base
    {
        public required string NomeProduto { get; set; }
        public required string TipoProduto { get; set; } // lata, garrafa, growler, kits
        public required string DescricaoProduto { get; set; }
        public required decimal PrecoProduto { get; set; }
        public required int QuantidadeProduto { get; set; }
        public required decimal TeorAlcoolProduto { get; set; }
        public required string AromaProduto { get; set; } //Caramelo, frutas escuras e melado
        public required string SaborProduto { get; set; } //Malte profundo com toques de ameixa e pão tostado
        public required string ImagemProduto { get; set; }
        public required DateTime DataProducaoProduto { get; set; }
        public required DateTime DataValidadeProduto { get; set; }
        public required DateTime DataCadastroProduto { get; set; }
        public required DateTime DataAlteracaoProduto { get; set; }
        public required DateTime DataExclusaoProduto { get; set; }
        public required StatusProdutoEnum StatusProduto { get; set; }

        public Produtos(){}

        public Produtos(string nomeProduto, string tipoProduto, string descricaoProduto, decimal precoProduto, 
            int quantidadeProduto, decimal teorAlcoolProduto, string aromaProduto, string saborProduto, 
            string imagemProduto, DateTime dataProducaoProduto, DateTime dataValidadeProduto, 
            DateTime dataCadastroProduto, DateTime dataAlteracaoProduto, DateTime dataExclusaoProduto, StatusProdutoEnum statusProduto)
        {
            NomeProduto = nomeProduto;
            TipoProduto = tipoProduto;
            DescricaoProduto = descricaoProduto;
            PrecoProduto = precoProduto;
            QuantidadeProduto = quantidadeProduto;
            TeorAlcoolProduto = teorAlcoolProduto;
            AromaProduto = aromaProduto;
            SaborProduto = saborProduto;
            ImagemProduto = imagemProduto;
            DataProducaoProduto = dataProducaoProduto;
            DataValidadeProduto = dataValidadeProduto;
            DataCadastroProduto = dataCadastroProduto;
            DataAlteracaoProduto = dataAlteracaoProduto;
            DataExclusaoProduto = dataExclusaoProduto;
            StatusProduto = statusProduto;
        }
    }
}
