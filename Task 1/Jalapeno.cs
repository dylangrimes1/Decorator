using Decorator.Components;
using Decorator.Decorators;

namespace Decorator.Decorators
{
    public class Jalapeno : CondimentDecorator
    {
        private readonly Pizza _vegetable;

        public Jalapeno(Pizza vegetable)
        {
            _vegetable = vegetable;
        }

        public override double Cost()
        {
            return .30 + _vegetable.Cost();
        }

        public override string Description => _vegetable.Description + ", Jalapeno";
    }
}


