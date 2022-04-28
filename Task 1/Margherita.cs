using Decorator.Components;

namespace Decorator.Components
{
    public class Margherita : Pizza
    {
        public Margherita()
        {
            Description = "Margherita";
        }

        public override double Cost()
        {
            return 9.50;
        }
    }
}


