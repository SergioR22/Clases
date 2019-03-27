using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Division
    {
        double v7, v8, resultadoD;

        public double ResultadoD
        {
            get { return resultadoD; }
            set { resultadoD = value; }
        }

        public double V8
        {
            get { return v8; }
            set { v8 = value; }
        }

        public double V7
        {
            get { return v7; }
            set { v7 = value; }
        }
        public Division()
        {
            this.v7 = 0;
            this.v8 = 0;
        }

        public double CalcularD()
        {
            resultadoD = v7 / v8;
            return resultadoD;
        }
    }
}
