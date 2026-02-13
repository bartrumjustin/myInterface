namespace myInterface
{
    interface IStatePower
    {
        string State { get; set; }
        string Fuel { get; set; }

        string Display();
    }
    internal class Program
    {
        class PowerPlant : IStatePower
        {
            //interface
            public string State { get; set; }
            public string Fuel { get; set; }
            //class prop
            public int Power { get; set; }
            public string Name { get; set; }
            //default
            public PowerPlant()
            {
                State = string.Empty;
                Fuel = string.Empty;
                Name = string.Empty;
                Power = 0;
            }
            //param
            public PowerPlant(string state, string fuel, int power, string name)
            {
                State = state;
                Fuel = fuel;
                Name = name;
                Power = power;
            }
            public string Display()
            {
                return "Power Plant: " + Name + "\nLocation: " + State + "\nFuel Type: " + Fuel + "\nPower Output (MW): " + Power + "\n\n";

            }
        }
        static void Main(string[] args)
        {
            PowerPlant one = new PowerPlant("Michigan", "Nuclear", 800, "Palisades");
            Console.WriteLine(one.Display());

            PowerPlant two = new PowerPlant();
            two.Name = "San Onofre";
            two.Power = 2200;
            two.State = "California";
            two.Fuel = "Nuclear";
            Console.WriteLine(two.Display());
        }
    }
}
