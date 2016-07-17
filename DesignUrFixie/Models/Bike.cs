using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignUrFixie.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public string FrameColour { get; set; }
        public string SaddleColour { get; set; }
        public string HandlebarColour { get; set; }
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