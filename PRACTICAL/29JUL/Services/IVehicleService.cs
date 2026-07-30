using _29JUL.Model;

namespace _29JUL.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();

        Vehicle? GetVehicle(int id);

        Vehicle? GetVehicleByName(string name);

        Vehicle AddVehicle(Vehicle vehicle);
    }
}
