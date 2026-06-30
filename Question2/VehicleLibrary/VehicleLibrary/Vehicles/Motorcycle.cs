namespace VehicleLibrary.Vehicles;

public record Motorcycle : Vehicle
{
}

public class MotorcycleFactory : IVehicleFactory
{
    public VehicleType VehicleType { get; } = VehicleType.Motorcycle;

    public Vehicle Create(VehicleSpecification spec)
    {
        return new Motorcycle
        {
            Make = spec.Make,
            Model = spec.Model,
            WheelCount = 2,
            SeatCount = spec.SeatCount,
            Length = spec.Length,
            Weight = spec.Weight,
            MaxPassengers = spec.MaxPassengers,
        };
    }
}