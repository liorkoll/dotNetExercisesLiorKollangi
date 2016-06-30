using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Elipse
    {
        double Radius { get; set; }
        public Circle(double Radius):base(Radius,Radius) {
            this.Radius = Radius;
            
            }
      
        public override void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine("Radius: " + Radius);
        }
        


    }
}
