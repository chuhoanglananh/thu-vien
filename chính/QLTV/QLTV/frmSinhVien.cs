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
        public partial class frmSinhVien : Form
        {
            SinhVienCON k = new SinhVienCON();
            SinhVienDT dtKhoa = new SinhVienDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
            int flag = 0;//khai báo 1 flag de biet dang them hay sua
            DataTable dt = new DataTable();
            public frmSinhVien()
            {
                InitializeComponent();
            }

            

            private void frmSinhVien_Load(object sender, EventArgs e)
            {
            dt = k.GetData();
            dgvSinhVien.DataSource = dt;
            KL();
            }

        void KL()
        {
            txtMaThe.DataBindings.Clear();
            txtMaThe.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaThe");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenSV");

            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", dgvSinhVien.DataSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvSinhVien.DataSource, "DiaChi");

            txtLop.DataBindings.Clear();
            txtLop.DataBindings.Add("Text", dgvSinhVien.DataSource, "Lop");

            txtKhoa.DataBindings.Clear();
            txtKhoa.DataBindings.Add("Text", dgvSinhVien.DataSource, "Khoa");

            dateNgayCap.DataBindings.Clear();
            dateNgayCap.DataBindings.Add("Text", dgvSinhVien.DataSource, "NgayCapThe");

            dateNgayHetHan.DataBindings.Clear();
            dateNgayHetHan.DataBindings.Add("Text", dgvSinhVien.DataSource, "NgayHetHan");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvSinhVien.DataSource, "gioitinh");

        }

        void ANTT(bool e)
        {

            txtMaThe.Enabled = e;
            txtTen.Enabled = e;
            dateNgaySinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtLop.Enabled = e;
            txtKhoa.Enabled = e;
            dateNgayCap.Enabled = e;
            dateNgayHetHan.Enabled = e;

            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }
        void ganDL(SinhVienDT dt)
        {
            dt.Mathe = txtMaThe.Text.Trim();
            dt.Tensv = txtTen.Text.Trim();
            dt.Ngaysinh = dateNgaySinh.Text.Trim();
            dt.Diachi = txtDiaChi.Text.Trim();
            dt.Lop = txtLop.Text.Trim();
            dt.Khoa = txtKhoa.Text.Trim();
            dt.Ngaycapthe = dateNgayCap.Text.Trim();
            dt.Ngayhethan = dateNgayHetHan.Text.Trim();
            dt.Gioitinh = txtGioiTinh.Text.Trim();
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
                if (k.DeleteData(txtMaThe.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmSinhVien_Load(sender, e);
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
            frmSinhVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmSinhVien_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

