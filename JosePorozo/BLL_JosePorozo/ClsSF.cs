using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_JosePorozo
{
    public class ClsSF
    {
       
        public string SEF(int n)
        {
            int i = 0 ;

            int s = 1;
            string Lista = "" ;

            for(int a=0; a<=n; a++)
            {
                int z;
                z=i;
                i=s;
                s=z+i;
                if (a == n)
                { Lista = Lista + s.ToString(); }
                else
                { Lista = Lista + s.ToString() + " "; }

            }




            return Lista;
        }



        
    }
}
