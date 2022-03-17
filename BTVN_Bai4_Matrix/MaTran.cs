using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Hàm tạo MaTran(int m, int n) để khởi tạo ma trận m dòng, n cột
 Nhập ma trận
 In ma trận ra màn hình
 Cộng 2 ma trận
 Tính hiệu 2 ma trận
 Tính tích 2 ma trận
 Tìm ma trận chuyển vị
 Kiểm tra ma trận có phải ma trận vuông hay không?
*/

namespace BTVN_Bai4_Matrix
{
    internal class MaTran
    {
        private int m; //Số dòng
        private int n; //Số cột
        private int[,] a; //Mảng 2 chiều
        
        public MaTran(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m,n];
        }
        public void Nhap()
        {
            Console.WriteLine("\n=============Bat dau nhap ma tran===========");
            for(int i = 0; i < m; i++)
            {
                Console.WriteLine(""); 
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine("Nhap phan tu [{0}][{1}]", i,j);
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("\n============= Ma tran hoan tat ===========");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0} ", a[i,j]);
                }
            }
        }
        static public MaTran Cong(MaTran mt1, MaTran mt2)
        {
                int x = mt1.m;
                int y = mt1.n;
                MaTran mt = new MaTran(x, y);
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        mt.a[i, j] = mt1.a[i, j] + mt2.a[i, j];
                    }
                }
                mt.Xuat();
                return mt;
        }
        static public MaTran Tru(MaTran mt1, MaTran mt2)
        {
            int x = mt1.m;
            int y = mt1.n;
            MaTran mt = new MaTran(x, y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mt.a[i, j] = mt1.a[i, j] - mt2.a[i, j];
                }
            }
            mt.Xuat();
            return mt;
        }
        static public MaTran Nhan(MaTran mt1, MaTran mt2)
        {
            int x = mt1.m;
            int y = mt1.n;
            MaTran mt = new MaTran(x, y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mt.a[i, j] = mt1.a[i, j] * mt2.a[i, j];
                }
            }
            mt.Xuat();
            return mt;
        }
        public void Kiemtra()
        {
            if(this.m == this.n)
            {
                Console.WriteLine("\nMa tran vuong");
            }
            else Console.WriteLine("\nMa tran khong vuong");
        }
        static public MaTran ChuyenVi(MaTran mt)
        {
            int x = mt.m;
            int y = mt.n;
            MaTran mt0 = new MaTran(y, x);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    mt0.a[i, j] = mt.a[j, i];
                }
            }
            mt0.Xuat();
            return mt0;
        }
    }   
}
