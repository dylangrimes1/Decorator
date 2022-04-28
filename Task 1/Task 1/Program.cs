using System;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza pizza = new Margherita();
            Console.WriteLine(pizza.Description + " $" + pizza.Cost());

            Pizza pizza2 = new CreateYourOwn();
            pizza2 = new Jalapeno(pizza2);
            pizza2 = new Sweetcorn(pizza2);
            pizza2 = new Onion(pizza2);
            Console.WriteLine(pizza2.Description + " $" + pizza2.Cost());

            Pizza pizza3 = new Meat();
            pizza3 = new Jalapeno(pizza3);
            pizza3 = new Mushroom(pizza3);
            Console.WriteLine(pizza3.Description + " $" + pizza3.Cost());
        }
    }
}

