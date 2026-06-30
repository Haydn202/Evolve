namespace VehicleLibrary.Parking;

public abstract class Parking
{
    public required List<NormalSpace> Spaces { get; init; }
    public abstract bool Park(Vehicle vehicle);
    public abstract void Leave(Vehicle vehicle);
}