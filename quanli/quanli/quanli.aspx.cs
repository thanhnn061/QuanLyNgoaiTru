using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanli
{
    public partial class quanli : System.Web.UI.Page
    {
        /* protected void Page_Load(object sender, EventArgs e)
         {

             LoadGridview();

         }
         public void LoadGridview()
         {
             SinhVienDAO sv = new SinhVienDAO();
             drkhoa.DataSource = sv.Getdata("SELECT MaKhoa,TenKhoa FROM Khoa");
             drkhoa.DataTextField = "TenKhoa";
             drkhoa.DataValueField = "MaKhoa";
             drkhoa.DataBind();
             GridView1.DataSource = sv.Getdata("SELECT  MaSV,HoTen,NgaySinh,GioiTinh,TenKhoa,Lop,TenChuTro,SDT,DiaChi,NgayDen,NgayDi,TenKhoa FROM SinhVien,Khoa");
             GridView1.DataBind();
         }
         public Sinhvien GetSinhvien()
         {
             string masv = txtmasv.Text;
             string hoten = txthoten.Text;
             string ngaysinh = txtngaysinh.Text;
             bool gioitinh = bool.Parse(DropDownList3.SelectedValue);
             string quequan = txtquequan.Text;
             string lop = txtlop.Text;
             string tenchutro = txttenchutro.Text;
             string sdt = txtsdt.Text;
             string diachi = txtdiachi.Text;
             string ngayden = txtngayden.Text;
             string ngaydi = txtngaydi.Text;
             string makhoa = drkhoa.SelectedValue.ToString();
             Sinhvien sv = new Sinhvien(masv, hoten, ngaysinh, gioitinh, quequan, tenchutro, sdt, diachi, ngayden, ngaydi, lop, makhoa);

             return sv;
         }
         protected void txtsave_Click(object sender, EventArgs e)
         {
             //string masv = txtmasv.Text;
             //string hoten = txthoten.Text;
             //string ngaysinh = txtngaysinh.Text;
             //bool gioitinh = bool.Parse(DropDownList3.SelectedValue);
             //string quequan = txtquequan.Text;
             //string lop = txtmalop.Text;
             //string tenchutro = txttenchutro.Text;
             //string sdt = txtsdt.Text;
             //string diachi = txtdiachi.Text;
             //string ngayden = txtngayden.Text;
             //string ngaydi = txtngaydi.Text;
             //Sinhvien sv = new Sinhvien(masv, hoten, ngaysinh, gioitinh, quequan, tenchutro, sdt, diachi, ngayden, ngaydi, lop);
             SinhVienDAO svdao = new SinhVienDAO();
             if (svdao.CheckUser(txtmasv.Text))
             {
                 lbthongbao.Text = "Tai Khoan Ton Tai";
             }
             else
             {
                 svdao.Insert(GetSinhvien());
                 lbthongbao.Text = "Luu Thanh Cong";
                 LoadGridview();
             }
         }

         protected void delete_Click(object sender, EventArgs e)
         {
             string username = txtmasv.Text;
             SinhVienDAO svdao = new SinhVienDAO();
             if (svdao.Delete(username))
             {
                 lbthongbao.Text = "Xóa Thành Công";
                 LoadGridview();
             }
             else
             {
                 lbthongbao.Text = "Có Lỗi Xảy Ra";
             }


         }

         protected void update_Click(object sender, EventArgs e)
         {
             SinhVienDAO svdao = new SinhVienDAO();
             if (svdao.Update(txtmasv.Text, GetSinhvien()))
             {
                 lbthongbao.Text = "Cập Nhật Thành Công";
                 LoadGridview();
             }
             else
             {
                 lbthongbao.Text = "Có Lỗi Xảy Ra";
             }

         }

         protected void find_Click(object sender, EventArgs e)
         {
             SinhVienDAO svdao = new SinhVienDAO();
             if (!svdao.CheckUser(txttim.Text))
             {
                 lbthongbao.Text = "Không tìm thấy";
             }
             else
             {
                 GridView1.DataSource = svdao.Getdata("SELECT  MaSV,HoTen,NgaySinh,GioiTinh,TenKhoa,Lop,TenChuTro,SDT,DiaChi,NgayDen,NgayDi,TenKhoa FROM SinhVien,Khoa WHERE MaSV='" + txttim.Text + "' ");
                 GridView1.DataBind();
             }
         }*/
        protected void btnLogout(object sender, EventArgs e)
        {
            Response.Redirect("login");

        }
    }
}