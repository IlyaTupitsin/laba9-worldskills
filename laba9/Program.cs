class Program
{
    static void Main()
    {
        Car car1 = new Car("BMW");
        Car car2 = new Car("KIA");

        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);

        Action<Car> washDelegate = Washer.Wash;

        garage.WashAllCars(washDelegate);
    }
}
public class Car
{
    public string Model { get; set; }
    public Car(string model)
    {
        Model = model;
    }
}
public class Garage
{
    private List<Car> cars = new List<Car>();
    public void AddCar(Car car)
    {
        cars.Add(car);
    }
    public void WashAllCars(Action<Car> washAction)
    {
        foreach (var car in cars)
        {
            washAction(car);
        }
    }
}
class Washer
{
    public static void Wash(Car car)
    {
        Console.WriteLine($"отмыта {car.Model}.");
    }
}