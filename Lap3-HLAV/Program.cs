using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    internal class Program
    {
        static void VeMayBay()
        {

            int n;

            do
            {
                Console.Write("Nhap so ve: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 20);

            VeMayBay[] dsVe = new VeMayBay[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin ve thu {0}", i + 1);
                dsVe[i] = new VeMayBay();
                dsVe[i].Nhap();
            }

            Console.WriteLine("Ds ve may bay theo gia giam dan: ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (dsVe[j] < dsVe[i])
                    {
                        VeMayBay temp = dsVe[i];
                        dsVe[i] = dsVe[j];
                        dsVe[j] = temp;
                    }
                }
            }
            foreach (VeMayBay ve in dsVe)
            {
                ve.Xuat();
            }

            double tongTienVe = 0;
            int countBusiness = 0;

            foreach(VeMayBay ve in dsVe)
            {
                tongTienVe += ve.TinhTienVe(0);
                if(ve.LoaiVe == "Business")
                {
                    countBusiness++;
                }
            }

            double tienVeTB = tongTienVe / n;

            Console.WriteLine("Tong tien ve cua {0} ve may bay la: {1}", n, tongTienVe);
            Console.WriteLine("Tien ve trung binh cua {0} ve may bay la: {1}", n, tienVeTB);
            Console.WriteLine("So luong ve may bay loai Business la: {0}", countBusiness);



        }

        static void HoaDonHocPhi()
        {
            HoaDonHocPhi hd = new HoaDonHocPhi();
            hd.nhapSoHP();
            hd.Xuat();
        }

        static void PhanSo()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(2, 3);
            p1.XuatPhanSo();
            p2.XuatPhanSo();

            PhanSo p3 = p1 + p2;
            p3.XuatPhanSo();
        }

        static void HocVien()
        {
            Console.Write("Nhap so luong hoc vien: ");
            int n = int.Parse(Console.ReadLine());
            HocVien[] dsHV = new HocVien[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}");
                dsHV[i] = new HocVien();
                dsHV[i].NhapThongTinHocVien();
            }

            double tongHocPhi = 0;

            foreach(HocVien hv in dsHV)
            {
                tongHocPhi += hv.TinhHocPhi();
                hv.Xuat();
            }
            Console.Write("Tong hoc phi cua {0} hoc vien la {1}", n, tongHocPhi);
        }

        static void Time()
        {
            Time t1 = new Time();

            t1++;
            t1.Show();

            Time t2 = new Time(10, 30, 45);

            t2--;
            t2.Show();

            Console.Write("Nhap gia tri s: ");
            int s = int.Parse(Console.ReadLine());

            Time t3 = t1 + s;
            t3.Show();
        }
        static void Main(string[] args)
        {

            //VeMayBay();
            //HoaDonHocPhi();
            //PhanSo();
            //HocVien();
            Time();
            Console.ReadKey();
        }
    }
}
