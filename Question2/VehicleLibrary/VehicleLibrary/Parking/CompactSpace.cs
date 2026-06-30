using VehicleLibrary.Vehicles;

namespace VehicleLibrary.Parking;

public class CompactSpace : ParkingSpace
{
    public override bool CanPark(Vehicle vehicle)
    {
        return vehicle.Weight < 1500;
    }
}