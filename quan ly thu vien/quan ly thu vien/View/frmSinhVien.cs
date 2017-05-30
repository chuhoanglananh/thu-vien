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
    public partial class frmSinhVien : Form
    {
        SinhVien_Control svctr = new SinhVien_Control();
        int flag = 0;
        SinhVien_Obh svOj = new SinhVien_Obh();//chuyen dl qua cac form

        public frmSinhVien()
        {
            InitializeComponent();
        }

        
         private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DataTable sinhvien = new DataTable();
            sinhvien = svctr.getData();
            dgvSinhVien.DataSource = sinhvien;
            bingding();
            dis_en(false);
        }          

        
        void bingding()
        {
            txtMaThe.DataBindings.Clear();
            txtMaThe.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaThe");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenSV");

            txtNgaysinh.DataBindings.Clear();
            txtNgaysinh.DataBindings.Add("Text", dgvSinhVien.DataSource,"Ngaysinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvSinhVien.DataSource, "DiaChi");

            txtLop.DataBindings.Clear();
            txtLop.DataBindings.Add("Text", dgvSinhVien.DataSource, "Lop");

            txtKhoa.DataBindings.Clear();
            txtKhoa.DataBindings.Add("Text", dgvSinhVien.DataSource,"Khoa");

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dgvSinhVien.DataSource,"NgayCapThe");

            dateTimePicker2.DataBindings.Clear();
            dateTimePicker2.DataBindings.Add("Text", dgvSinhVien.DataSource,"NgayHetHan");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text",dgvSinhVien.DataSource,"gioitinh");

        }

        void ganDL(SinhVien_Obh svObj)
        {
            svObj.Mathe = txtMaThe.Text.Trim();
            svObj.TenSV = txtTen.Text.Trim();
            svObj.Ngaysinh = txtNgaysinh.Text.Trim();
            svObj.DiaChi = txtDiaChi.Text.Trim();
            svObj.Lop = txtLop.Text.Trim();
            svObj.Khoa = txtKhoa.Text.Trim();
            svObj.NgayCapThe = dateTimePicker1.Text.Trim();
            svObj.NgayHetHan = dateTimePicker2.Text.Trim();
            svObj.Gioitinh = txtGioiTinh.Text.Trim();
        }

        void dis_en(bool e)
        {
            txtMaThe.Enabled = e;
            txtTen.Enabled = e;
            txtNgaysinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtLop.Enabled = e;
            txtKhoa.Enabled = e;
            dateTimePicker1.Enabled = e;
            dateTimePicker2.Enabled = e;
            txtGioiTinh.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnThoat.Enabled = e;
        }

        //load du lieu
        void loadcontrol()
        {
            dateTimePicker1.Text = DateTime.Now.Date.ToShortDateString();

            dateTimePicker1.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 0;
            dis_en(true);
            loadcontrol();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            dateTimePicker1.Text = DateTime.Now.Date.ToShortDateString();

            dateTimePicker1.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban chac chan muon xoa?","Xac nhan",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                //xoa
                if (svctr.delData(txtMaThe.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Khong Xoa duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDL(svOj);
           if(flag==0)
            {
                //them moi
                if (svctr.addData(svOj))
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Khong Them duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           else
            {
                //sua
                if (svctr.upDate(svOj))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Khong Sua duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmSinhVien_Load(sender, e);
            dis_en(false);
        }
    }
}
