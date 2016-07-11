namespace DesignUrFixie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_Id { get; set; }

        [StringLength(50)]
        public string Customer_name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(24)]
        public string Contact_No { get; set; }
    }
}
