using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle : Shape,IPersist, IComparable
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double Height,double Width)
        {
           this.Height = Height;
            this.Width = Width;
        }
        public override double Area
        {
            get { return Height * Width; }
        }
        public override void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine("Height: " + Height + " Width: " + Width);
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine("Height: "+ Height + "Width: " + Width);
        }

        public int CompareTo(object r)
        {
            Rectangle re = r as Rectangle;
            if (re == null)
            {
                throw new InvalidCastException("can't compare - invalid cast");
            }
            else {
               
                if (this.Area > re.Area) return 1;
                if (this.Area < re.Area) return -1;
                return 0;
            }
        }
    }
}
