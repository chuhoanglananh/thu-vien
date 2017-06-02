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
    public partial class frmNhanVien : Form
    {
        NhanVienCON k = new NhanVienCON();
        NhanVienDT dtKhoa = new NhanVienDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            dt = k.GetData();
            dgvNhanVien.DataSource = dt;
            KL();
        }


        void KL()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChi");

            dateNgay.DataBindings.Clear();
            dateNgay.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinh");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvNhanVien.DataSource, "DienThoai");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvNhanVien.DataSource, "MatKhau");


        }
        void ganDL(NhanVienDT dt)
        {
            dt.Manv = txtMaNV.Text.Trim();
            dt.Tennv = txtTenNV.Text.Trim();
            dt.Diachi = txtDiaChi.Text.Trim();
            dt.Ngaysinh = dateNgay.Text.Trim();
            dt.Gioitinh = txtGioiTinh.Text.Trim();
            dt.Diachi = txtDienThoai.Text.Trim();
            dt.Matkhau = txtMatKhau.Text.Trim();
        }
        void ANTT(bool e)
        {

            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtDiaChi.Enabled = e;
            dateNgay.Enabled = e;
            txtGioiTinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMatKhau.Enabled = e;

            Hủy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }
        private void btbThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            ANTT(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            ANTT(true);
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (k.DeleteData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmNhanVien_Load(sender, e);
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

            frmNhanVien_Load(sender, e);
        }

        private void Hủy_Click(object sender, EventArgs e)
        {

            ANTT(false);
            frmNhanVien_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
