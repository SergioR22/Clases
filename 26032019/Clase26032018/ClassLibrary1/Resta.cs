using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Resta
   {
       double v3, v4, resultadoR;

       public double ResultadoR
       {
           get { return resultadoR; }
           set { resultadoR = value; }
       }

       public double V4
       {
           get { return v4; }
           set { v4 = value; }
       }

       public double V3
       {
           get { return v3; }
           set { v3 = value; }
       }

        
        public Resta() 
        {
            this.v3 = 0;
            this.v4 = 0;
        }

        public double CalcularR()
        {
            resultadoR = v3 - v4;
            return resultadoR;
        }

    }
}

