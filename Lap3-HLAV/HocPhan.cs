using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    class HocPhan
    {
        public String MaHocPhan { get; set; }
        public String TenHP { get; set; }

        public int SoTinChi { get; set; }

        public int SoTinChiThucHanh { get; set; }

        public int HocPhiMotTinChi = 250;

        public HocPhan(string maHocPhan, string tenHP, int soTinChi, int soTinChiThucHanh)
        {
            MaHocPhan = maHocPhan;
            TenHP = tenHP;
            SoTinChi = soTinChi;
            SoTinChiThucHanh = soTinChiThucHanh;
        }

        public HocPhan() { }

        public void nhapThongTinHP()
        {
            Console.Write("Ma HP: ");
            MaHocPhan = Console.ReadLine();

            Console.Write("Ten HP: ");
            TenHP = Console.ReadLine();

            Console.Write("So tin chi: ");
            SoTinChi = int.Parse(Console.ReadLine());

            Console.Write("So tin chi thuc hanh: ");
            SoTinChiThucHanh = int.Parse(Console.ReadLine());
        }

        public static double operator +(int s, HocPhan hp) {
            return s + hp.TinhHocPhi(); 
            }



        public double TinhHocPhi()
        {
            return SoTinChiThucHanh * HocPhiMotTinChi * 1.5 + (SoTinChi - SoTinChiThucHanh) * HocPhiMotTinChi;
        }

        
    }
}
