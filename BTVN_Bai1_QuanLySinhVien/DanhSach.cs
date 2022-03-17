using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Các phương thức
◼ Nhập danh sách sinh viên
◼ In thông tin các sinh viên có trong danh sách
◼ Liệt kê những sinh viên có điểm TB>8.0
◼ Sắp xếp danh sách theo Mã sinh viên*/

namespace BTVN_Bai1_QuanLySinhVien
{
    internal class DanhSach : SinhVien
    {
        private SinhVien[] DS { get; set; }
        private int n { get; set; }
        public DanhSach(int x)
        {
            n = x;
            DS = new SinhVien[n];
        }
        public void NhapDS()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================Nhap danh sach sinh vien===================");
            for (int i = 0; i < DS.Length; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                DS[i] = new SinhVien();
                DS[i].Nhap();
                Console.WriteLine("\n");
            }
        }
        public void XuatDS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================Xuat danh sach sinh vien===================");
            for (int i = 0; i < DS.Length; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu {0}", i + 1);
                DS[i].Xuat();
                Console.WriteLine("\n");
            }
        }
        public void TopDiemTB()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================Diem trung binh tren 8.0===================");
            for (int i = 0; i < DS.Length; i++)
            {
                if(DS[i].DiemTB > 8)
                {
                    Console.WriteLine("{0}: {1}", DS[i].HoTen, DS[i].DiemTB);
                    Console.WriteLine("\n");
                }
            }
        }

        public void SortByName()
        {
            Array.Sort(DS, delegate (SinhVien sv1, SinhVien sv2) { return sv1.MaSV.CompareTo(sv2.MaSV); });
        }
    }
}
