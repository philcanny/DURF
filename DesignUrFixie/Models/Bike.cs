using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DesignUrFixie.Models
{
    
    public class Bike
    {
        public int BikeId { get; set; }
        [Required]
        public string BikeName { get; set; }
        [Required]
        public string FrameColour { get; set; }
        [Required]
        public string SaddleColour { get; set; }
        [Required]
        public string HandlebarColour { get; set; }
        [Required]
        public string WheelColour { get; set; }

        internal static void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal static void Add(Bike bike)
        {
            throw new NotImplementedException();
        }
    }
}