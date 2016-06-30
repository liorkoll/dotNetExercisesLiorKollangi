using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeLib
{
    public class Elipse: Shape,IPersist,IComparable
    {
        public double Radius1 { get; set; }
        public double Radius2 { get; set; }

        public Elipse(double Radius1, double Radius2)
        {
            this.Radius1 = Radius1;
            this.Radius2 = Radius2;
        }
        public override double Area
        {
            get { return Radius1 * Radius2 * Math.PI; }
        }
        public override void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine("Radius1: " + Radius1 + " Radius2: " + Radius2);
        }
        public void Write(StringBuilder sb)
        {
            sb.AppendLine("Radius1: " + Radius1 + " Radius2: " + Radius2);
        }
        
        public int CompareTo(object e)
        {
            Elipse e1 = e as Elipse;
            if (e1== null)
            {
                throw new InvalidCastException("can't compare - invalid cast");
            }
            Elipse el = (Elipse)e;
            if (this.Area > el.Area) return 1;
            if (this.Area < el.Area) return -1;
            return 0;
        }
    }

    
}

