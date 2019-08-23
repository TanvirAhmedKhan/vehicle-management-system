using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models.VehicleType
{
    public class Vehicle:IVehicleType,IBodyType
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineDetail { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }

        public string VehicleType { get; set; }
        public string BodyType { get; set; }

        
    }
}
