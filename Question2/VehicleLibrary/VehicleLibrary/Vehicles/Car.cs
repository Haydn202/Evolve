namespace VehicleLibrary.Vehicles;

public record Car :  Vehicle
{
}

public class CarFactory : IVehicleFactory
{
    public VehicleType VehicleType { get; } = VehicleType.Car;

    public Vehicle Create(VehicleSpecification spec)
    {
        return new Car
        {
            Make = spec.Make,
            Model = spec.Model,
            WheelCount = 4,
            SeatCount = spec.SeatCount,
            Length = spec.Length,
            Weight = spec.Weight,
            MaxPassengers = spec.MaxPassengers
        };
    }
}