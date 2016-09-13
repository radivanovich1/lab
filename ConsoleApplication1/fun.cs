using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


   public class Calc
    {        

        public static double Sum(double s1, double s2 )
        {

            double s = s1 + s2;
            return s;
        
        }

        public static double Sub(double m1, double m2)
        {

            double m = m1 - m2;
            return m;

        }

        public static double Mult(double u1, double u2)
        {

            double u = u1 * u2;
            return u;

        }
        public static double Div(double d1, double d2)
        {

            double d = d1/d2;
            return d;

        }

        
    }
}
