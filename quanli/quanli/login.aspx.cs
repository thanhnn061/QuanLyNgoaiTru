using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace quanli
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtLogin_Click(object sender, EventArgs e)
        {
           
            SinhVienDAO svdao = new SinhVienDAO();
            if(txtUser.Text=="" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nạp đủ thông tin!");
            }
            else { 
                if (svdao.CheckLogin(txtUser.Text, txtPass.Text))
                {
                    Response.Redirect("quanli");

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                }
            }
        }

    }
}