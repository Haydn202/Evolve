namespace VehicleLibrary.Parking;

public class NormalSpace : ParkingSpace
{
    public override bool CanPark(Vehicle vehicle)
    {
        return true;
    }
}