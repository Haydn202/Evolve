namespace VehicleLibrary;

public abstract record class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int WheelCount { get; set; }
    public int SeatCount { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public int MaxPassengers { get; set; }
}