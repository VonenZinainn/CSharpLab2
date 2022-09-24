namespace Part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Plane plane = new Plane(12, 15, 5400000000, 900,
                2022, 13, 200);
            Car car = new Car(20, 50, 1500000, 222, 2019);
            Ship ship = new Ship(10, 40, 100000000, 70, 2021,
                100, "Krasnoyarsk river port");
            Console.WriteLine(plane);
            Console.WriteLine(car);
            Console.WriteLine(ship);
        }
    }

    class Vehicle
    {
        private double _x;
        private double _y;
        private ulong _price;
        private int _maxSpeed;
        private int _assemblyYear;

        protected Vehicle(double x, double y, ulong price, int maxSpeed, int assemblyYear)
            => (_x, _y, _price, _maxSpeed, _assemblyYear) = (x, y, price, maxSpeed, assemblyYear);

        private protected string Characteristics(string type)
        {
            return $"{type}'s coordinates - x = {_x}, y = {_y};\n" +
                   $"{type}'s max speed is {_maxSpeed} km/h;\n" +
                   $"{type}'s price is {_price} rub;\n" +
                   $"{type}'s assembly year is {_assemblyYear};\n";
        }
    }

    class Plane : Vehicle
    {
        private double _height;
        private int _passengersAmount;

        public Plane(double x, double y, ulong price, int maxSpeed, int assemblyYear, double height,
            int passengersAmount)
            : base(x, y, price, maxSpeed, assemblyYear)
            => (_height, _passengersAmount) = (height, passengersAmount);

        public override string ToString()
        {
            return Characteristics("Plane") +
                   $"Plane's height is {_height} m;\n" +
                   $"Plane's passengers amount is {_passengersAmount};\n";
        }
    }

    class Car : Vehicle
    {
        public Car(double x, double y, ulong price, int maxSpeed, int assemblyYear)
            : base(x, y, price, maxSpeed, assemblyYear)
        {
        }

        public override string ToString()
        {
            return Characteristics("Car");
        }
    }

    class Ship : Vehicle
    {
        private int _passengersAmount;
        private string _registryPort;

        public Ship(double x, double y, ulong price, int maxSpeed, int assemblyYear, int passengersAmount,
            string registryPort)
            : base(x, y, price, maxSpeed, assemblyYear)
            => (_passengersAmount, _registryPort) = (passengersAmount, registryPort);

        public override string ToString()
        {
            return Characteristics("Ship") +
                   $"Ship's passengers amount is {_passengersAmount};\n" +
                   $"Ship's port of registry is {_registryPort};\n";
        }
    }
}