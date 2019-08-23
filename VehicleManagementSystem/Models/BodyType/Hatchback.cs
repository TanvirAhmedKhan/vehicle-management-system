using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models.BodyType
{
    public class Hatchback : IBodyType 
    {
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public Hatchback()
        {
            this.BodyType = "Hatchback";
            this.VehicleType = "car";
        }
    }
}
