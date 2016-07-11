namespace DesignUrFixie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_Id { get; set; }

        public int Customer_Id { get; set; }

        public int Bike_Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal? Price { get; set; }

        public virtual Bike Bike { get; set; }

        public virtual Customer1 Customer { get; set; }
    }
}
