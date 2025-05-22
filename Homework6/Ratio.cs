using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Ratio
    {
        public int A;
        public int B;

        public Ratio() 
        {
            A= 0;
            B= 0;
        }

        public Ratio (int a, int b)
        {
            A = a;
            B = b;
        }

        public Ratio(Ratio r) 
        {
            this.A = r.A;
            this.B = r.B;
        }

        public Ratio add(Ratio r)
        {
            Ratio result = new Ratio();

            result.B = this.B * r.B;
            result.A = this.A * r.B + r.A * this.B;

            return result;
        }

        public Ratio add(int a)
        {
            Ratio result = new Ratio();

            result.B = this.B;
            result.A = this.A + a * this.B;
            
            return result;
        }

        public Ratio Mul(Ratio r)
        {
            Ratio result = new Ratio();
            result.B = this.B * r.B;
            result.A = this.A * r.A;
            return result;
        }

        public Ratio Mul(int a)
        {
            Ratio result = new Ratio();
            result.B = this.B;
            result.A = a * this.A;
            return result;
        }

    }
}
