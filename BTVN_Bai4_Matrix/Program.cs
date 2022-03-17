using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai4_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MaTran matrix = new MaTran(4,4);
            matrix.Nhap();
            matrix.Xuat();
            matrix.Kiemtra();
            MaTran matrix1 = new MaTran(4, 4);
            matrix1.Nhap();
            matrix1.Xuat();

            MaTran matrix2 = new MaTran(3, 4);
            matrix2.Nhap();
            matrix2.Kiemtra();
            //Cong 2 ma tran
            MaTran.Cong(matrix1, matrix);
            Console.ReadLine();
            //Matran chuyen vi 
            MaTran matrix0 = new MaTran(2, 3);
            matrix0.Nhap();
            matrix0.Xuat();
            MaTran.ChuyenVi(matrix0);
        }
    }
}