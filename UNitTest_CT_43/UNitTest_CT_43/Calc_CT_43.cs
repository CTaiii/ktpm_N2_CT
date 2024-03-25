using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNitTest_CT_43
{
    public class Calc_CT_43
    {
        private int a, b;
        public Calc_CT_43(int a , int b)
        {
            this.a = a;
            this.b = b;
        }
        public int X_CT_43( string CalSymbol)
        {
            int kq = 0;
            switch (CalSymbol)
            {
                case "+":
                    kq = this.a + this.b;
                    break;
                case "-":
                    kq = this.a - this.b;
                    break;
                case "*":
                    kq = this.a * this.b;
                    break;
                case "/":
                    kq = this.a / this.b;
                    break;
            }
            return kq;
        }
    }
}
