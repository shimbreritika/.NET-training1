using _29JUL.Model;

namespace _29JUL.Services
{
    public class VehicleService :  IVehicleService
    {

        private static List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle
            {
                Id = 101,
                Name = "Swift",
                VehicleNumber = "MH12AB1234",
                VehicleType = "Car",
                CompanyName = "Maruti Suzuki",
                ManufacturingYear = 2022
            },

            new Vehicle
            {
                Id = 102,
                Name = "Activa",
                VehicleNumber = "MH14CD5678",
                VehicleType = "Scooter",
                CompanyName = "Honda",
                ManufacturingYear = 2021
            },

            new Vehicle
            {
                Id = 103,
                Name = "Creta",
                VehicleNumber = "MH15EF9876",
                VehicleType = "Car",
                CompanyName = "Hyundai",
                ManufacturingYear = 2023
            },

            new Vehicle
            {
                Id = 104,
                Name = "Pulsar",
                VehicleNumber = "MH20GH4321",
                VehicleType = "Bike",
                CompanyName = "Bajaj",
                ManufacturingYear = 2020
            }
        };

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public Vehicle? GetVehicle(int id)
        {
            return vehicles.FirstOrDefault(v => v.Id == id);
        }

        public Vehicle? GetVehicleByName(string name)
        {
            return vehicles.FirstOrDefault(v => v.Name == name);
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
        }
    }
}
