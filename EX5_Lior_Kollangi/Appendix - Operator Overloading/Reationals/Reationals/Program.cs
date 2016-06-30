using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reationals
{
    class Program
    {
        
     
        static void Main(string[] args)
        {
            Rational R1 = new Rational(1, 2);
            Rational R2 = new Rational(1,3);
            Rational R3= R1.Mul(R2);
            R3.Reduce();
          //  Console.WriteLine(R1.ToString());
           // Console.WriteLine(R2.ToString());
           // Console.WriteLine(R3.ToString());
           // Console.WriteLine(R1.Equals(R2));
           // Console.WriteLine(R1 + R2);
           // Console.WriteLine(R1 - R2);
           // Console.WriteLine(R1 * R2);
           // Console.WriteLine(R1 / R2);
            Console.WriteLine((double)(R2));
            Rational R4= (Rational)(4);
            Console.WriteLine(R4.ToString());


        }
    }
    struct Rational
    {
     
        public Rational(int Numerator, int Denominator)
        {
           this.Numerator = Numerator;
           this.Denominator = Denominator;
        }
        public Rational(int Numerator)
            : this(Numerator, 1)
        {

        }
        public int Numerator
        {
            get;
            set;
        }

        public int Denominator
        {
            get;
            set;
        }
        public double Value
        {
            get
            {
                return (double)(Numerator) / Denominator;
                
            }
        }

        public Rational Add(Rational x)
        {
            int d = x.Denominator * this.Denominator;
            int n = d / x.Denominator * x.Numerator - d / this.Denominator * this.Numerator;
            return new Rational(n,d);
        }
        public Rational Sub(Rational x)
        {
            int d = x.Denominator * this.Denominator;
            int n = d / x.Denominator * x.Numerator + d / this.Denominator * this.Numerator;
            return new Rational(n, d);
        }



        public Rational Mul(Rational x)
        {
            int d = x.Denominator * this.Denominator;
            int n = x.Numerator * this.Numerator;
            return new Rational(n, d);
        }
        public Rational Div(Rational x)
        {
            int d = x.Numerator * this.Denominator;
            int n = x.Denominator * this.Numerator;
            return new Rational(n, d);
        }


        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        public void Reduce()
        {
            int g = GCD(Numerator, Denominator);
           
           int d = Denominator / g;
           int n = Numerator / g;
           this.Numerator = n;
           this.Denominator = d;
            // only needed for negative numbers
            if (Denominator < 0) { Denominator = -Denominator; Numerator = -Numerator; }
        }
     override
            public string ToString()
        {
            if (Denominator == 1) {
                return Numerator + "";
            }
            return Numerator + "/" + Denominator;
        }
        override
      public bool Equals(Object r) {
            if (r == null)
            {
                return false;
            }
            Rational b = (Rational)r;
            return compareTo(b) == 0;            
    }
        public int compareTo(Rational b)
        {
            Rational a = this;
            int lhs = a.Numerator * b.Denominator;
            int rhs = a.Denominator * b.Numerator;
            if (lhs < rhs) return -1;
            if (lhs > rhs) return +1;
            return 0;
        }
        override
        public int GetHashCode()
            
        {
            return this.ToString().GetHashCode();
        }
        public static Rational operator +(Rational r1,Rational r2)
        {
            return r1.Add(r2);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return r1.Mul(r2);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return r1.Sub(r2);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return r1.Div(r2);
        }
        public static explicit operator double(Rational r)
        {

            return r.Value;

        }
        public static implicit operator Rational(int number)
        {

            Rational r = new Rational(number);

        return r;

        }






    }



}
