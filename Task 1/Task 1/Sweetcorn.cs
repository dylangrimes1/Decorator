using Decorator.Components;
using Decorator.Decorators;

namespace Decorator.Decorators
{
    public class Sweetcorn : CondimentDecorator
    {
        private readonly Pizza _vegetable;

        public Sweetcorn(Pizza vegetable)
        {
            _vegetable = vegetable;
        }

        public override double Cost()
        {
            return .20 + _vegetable.Cost();
        }

        public override string Description => _vegetable.Description + ", Sweetcorn";
    }
}


