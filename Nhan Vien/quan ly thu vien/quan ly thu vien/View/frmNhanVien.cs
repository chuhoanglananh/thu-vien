using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_thu_vien.Control;
using quan_ly_thu_vien.Objects;


namespace quan_ly_thu_vien.View
{
    public partial class frmNhanVien : Form
    {
        NhanVien_Control nv = new NhanVien_Control();
        NhanVien_Object dtnv = new NhanVien_Object();
        DataTable dt = new DataTable();

        public frmNhanVien()
        {
            InitializeComponent();
        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dt = nv.getData();
            dgvNhanVien.DataSource = dt;
            KetNoi();
            an(false);
        }

        void KetNoi()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
        

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChi");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinh");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvNhanVien.DataSource, "DienThoai");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvNhanVien.DataSource, "MatKhau");
        }

        //lay du lieu tu controller
        void ganDL(NhanVien_Object dtNV)
        {
            dtNV.MaNV = txtMaNV.Text.Trim();
            dtNV.TenNV = txtTenNV.Text.Trim();
            dtNV.Diachi = txtDiaChi.Text.Trim();
            dtNV.Ngaysinh = txtNgaySinh.Text.Trim();
            dtNV.Gioitinh = txtGioiTinh.Text.Trim();
            dtNV.Dienthoai = txtDienThoai.Text.Trim();
            dtNV.Matkhau = txtMatKhau.Text.Trim(); 

        }

        void an (bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtDiaChi.Enabled = e;
            txtNgaySinh.Enabled = e;
            txtGioiTinh.Enabled = e;
            txtDienThoai.Enabled = e;
            txtMatKhau.Enabled = e;

            btnLuu.Enabled = e;
            btnThoat.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        int chon;
        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 0;
            an(true);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chon = 1;
            an(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Ban co muon xoa khong", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //xoa
                if (nv.DeleteData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
                return;
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            an(false);
            ganDL(dtnv);
            if(chon==0)
            {
                if(nv.AddData(dtnv))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if(nv.UpdateData(dtnv))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            frmNhanVien_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
