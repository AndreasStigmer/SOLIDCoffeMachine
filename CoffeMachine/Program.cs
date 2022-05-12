using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brewing som brew");
            CoffeMachine machine = new CoffeMachine();

            Beverage b = new Beverage() { Size = Size.Large, Type = BrewType.Cappuchino, Strength = Strength.Strong };
            machine.Brew(b);

            Console.WriteLine("Brewing som brew");
            Beverage b2 = new Beverage() { Size = Size.Normal, Type = BrewType.Coffe, Strength = Strength.Strong };
           
            machine.Brew(b2);
        }
    }
}
