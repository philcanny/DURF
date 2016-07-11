namespace DesignUrFixie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bike
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bike()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bike_Id { get; set; }

        public int? Frame_Id { get; set; }

        public int? Saddle_Id { get; set; }

        public int? Handlebar_id { get; set; }

        public int? Wheel_Id { get; set; }

        public virtual Frame Frame { get; set; }

        public virtual Handlebar Handlebar { get; set; }

        public virtual Saddle Saddle { get; set; }

        public virtual Wheel Wheel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
