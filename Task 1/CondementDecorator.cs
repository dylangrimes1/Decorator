using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class CondimentDecorator : Pizza
    {
        public abstract override string Description { get; }
    }
}


