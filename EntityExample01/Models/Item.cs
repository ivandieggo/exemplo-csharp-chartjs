using System;
using System.Collections.Generic;

#nullable disable

namespace EntityExample01.Models
{
    public partial class Item
    {
        public int IdItem { get; set; }
        public string DescricaoItem { get; set; }
        public int? IdTipoItem { get; set; }
        public int? IdTime { get; set; }
        public bool? Ativo { get; set; }
        public int? IdDisponibilidade { get; set; }
        public int? Quantidade { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? ValorAnunciado { get; set; }
        public decimal? ValorPromo { get; set; }
        public int? IdOrigem { get; set; }
        public decimal? ValorVendaEfetivo { get; set; }
    }
}
