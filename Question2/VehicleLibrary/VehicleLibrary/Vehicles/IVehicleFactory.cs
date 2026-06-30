namespace VehicleLibrary.Vehicles;

public interface IVehicleFactory
{
    VehicleType VehicleType { get; }
    Vehicle Create(VehicleSpecification specification);
}

public class VehicleFactory(IEnumerable<IVehicleFactory> factories)
{
    public Vehicle Create(VehicleType type, VehicleSpecification spec)
    {
        return factories
            .First(f => f.VehicleType  == type)
            .Create(spec);
    }
}

public record VehicleSpecification
{
    public string Make { get; init; }
    public string Model { get; init; }
    public double Length { get; init; }
    public double Weight { get; init; }
    public int MaxPassengers { get; init; }
    public int SeatCount { get; init; }
}