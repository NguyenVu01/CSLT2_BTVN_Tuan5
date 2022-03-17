using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Bài 5.Xây dựng lớp NhanVien
◼ Các thành phần dữ liệu
 Họ tên, Năm sinh, Địa chỉ, Lương cơ bản, Hệ số, Phụ
cấp, Tổng tiền
◼ Các phương thức
 Hàm tạo không tham số
 Nhập nhân viên
 Tính lương: Tổng tiền = Lương cơ bản x Hệ số + Phụ
cấp
 In nhân viên ra màn hình*/
namespace BTVN_Bai5_NhanVien
{
    internal class NhanVien
    {
        private string HoTen;
        private int NamSinh;
        private string DiaChi;
        private double LuongCB, HeSo, PhuCap, _TongTien;
        public NhanVien()
        {
            HoTen = null;
            NamSinh = 0;
            DiaChi = null;
            LuongCB = 0;
            HeSo = 0;
            PhuCap = 0;
        }
        public NhanVien(string ht,int ns,string dc,double lcb,double hs,double pc)
        {
            this.HoTen = ht;
            this.NamSinh = ns;
            this.DiaChi = dc;
            this.LuongCB = lcb;
            this.HeSo = hs;
            this.PhuCap = pc;
        }
        public double TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        public void Nhap()
        {
            Console.WriteLine("Bat dau nhap nhan vien:");
            Console.WriteLine("Nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh:");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap luong co ban:");
            LuongCB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap he so:");
            HeSo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap phu cap:");
            PhuCap = Convert.ToDouble(Console.ReadLine());
            //Thu try and catch
        }

        public double Tinhluong()
        {
            this.TongTien = this.LuongCB * this.HeSo + this.PhuCap;
            return TongTien;
        }
        public void Xuat()
        {
            Console.WriteLine("Thong tin nhan vien:");
            Console.WriteLine("Ho ten nhan vien: {0}", this.HoTen);
            Console.WriteLine("Nam sinh nhan vien: {0}", this.NamSinh);
            Console.WriteLine("Luong co ban nhan vien: {0}", this.LuongCB);
            Console.WriteLine("Nhap he so: {0}", this.HeSo);
            Console.WriteLine("Nhap phu cap: {0}", this.PhuCap);
            Console.WriteLine("Tong tien luong cua nhan vien: {0}", this.Tinhluong());
        }

    }
}
