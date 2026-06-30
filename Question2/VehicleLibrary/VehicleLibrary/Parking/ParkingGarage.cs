using VehicleLibrary.Vehicles;

namespace VehicleLibrary.Parking;

public class ParkingGarage(List<CompactSpace> compactSpaces) : Parking
{
    private List<CompactSpace> CompactSpaces { get; init; } = compactSpaces;

    public override bool Park(Vehicle vehicle)
    {
        if (vehicle is Bus)
        {
            return false;
        }
        
        foreach (var space in CompactSpaces)
        {
            if (!space.Occupied && space.CanPark(vehicle))
            {
                space.Park(vehicle);
                return true;
            }
        }

        foreach (var space in Spaces)
        {
            if (!space.Occupied && space.CanPark(vehicle))
            {
                space.Park(vehicle);
                return true;
            }
        }
        
        return false;
    }

    public override void Leave(Vehicle vehicle)
    {
        foreach (var space in CompactSpaces)
        {
            if (!space.Occupied && space.CanPark(vehicle))
            {
                space.Unpark(vehicle);
                return;
            }
        }

        foreach (var space in Spaces)
        {
            if (!space.Occupied && space.CanPark(vehicle))
            {
                space.Unpark(vehicle);
                return;
            }
        }
    }
}