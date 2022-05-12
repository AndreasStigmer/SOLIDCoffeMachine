using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    public class CoffeMachine
    {

        public void Brew(Beverage beverage)
        {
            if(beverage.Type== BrewType.Tea)
            {
                double water = CalculateAmountOfWater(beverage);
                Console.WriteLine($"Brewing a {beverage.Size.ToString()} of {beverage.Type.ToString()} with {water} units of water");

            }
            else if(beverage.Type == BrewType.Coffe)
            {
                double coffeAmount = CalcCoffeAmountToGrind(beverage);
                GrindCoffe();
                double water = CalculateAmountOfWater(beverage);
                Console.WriteLine($"Brewing a {beverage.Size.ToString()} of {beverage.Type.ToString()} with {coffeAmount} units of coffe and {water} units of water");

            }
            else if (beverage.Type == BrewType.Cappuchino)
            {
                double coffeAmount = CalcCoffeAmountToGrind(beverage);
                GrindCoffe();
                double water = CalculateAmountOfWater(beverage);
                double milk = CalcCoffeAmountOfMilk(beverage);
                SkimMilk();
                Console.WriteLine($"Brewing a {beverage.Size.ToString()} of {beverage.Type.ToString()} with {coffeAmount} units of coffe , {milk} units of milk and {water} units of water");

            }
            else if (beverage.Type == BrewType.Latte)
            {
                double coffeAmount = CalcCoffeAmountToGrind(beverage);
                GrindCoffe();
                double water = CalculateAmountOfWater(beverage);
                double milk = CalcCoffeAmountOfMilk(beverage);
                SkimMilk();
                Console.WriteLine($"Brewing a {beverage.Size.ToString()} of {beverage.Type.ToString()} with {coffeAmount} units of coffe , {milk} units of milk coffe and {water} units of water");

            }
        }

        public void GrindCoffe()
        {
            Console.WriteLine("Grind Coffe");
        }

        public void SkimMilk()
        {
            Console.WriteLine("Skim Milk");
        }

        public double CalculateAmountOfWater(Beverage beverage)
        {
            double water = 0;
            if(beverage.Size == Size.Small)
            {
                water=1.5;
            }
            else if (beverage.Size == Size.Normal)
            {
                water = 3;
            }
            else if (beverage.Size == Size.Large)
            {
                water = 4;
            }
            else if (beverage.Size == Size.Kettle)
            {
                water = 10;
            }
            else
            {
                water = 0;
            }

            if(beverage.Type==BrewType.Cappuchino || beverage.Type==BrewType.Latte)
            {
                water /= 2;
            }
            return water;
        }

        public double CalcCoffeAmountOfMilk(Beverage beverage)
        {
            double amount = 0;

            if (beverage.Size == Size.Small)
            {
                amount = 1;
            }
            else if (beverage.Size == Size.Normal)
            {
                amount = 1.5;
            }
            else if (beverage.Size == Size.Large)
            {
                amount = 2;
            }
            else
            {
                throw new ArgumentException("Cant brew a kettle of capuchino or Latte");
            }
            return amount;
        }

        public double CalcCoffeAmountToGrind(Beverage beverage)
        {
            double amount = 0;
            
            if(beverage.Size== Size.Small)
            {
                amount = 1;
            }
            else if (beverage.Size == Size.Normal)
            {
                amount = 1.5;
            }
            else if (beverage.Size == Size.Large)
            {
                amount = 2;
            }
            else if (beverage.Size == Size.Kettle)
            {
                amount = 6;
            }
            amount = amount * (double)beverage.Strength;
            return amount;
        }
    }

    public class Beverage
    {
        public Size Size { get; set; }
        public Strength Strength { get; set; }
        public BrewType Type { get; set; }

    }

    public enum Size
    {
        Small,
        Normal,
        Large,
        Kettle
    }

    public enum Strength
    {
        Normal,
        Strong,
        SuperStrong
    }

    public enum BrewType
    {
        Coffe,
        Cappuchino,
        Latte,
        Tea
    }
}
