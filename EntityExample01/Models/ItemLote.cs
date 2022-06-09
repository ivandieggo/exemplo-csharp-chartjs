using System;
using System.Collections.Generic;

#nullable disable

namespace EntityExample01.Models
{
    public partial class ItemLote
    {
        public int IdItemLote { get; set; }
        public int IdItem { get; set; }
        public int IdLote { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
}
