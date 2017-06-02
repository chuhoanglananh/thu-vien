using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.MOHINH;
using QLTV.CONTROL;
using QLTV.DOITUONG;

namespace QLTV
{
    public partial class frmNXB : Form
    {
        NXBCON k = new NXBCON();
        NVBDT  dtKhoa = new NVBDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            dt = k.GetData();
            dgvNXB.DataSource = dt;
            KL();
        }

        void KL()
        {
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", dgvNXB.DataSource, "MaNXB");

            txtTenNXB.DataBindings.Clear();
            txtTenNXB.DataBindings.Add("Text", dgvNXB.DataSource, "TenNXB");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNXB.DataSource, "DiaChiNXB");

            txtWeb.DataBindings.Clear();
            txtWeb.DataBindings.Add("Text", dgvNXB.DataSource, "Website");

        }

        void ANTT(bool e)
        {

            txtMaNXB.Enabled = e;
            txtTenNXB.Enabled = e;
            txtDiaChi.Enabled = e;
            txtWeb.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }

        void ganDL(NVBDT dt)
        {
            dt.Manxb = txtMaNXB.Text.Trim();
            dt.Tennxb = txtTenNXB.Text.Trim();
            dt.Diachi = txtDiaChi.Text.Trim();
            dt.Web = txtWeb.Text.Trim();
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
                if (k.DeleteData(txtMaNXB.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmNXB_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

            frmNXB_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmNXB_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
