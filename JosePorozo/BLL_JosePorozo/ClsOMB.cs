using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_JosePorozo
{
    public class ClsOMB
    {
        private Double N1, N2;
        public double N11 { get => N1; set => N1 = value; }
        public double N21 { get => N2; set => N2 = value; }

        public double sumar()
        {


            return N11 + N21;
        }
        public double restar()
        {

            return N11 - N21;
        }
        public double multiplicar()
        {


            return N11 * N21;
        }
        public double Dividir()
        {

            return N11 / N21;
        }

    }
}