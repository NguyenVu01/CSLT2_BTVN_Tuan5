using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1_QuanLySinhVien
{
    internal class SinhVien
    {
        private string _HoTen, _MaSV;
        private DateTime _NgaySinh;
        private double _LapTrinh, _CoSoDuLieu, _ThietKeWeb, _DiemTB;
        public SinhVien()
        {
            _HoTen = "";
            _MaSV = "";
            _NgaySinh = DateTime.Now;
            _LapTrinh = 0;
            _CoSoDuLieu = 0;
            _ThietKeWeb = 0;
            _DiemTB = 0;
        }
        public SinhVien(string ht,string msv,DateTime ns,double lt,double csdl,double tkw)
        {
            this._HoTen = ht;
            this._MaSV = msv;
            this._NgaySinh = ns;
            this._LapTrinh = lt;
            this._CoSoDuLieu = csdl;
            this._ThietKeWeb = tkw;
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }
        public double LapTrinh
        {
            get { return _LapTrinh; }
            set
            {
                _LapTrinh = value;
                _DiemTB = (_LapTrinh + _CoSoDuLieu + _ThietKeWeb) / 3;
            }
        }
        public double CoSoDuLieu
        {
            get { return _CoSoDuLieu; }
            set
            {
                _CoSoDuLieu = value;
                _DiemTB = (_LapTrinh + _CoSoDuLieu + _ThietKeWeb) / 3;
            }
        }
        public double ThietKeWeb
        {
            get { return _ThietKeWeb; }
            set
            {
                _ThietKeWeb = value;
                _DiemTB = (_LapTrinh + _CoSoDuLieu + _ThietKeWeb) / 3;
            }
        }
        //Thuoc tinh DiemTrungBinh- (read only)
        public double DiemTB
        {
            get { return _DiemTB; }
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Bat dau nhap thong tin sinh vien:");
            Console.Write("Nhap ten cua sinh vien: ");
            HoTen = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap diem mon Lap Trinh:");
            LapTrinh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem mon Co So Du Lieu:");
            CoSoDuLieu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Thiet ke Web:");
            ThietKeWeb = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ho va ten sinh vien: {0}", HoTen);
            Console.WriteLine("Ma sinh vien: {0}", MaSV);
            Console.WriteLine("Diem mon Lap Trinh: {0}", LapTrinh);
            Console.WriteLine("Diem mon Co So Du Lieu: {0}", CoSoDuLieu);
            Console.WriteLine("Diem mon Thiet Ke Web: {0}", ThietKeWeb);
            Console.WriteLine("Diem mon trung binh: {0}", DiemTB);
        }
    }
}
