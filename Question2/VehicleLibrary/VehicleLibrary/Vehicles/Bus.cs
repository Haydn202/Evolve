namespace VehicleLibrary.Vehicles;

public record Bus : Vehicle
{
    
}

public class BusFactory : IVehicleFactory
{
    public VehicleType VehicleType { get; } = VehicleType.Bus;

    public Vehicle Create(VehicleSpecification spec)
    {
        return new Bus
        {
            Make = spec.Make,
            Model = spec.Model,
            WheelCount = 6, // not sure how many really but lets do 6
            SeatCount = spec.SeatCount,
            Length = spec.Length,
            Weight = spec.Weight,
            MaxPassengers = spec.MaxPassengers
        };
    }
}