using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_JosePorozo
{
    public class ClsLogin
    {

        private string usuario = "POROZO";
        private string clave = "1234";

        public bool autentificar(string Usuario, string Clave)
        {

            bool res = false;

            if (Usuario == usuario && Clave == clave)
            {
                res = true;
            }
            /* else
             {
                 res = false;
             }
             */
            return res;
        }

    }
}


