namespace VehicleLibrary.Parking;

public class ParkingLot : Parking
{
    public override bool Park(Vehicle vehicle)
    {
        foreach (var space in Spaces.Where(space => !space.Occupied && space.CanPark(vehicle)))
        {
            space.Park(vehicle);
            space.CurrentVehicle = vehicle;
            return true;
        }

        return false;
    }

    public override void Leave(Vehicle vehicle)
    {
        foreach (var space in Spaces.Where(space => space.Occupied && space.CurrentVehicle == vehicle))
        {
            space.CurrentVehicle = null;
        }
    }
}