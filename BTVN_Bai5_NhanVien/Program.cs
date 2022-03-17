using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai5_NhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien NV1 = new NhanVien();
            NV1.Nhap();
            NV1.Xuat();
            Console.ReadLine();
        }
    }
}