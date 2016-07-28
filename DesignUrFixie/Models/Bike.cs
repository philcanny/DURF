using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Stripe;

namespace DesignUrFixie.Models
{
    
    public class Bike
    {
        public int BikeId { get; set; }
        [Required]
        public string CustomerName { get; set; }
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

    public class StripeChargeModel
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public double Amount { get; set; }
        // These fields are optional and are not 
        // required for the creation of the token
        public string CardHolderName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressCity { get; set; }
    }
}