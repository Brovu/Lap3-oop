using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    class HocVien
    {
        public String maHV { get; set; }
        public String hoTen { get; set; }

        public String lopHoc;
        public int soTietHoc;
        public int hocPhiMotTiet = 100;

        public HocVien() { }

        public HocVien(string maHV, string hoTen, string lopHoc, int soTietHoc, int hocPhiMotTiet)
        {
            this.maHV = maHV;
            this.hoTen = hoTen;
            this.lopHoc = lopHoc;
            this.soTietHoc = soTietHoc;
            this.hocPhiMotTiet = hocPhiMotTiet;
        }

        public void NhapThongTinHocVien()
        {
            Console.Write("Ma Hoc Vien: ");
            maHV= Console.ReadLine();
            Console.Write("Ho va Ten hoc vien: ");
            hoTen= Console.ReadLine();
            Console.Write("Lop: ");
            lopHoc= Console.ReadLine();
            Console.Write("So tiet hoc: ");
            soTietHoc = int.Parse(Console.ReadLine());
        }

        public double TinhHocPhi()
        {
            double tienHocPhi = soTietHoc * hocPhiMotTiet;
            if (soTietHoc > 50) tienHocPhi -= tienHocPhi * 10 / 100;
            else if (soTietHoc > 30 && soTietHoc <= 50) tienHocPhi -= tienHocPhi * 7 / 100;
            else return tienHocPhi;
            return tienHocPhi;
        }

        public void Xuat()
        {
            Console.WriteLine("Thong tin hoc vien vua nhap: ");
            Console.WriteLine("Ho Ten hoc vien: {0}", hoTen);
            Console.WriteLine("Lop: {0}", lopHoc);
            Console.WriteLine("So tiet hoc: {0}", soTietHoc);
            Console.WriteLine("Hoc Phi: {0}", TinhHocPhi());
        }

        public static double operator +(double s, HocVien hv)
        {
            return s + hv.TinhHocPhi();
        }
    }
}
