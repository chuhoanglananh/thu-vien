using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DOITUONG;
using QLTV.CONTROL;

namespace QLTV
{
    public partial class frmChiTiet : Form
    {
        ChiTietCON k = new ChiTietCON();
        ChiTietDT dtKhoa = new ChiTietDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        
        public frmChiTiet()
        {
            InitializeComponent();
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            dt = k.GetData();
            dgvChiTiet.DataSource = dt;
            KL();
        }

        void KL()
        {
            txtSoPhieu.DataBindings.Clear();
            txtSoPhieu.DataBindings.Add("Text", dgvChiTiet.DataSource, "SoPhieuMuon");

            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvChiTiet.DataSource, "MaSach");

            dateTra.DataBindings.Clear();
            dateTra.DataBindings.Add("Text", dgvChiTiet.DataSource, "HenTra");
        }

        void ganDL(ChiTietDT dt)
        {
            dt.Sophieu = txtSoPhieu.Text.Trim();
            dt.Masach = txtMaSach.Text.Trim();
            dt.Hentra = dateTra.Text.Trim();
        }

        void ANTT(bool e)
        {

            txtSoPhieu.Enabled = e;
            txtMaSach.Enabled = e;
            dateTra.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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
                if (k.DeleteData(txtSoPhieu.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmChiTiet_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmChiTiet_Load(sender, e);
            ANTT(false);
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

            frmChiTiet_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
