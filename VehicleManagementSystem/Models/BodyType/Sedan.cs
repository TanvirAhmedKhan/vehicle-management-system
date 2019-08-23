using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models.BodyType
{
    public class Sedan : IBodyType 
    {
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public Sedan()
        {
            this.BodyType = "Sedan";
            this.VehicleType = "car";
        }
    }
}
