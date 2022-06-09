using System;
using System.Collections.Generic;

#nullable disable

namespace EntityExample01.Models
{
    public partial class Lote
    {
        public int IdLote { get; set; }
        public string DescricaoLote { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string UsuarioAtualizacao { get; set; }
    }
}
