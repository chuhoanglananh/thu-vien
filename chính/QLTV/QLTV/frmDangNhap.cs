using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QLTV
{
    public partial class frmDangNhap : Form
    {

        string con = @"Data Source=DESKTOP-NER56SG\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain main;
                conn = new SqlConnection(con);
                conn.Open();
                string sql = "select count(*) from [quanlythuvien].[dbo].[taikhoan] where TenTk=@ac and MatKhau=@pass ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ac", txtTaiKhoan.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    //dangnhap dung
                    this.Hide();
                    main = new frmMain();
                    main.Show();
                }
                else
                {
                    //dang nhap thất bai
                    MessageBox.Show("Đăng nhập không thành công");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();//dau nhay chuot vao tai khoan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
