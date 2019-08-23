using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public interface IBodyType
    {
        string VehicleType { get; set; }
        string BodyType { get; set; }
    }
}
