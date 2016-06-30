using ShapeLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    class ShapeManager
    {
        ArrayList shapes = new ArrayList();
        public void add(Shape shape)
        {
            shapes.Add(shape);
        }
        public void DisplayAll()
        {
            foreach (Shape shape in shapes)
            {              
                    shape.Display();
                    Console.WriteLine(shape.Area);                
        }
        }
        public Shape this[int x]
        {
            get { return shapes[x] as Shape; }
        }
        public int Count
        {
            get
            {
                return shapes.Count;
            }          
        }
        public void Save(StringBuilder sb)
        {
            foreach (Shape shape in shapes)
            {
                if (shape is IPersist)
                {
                    ((IPersist)shape).Write(sb);
                }
            }
        }
        static void Main(string[] args)
        {
            try {
                ShapeManager sm = new ShapeManager();
                sm.add(new Rectangle(5, 4));
                sm.add(new Circle(3));
                sm.add(new Elipse(3, 3));
                sm.add(new Rectangle(5, 6));
                sm.add(new Elipse(6, 8));
                sm.add(new Circle(4));
                sm.DisplayAll();
                Shape s = sm[0];
                Rectangle r = (Rectangle)s;
                StringBuilder sb = new StringBuilder();
                sm.Save(sb);
                Console.WriteLine(sb.ToString());

                Rectangle r1 = (Rectangle)sm[0];
                Rectangle r2 = (Rectangle)sm[3];
                Console.WriteLine(r2.CompareTo(r1));
                Elipse e1 = (Elipse)sm[2];
                Elipse e2 = (Elipse)sm[4];
                Console.WriteLine(e2.CompareTo(e1));
                Circle c1 = (Circle)sm[1];
                Circle c2 = (Circle)sm[5];
                Console.WriteLine(c1.CompareTo(e1));
                c1.Display();


                Console.WriteLine(sm.Count);

            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    }