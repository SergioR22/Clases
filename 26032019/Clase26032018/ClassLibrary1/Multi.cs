using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Multi
    {
        double v5, v6, resultadoM;

        public double ResultadoM
        {
            get { return resultadoM; }
            set { resultadoM = value; }
        }

        public double V6
        {
            get { return v6; }
            set { v6 = value; }
        }

        public double V5
        {
            get { return v5; }
            set { v5 = value; }
        }
        public Multi() 
        {
            this.v5 = 0;
            this.v6 = 0;
        }

        public double CalcularM()
        {
            resultadoM = v5 * v6;
            return resultadoM;
    }
}
}
