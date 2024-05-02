using System;

namespace form
{
    public class triangle
    {
        public double A, B, C;

        public double GetSideA
        {
            get { return A; }
            set { A = value; }
        }

        public double GetSideB
        {
            get { return B; }
            set { B = value; }
        }

        public double GetSideC
        {
            get { return C; }
            set { C = value; }
        }

        public bool ExistTriagle
        {
            get
            {
                if (A + B > c && A + C > b && B + C > a) { return true; }
                else { return false; }
            }
        }

        public double Prineter()
        {
            return A + B + C;
        }
        public double Area()
        {
            double p;
            p = (A + B + C) / 2;
            p = Math.Sqrt((p * (p - A) * (p - B) * (p - C)));
            return p;
        }
        public double height()
        {
            h = Math.Sqrt(b * b - (a / 2) * *2)
                return h;
            
        }
    }    
}

