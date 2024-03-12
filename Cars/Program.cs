// List<Car> cars = new() {
//     new Car("Audi", "TT", "Blue", 2800),
//     new Car("BMW", "5 Series", "Brown", 4600),
//     new Car("DMC", "Delorean", "Silver", 1210),
// };

var lines = File.ReadAllLines("cars.csv");
var cars = new List<Car>();
foreach(var line in lines.Skip(1)) {
    var tokens = line.Split(",");
    if (tokens.Length != 6) {
        Console.Write("BAD CAR! Let's skip this one!");
    } else {
        var make = tokens[1];
        var model = tokens[2];
        var color = tokens[3];
        var engineSizeInCc = int.Parse(tokens[5]);
        var car = new Car(make,model,color,engineSizeInCc);
        cars.Add(car);
    }
}

var i = 0;
foreach(var car in cars.OrderByDescending(car => car.EngineSizeInCc)) {
    Console.Write($"{++i}: ");
    Console.WriteLine(car);
}



