namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WareHouseItem
    {
        public int Id { get; set; }

        public int IdWareHouse { get; set; }

        public int IdItem { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransfareDate { get; set; }

        public virtual Item Item { get; set; }

        public virtual WareHouse WareHouse { get; set; }
    }
}
