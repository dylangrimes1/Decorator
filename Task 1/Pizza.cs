using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Components
{
    public abstract class Pizza
    {
        public virtual string Description { get; protected set; } = "Unknown Pizza";

        public abstract double Cost();
    }
}

