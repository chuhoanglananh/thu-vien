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
using QLTV.MOHINH;
using QLTV.DOITUONG;


namespace QLTV
{
    public partial class frmSach : Form
    {
        SachCON k = new SachCON();
        SachDT dtKhoa = new SachDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dt = k.GetData();
            dgvSach.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvSach.DataSource, "MaSach");

            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dgvSach.DataSource, "TenSach");

            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", dgvSach.DataSource, "TacGia");

            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", dgvSach.DataSource, "MaNXB");

            txtMaLS.DataBindings.Clear();
            txtMaLS.DataBindings.Add("Text", dgvSach.DataSource, "MaLS");

            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", dgvSach.DataSource, "NamXB");

            txtLanXB.DataBindings.Clear();
            txtLanXB.DataBindings.Add("Text", dgvSach.DataSource, "LanXB");

            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("Text", dgvSach.DataSource, "SoLuong");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", dgvSach.DataSource, "NoiDung");
        }

        void ganDL(SachDT dt)
        {
            dt.Masach = txtMaSach.Text.Trim();
            dt.Tensach = txtTenSach.Text.Trim();
            dt.Tacgia = txtTacGia.Text.Trim();
            dt.Manxb = txtMaNXB.Text.Trim();
            dt.MaLS = txtMaLS.Text.Trim();
            dt.Namxb = txtNamXB.Text.Trim();
            dt.Lanxb = txtLanXB.Text.Trim();
            dt.Soluong = txtSoluong.Text.Trim();
            dt.Noidung = txtNoiDung.Text.Trim();
        }

        void ANTT(bool e)
        {

            txtMaSach.Enabled = e;
            txtTenSach.Enabled = e;
            txtTacGia.Enabled = e;
            txtMaNXB.Enabled = e;
            txtMaLS.Enabled = e;
            txtNamXB.Enabled = e;
            txtLanXB.Enabled = e;
            txtSoluong.Enabled = e;
            txtNoiDung.Enabled = e;

            btnLuu.Enabled = e;
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
                if (k.DeleteData(txtMaSach.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmSach_Load(sender, e);
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

            frmSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmSach_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
