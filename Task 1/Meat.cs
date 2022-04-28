using Decorator.Components;

namespace Decorator.Components
{
    public class Meat : Pizza
    {
        public Meat()
        {
            Description = "Meat";
        }

        public override double Cost()
        {
            return 12.50;
        }
    }
}


