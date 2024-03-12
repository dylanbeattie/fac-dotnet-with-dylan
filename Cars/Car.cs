// See https://aka.ms/new-console-template for more information
public class Car
{

    public Car(string make, string model, string color, int engineSizeInMilliLitres) {
        this.Make = make;
        this.Model = model;
        this.Color = color;
        this.EngineSizeInCc = engineSizeInMilliLitres;
    }

    /// <summary>The number of wheels (not including the steering wheel)</summary>
    public int NumberOfWheels { get; set; } = 4;
    public string Color { get; set; } = "";
    public int EngineSizeInCc { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";

    public override string ToString() {
         return $"{this.Make} {this.Model} ({this.Color}, {this.EngineSizeInCc}cc)";
    }
}