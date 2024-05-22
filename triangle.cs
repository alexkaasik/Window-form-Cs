using System;
namespace form
{ 
    public class triangle
    {
        public int Perimeter(int A, int B, int C)
        {
            return A + B + C;
        }

        public double Area(int A, int B, int C)
        {
            double p;
            p =  (1.0/4.0)*Math.Sqrt( (4*(Math.Pow(A,2)* Math.Pow(B,2)) ) - Math.Pow( Math.Pow(A,2) + Math.Pow(B,2) - Math.Pow(C,2),2 ) );
            return Math.Round(p,2);
        }
        public double Height(int A, int B, int C, char mode)
        {
            double h = 0;
            double test = Math.Sqrt((4 * (Math.Pow(A, 2) * Math.Pow(B, 2))) - Math.Pow(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2), 2));
            
            if ( mode == 'a' ) { h = (0.5 / A) * test; }
            if ( mode == 'b') { h = (0.5 / B) * test; }
            if ( mode == 'c') { h = (0.5 / C) * test; }

            return Math.Round(h, 2);
        }

        public double deg(int A, int B, int C, char mode) {
            double answer = 0.0;
            double value = 0.0;

            if (mode == 'a') { answer = ( ( Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / ( 2 * C * B) ); }
            if (mode == 'b') { answer = ( ( Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / ( 2 * A * C) ); }
            if (mode == 'c') { answer = ( ( Math.Pow(B, 2) + Math.Pow(A, 2) - Math.Pow(C, 2)) / ( 2 * A * B) ); }

            value = Math.Round( (Math.Acos(answer) * 180 / Math.PI), 3);
            //Console.WriteLine(value);
            return value;
        }

        public string nameTri(double A, double B, double C) {
            string answer = "";

            if (A == B && B == C && C == A) { answer = "Equilateral"; }
            else if (A == B || B == C || C == A) { answer = "Isosceles"; }
            else if ( A == 90.0 || B == 90.0 || C == 90.0) { answer = "Right"; }
            else if (A >= 90.0 || B >= 90.0 || C >= 90.0) { answer = "Obtuse"; }
            else if (A < 90.0 && B < 90.0 && C < 90.0) { answer = "Acute"; }

            return answer;
        }

        public bool checkValidity(int A, int B, int C)
        {
            // check condition 
            if (A + B <= C || A + C <= B || B + C <= A)
                return false;
            else
                return true;
        }
    }
}