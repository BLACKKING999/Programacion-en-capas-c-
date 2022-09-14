using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_JosePorozo
{
    public class ClsOT
    { 
        public double CalcularAreaCirculo( double R)
        {
        Double Pi = 3.1416;

            return (Pi *(R*R));
            
        }

        public double CalcularTriangulo(double Base, double Altura)
        { return (Base * Altura)/2; }


        public double CalcularAreaRectangulo(double Base, double Altura)
        {
            return (Base * Altura);
        }
        
    }
}