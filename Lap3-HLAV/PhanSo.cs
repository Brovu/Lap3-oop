using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    class PhanSo
    {
        public int tuSo { get; set; }
        public int mauSo { get; set; }

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int tu, int mau)
        {
            tuSo = tu;
            mauSo = mau;
        }


        public int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public PhanSo RutGon()
        {
            tuSo /= UCLN(tuSo, mauSo);
            mauSo /= UCLN(tuSo, mauSo);
            return this;
        }

        public static PhanSo operator +(PhanSo s1, PhanSo s2)
        {
            PhanSo p = new PhanSo();
            p.tuSo = s1.tuSo * s2.mauSo + s2.tuSo * s1.mauSo;
            p.mauSo = s1.mauSo * s2.mauSo;
            return p.RutGon();
        }

        public static PhanSo operator -(PhanSo s1, PhanSo s2)
        {
            PhanSo p = new PhanSo();
            p.tuSo = s1.tuSo * s2.mauSo - s2.tuSo * s1.mauSo;
            p.mauSo = s1.mauSo * s2.mauSo;
            return p.RutGon();
        }

        public static PhanSo operator *(PhanSo s1, PhanSo s2)
        {
            PhanSo p = new PhanSo();
            p.tuSo = s1.tuSo * s2.tuSo;
            p.mauSo = s1.mauSo * s2.mauSo;
            return p.RutGon();
        }

        public static PhanSo operator /(PhanSo s1, PhanSo s2)
        {
            PhanSo p = new PhanSo();
            p.tuSo = s1.tuSo * s2.mauSo;
            p.mauSo = s1.mauSo * s2.tuSo;
            return p.RutGon();
        }

      
        public void XuatPhanSo()
        {
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }

    }

}
