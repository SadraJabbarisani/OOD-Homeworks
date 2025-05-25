using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18
{
    internal class Ratio
    {
        
        //---------statics----------------

        static readonly Ratio neg1 = new Ratio(-1, 1);

        public static Ratio operator +(Ratio r1, Ratio r2)
        {
            return r1.add(r2);
        }

        public static Ratio operator -(Ratio r1, Ratio r2)
        {
            return r1.sub(r2);
        }

        public static Ratio operator *(Ratio r1, Ratio r2)
        {
            return r1.Mul(r2);
        }

        public static Ratio operator /(Ratio r1, Ratio r2)
        {
            return r1.div(r2);
        }

        public static bool operator ==(Ratio r1, Ratio r2)
        {
            if (ReferenceEquals(r1, r2))
                return true;

            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null))
                return false;

            return r1.A * r2.B == r2.A * r1.B;
        }

        public static bool operator !=(Ratio r1, Ratio r2)
        {
            return !(r1 == r2);
        }

        public static bool operator > (Ratio r1, Ratio r2)
        {
            if (r1.A * r2.B > r2.A * r1.B)
                return true;
            else
                return false;
        }

        public static bool operator >=(Ratio r1, Ratio r2)
        {
            if (r1 > r2 || r1 == r2)
                return true;
            else
                return false;
        }

        public static bool operator < (Ratio r1, Ratio r2)
        {
            return !(r1 >= r2);
        }

        public static bool operator <=(Ratio r1, Ratio r2)
        {
            return !(r1 > r2);
        }

        //------------fields--------------

        private int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = (value == 0 ? 1 : value); }
        }

        //----------------------------------

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

        public Ratio (int a)
        { 
            A = a;
            B = 1;
        }

        public Ratio(Ratio r) 
        {
            this.A = r.A;
            this.B = r.B;
        }

        //----------------------------------

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

        public Ratio sub(Ratio r)           // I added
        {
            r = r.Mul(Ratio.neg1);
            return this.add(r);
        }

        public Ratio sub(int a)             // I added
        {
            a = a * -1;
            return this.add(a);
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

        public Ratio div(Ratio r)           // I added
        {
            r = r.reverse();
            return this.Mul(r);
        }

        public Ratio Div(int a)             // I added
        {
            Ratio result = new Ratio(this);
            result.B *= a;
            
            return result;
        }

        private Ratio reverse()             // I added
        {
            return new Ratio(this.B,this.A);
        }

    }
}
