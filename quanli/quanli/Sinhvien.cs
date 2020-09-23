using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanli
{
    public class Sinhvien
    {
        private string masv;
        private string hoten;
        private string ngaysinh;
        private bool gioitinh;
        private string quequan;
        private string tenchutro;
        private string sdt;
        private string diachitro;
        private string ngayden;
        private string ngaydi;
        private string lop;
        private string matkhau;
        private bool chucvu;

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public bool GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
      
        
        public string TenChuTro
        {
            get { return tenchutro; }
            set { tenchutro = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string DiaChiTro
        {
            get { return diachitro; }
            set { diachitro = value; }
        }
        public string NgayDen
        {
            get { return ngayden; }
            set { ngayden = value; }

        }
        public string NgayDi
        {
            get { return ngaydi; }
            set{ ngaydi = value; }
        }
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public bool ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public Sinhvien(string masv,string hoten, string ngaysinh,bool gioitinh,string quequan,string tenchutro,string sdt,string diachi,string ngayden,string ngaydi,string lop, string matkhau,bool chucvu)
        {
            
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.tenchutro = tenchutro;
            this.sdt = sdt;
            this.diachitro = diachitro;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.lop = lop;
            this.matkhau = matkhau;
            this.chucvu = chucvu;
        }

          


    }
}