using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.CONTROL;
using QLTV.DOITUONG;


namespace QLTV
{
    public partial class Form1 : Form
    {
        LoaiSachCTRL k = new LoaiSachCTRL();

        LoaiSachDT dtKhoa = new LoaiSachDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dt = k.GetData();
            dgvLoaiSach.DataSource = dt;
            KL();
        }
       
        void KL()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvLoaiSach.DataSource, "maLS");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvLoaiSach.DataSource, "tenLS");

        }
        //ham lay dl tu control
        void ganDL(LoaiSachDT dt)
        {
           dt.MaLS  = txtMa.Text.Trim();
           dt.TenLS  = txtTen.Text.Trim();

        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {

            txtMa.Enabled = e;
            txtTen.Enabled = e;
            btnCapNhat.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            ANTT(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            ANTT(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (k.DeleteData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            Form1_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ANTT(false);
            ganDL(dtKhoa);
            if (flag == 0)
            {
                //them moi
                ganDL(dtKhoa);
                if (k.AddData(dtKhoa))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sua
                if (k.UpdateData(dtKhoa))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Form1_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            Form1_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
