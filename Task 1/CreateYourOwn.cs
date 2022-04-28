using Decorator.Components;

namespace Decorator.Components
{
    public class CreateYourOwn : Pizza
    {
        public CreateYourOwn()
        {
            Description = "Create your own";
        }

        public override double Cost()
        {
            return 10;
        }
    }
}


