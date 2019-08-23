using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Models.BodyType;
using VehicleManagementSystem.Models.VehicleType;

namespace VehicleManagementSystem.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<VehicleContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any ailments
                if (context.vehicles != null && context.vehicles.Any() && context.bodyTypes !=null && context.bodyTypes.Any())
                    return;   // DB has already been seeded


                var allBodyTypes = GetBodyType(context).ToArray();
                context.bodyTypes.AddRange(allBodyTypes);
                context.SaveChanges();

                var vehicles = GetAllVehicles(context).ToArray();
                context.vehicles.AddRange(vehicles);
                context.SaveChanges();

                
            }
        }

      

        public static List<Vehicle> GetAllVehicles(VehicleContext db)
        {
            Vehicle car, car2, bike;
            List<Vehicle> vehicles = new List<Vehicle>();
            car = new Vehicle()
            {
                Make = "2012",
                Model = "BMW Z3",
                EngineDetail = "Some detail",
                Wheels = 4,
                Doors = 4,
                BodyType = new Sedan().BodyType,
                VehicleType = "car"
            };

            car2 = new Vehicle()
            {
                Make = "2016",
                Model = "BMW Z4",
                EngineDetail = "Some detail",
                Wheels = 4,
                Doors = 4,
                BodyType = new Hatchback().BodyType,
                VehicleType = "car"
            };
            bike = new Vehicle()
            {
                Make = "2016",
                Model = "Yamaha R1",
                EngineDetail = "Some detail",
                Wheels = 2,
                VehicleType = "bike"
            };
            vehicles.Add(car);
            vehicles.Add(car2);
            vehicles.Add(bike);


            return vehicles;
        }

        public static List<BodyTypes> GetBodyType(VehicleContext db)
        {
            List<BodyTypes> allBodyTypes = new List<BodyTypes>();
            BodyTypes mySedan = new BodyTypes();
            mySedan.BodyType = new Sedan().BodyType;
            mySedan.VehicleType = new Sedan().VehicleType;

            BodyTypes myHatchBack = new BodyTypes();
            myHatchBack.BodyType = new Hatchback().BodyType;
            myHatchBack.VehicleType = new Hatchback().VehicleType;

            allBodyTypes.Add(mySedan);
            allBodyTypes.Add(myHatchBack);
            
            


            return allBodyTypes;
        }

    }
}
