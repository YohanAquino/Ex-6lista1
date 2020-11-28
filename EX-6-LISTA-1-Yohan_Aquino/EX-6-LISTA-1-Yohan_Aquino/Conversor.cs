using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6_LISTA_1_Yohan_Aquino
{
    class Conversor
    {
        private double c;
        private double d;
        private double r;

        public void setCotacao(double x)
        {
            c = x;
        }
        public void setDolar(double x)
        {
            d = x;
        }
        public void calcularReal() 
        {
            r = d * c;
        }
        public Double getReal()
        {
            return r;
        }
    }
}
