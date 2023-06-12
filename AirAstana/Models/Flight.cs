namespace AirAstana.Models;

public class Flight
{
    public int Id { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTimeOffset Departure { get; set; }
    public DateTimeOffset Arrival { get; set; }
    public enum MyEnum
    {
        InTime,
        Delayed,
        Cancelled
    }

    
}