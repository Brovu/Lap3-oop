using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    class VeMayBay
    {
        public String MaVe { get; set; }
        public String HoTen { get; set; }

        DateTime NgayMua = Convert.ToDateTime("01/01/2023");
        DateTime NgayKhoiHanh = Convert.ToDateTime("02/03/2023");
        public String LoaiVe { get; set; }

        public int GiaSan = 500;

        public VeMayBay() {}

        public VeMayBay(string maVe, string hoTen, string loaiVe)
        {
            MaVe = maVe;
            HoTen = hoTen;
            LoaiVe = loaiVe;
        }

        public void Nhap()
        {
            Console.Write("Ma ve: ");
            MaVe = Console.ReadLine();
            Console.Write("Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Loai Ve: ");
            LoaiVe = Console.ReadLine();
        }

        

        public double TinhTienVe(double giaVe)
        {
            double tiLeGiamGia;
            double tongSoTien;
            if (LoaiVe == "First")
            {
                giaVe = GiaSan * 3;
            } else if(LoaiVe == "Business")
            {
                giaVe = GiaSan * 2;
            } else if(LoaiVe == "Prenium")
            {
                giaVe = GiaSan * 1.5;
            }
            TimeSpan Kqua = NgayKhoiHanh - NgayMua;
            int SoNgay = Kqua.Days;
            tiLeGiamGia = SoNgay * 0.5 / 100;
            
            tongSoTien = giaVe * tiLeGiamGia;

            return tongSoTien * 10 / 100;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma Ve: {0}", MaVe);
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Loai Ve: {0}", LoaiVe);
            Console.WriteLine("Ngay mua: {0}", NgayMua);
            Console.WriteLine("Ngay khoi hanh: {0}", NgayKhoiHanh);
            Console.WriteLine("Gia Ve:{0}", TinhTienVe(0));
        }

        public static double operator+(float s, VeMayBay ve)
        {
            return s + ve.TinhTienVe(0);
        }

        public static bool operator<(VeMayBay v1, VeMayBay v2)
        {
            return v1.TinhTienVe(0) < v2.TinhTienVe(0);
            
        }

        public static bool operator >(VeMayBay v1, VeMayBay v2)
        {
            return v1.TinhTienVe(0) > v2.TinhTienVe(0);

        }
    }
}
