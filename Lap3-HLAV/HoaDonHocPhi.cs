using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    class HoaDonHocPhi
    {
        private List<HocPhan> dsHocPhan = new List<HocPhan>();
        public String MaSoSV { get; set; }
        public String HoTen { get; set; }

        int s = 0;
        public HoaDonHocPhi() { 
            MaSoSV = "";
            HoTen = "";
        }
        
        public void nhapSoHP()
        {
            Console.Write("Ma so sv: ");
            MaSoSV = Console.ReadLine();
            Console.Write("Ten SV: ");
            HoTen = Console.ReadLine();
            do
            {
                Console.Write("Nhap so luong hoc phan dang ky: ");
                int soLuong = int.Parse(Console.ReadLine());
                if (soLuong >= 2 && soLuong <= 9)
                {
                    for (int i = 0; i < soLuong; i++)
                    {
                        Console.WriteLine("Nhap thong tin hoc phan thu {0}:", i + 1);
                        HocPhan hp = new HocPhan();
                        hp.nhapThongTinHP();
                        dsHocPhan.Add(hp);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("So luong hoc phan dang ky khong hop le. Vui long nhap lai!");
                }
            } while (true);

        }


        public void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine("Ma so sv: {0}, ten sinh vien: {1}", MaSoSV, HoTen);
             
            Console.WriteLine("{0,-10} {1, -20} {2, -10} {3, -20} {4, -10}", "Ma HP", "Ten HP", "Stc", "So tcth", "Hoc Phi");
            foreach (HocPhan hp in dsHocPhan)
            {
                s += hp.SoTinChiThucHanh;
                Console.WriteLine("{0,-10} {1, -20} {2, -10} {3, -20} {4, -10}", hp.MaHocPhan, hp.TenHP, hp.SoTinChi, hp.SoTinChiThucHanh, hp.TinhHocPhi());
            }

            Console.Write("Tong so tin chi thuc hanh: {0}", s);
        }

    }
}
