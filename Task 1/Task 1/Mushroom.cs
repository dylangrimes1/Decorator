using Decorator.Components;
using Decorator.Decorators;

namespace Decorator.Decorators
{
    public class Mushroom : CondimentDecorator
    {
        private readonly Pizza _vegetable;

        public Mushroom(Pizza vegetable)
        {
            _vegetable = vegetable;
        }

        public override double Cost()
        {
            return .20 + _vegetable.Cost();
        }

        public override string Description => _vegetable.Description + ", Mushroom";
    }
}


