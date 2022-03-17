using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1_QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SinhVien sv1 = new SinhVien();
            sv1.Nhap();
            sv1.Xuat();*/

            DanhSach ds = new DanhSach(4);
            ds.NhapDS();
            ds.XuatDS();
            ds.TopDiemTB();
            ds.SortByName();
            ds.XuatDS();
            Console.ReadLine();
        }
    }
}