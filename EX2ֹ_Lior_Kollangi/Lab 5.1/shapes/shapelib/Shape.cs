using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        public ConsoleColor Color { get;set;}
        public Shape(ConsoleColor Color)
        {
            this.Color = Color;
        }
        public Shape()
        {
            this.Color = ConsoleColor.White;
        }
        public virtual void Display()
        {
            Console.BackgroundColor = Color;
        }
        public abstract double Area { get; }

    }
}
