namespace VehicleLibrary.Parking;

public abstract class ParkingSpace
{
    public bool Occupied { get; private set; }
    public Vehicle? CurrentVehicle { get; internal set; }
    
    public abstract bool CanPark(Vehicle vehicle);

    public void Park(Vehicle vehicle)
    {
        Occupied = true;
        CurrentVehicle = vehicle;
    }

    public void Unpark(Vehicle vehicle)
    {
        if (CurrentVehicle == vehicle)
        {
            Occupied = false;
            CurrentVehicle = null;
        }
    }
}