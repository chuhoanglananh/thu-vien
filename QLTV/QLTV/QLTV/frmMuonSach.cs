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
    public partial class frmMuonSach : Form
    {
        MuonSachCON k = new MuonSachCON();
        MuonSachDT dtKhoa = new MuonSachDT();//lay dl chuyen qua các form vd click vào nút thêm các dl dc chuyền vào dtGV ->capnhat
        int flag = 0;//khai báo 1 flag de biet dang them hay sua
        DataTable dt = new DataTable();
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            dt = k.GetData();
            dgvMuonSach.DataSource = dt;
            KL();
        }

        void KL()
        {
            txtSoPhieuMuon.DataBindings.Clear();
            txtSoPhieuMuon.DataBindings.Add("Text", dgvMuonSach.DataSource, "SoPhieuMuon");

            txtMaThe.DataBindings.Clear();
            txtMaThe.DataBindings.Add("Text", dgvMuonSach.DataSource, "MaThe");

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvMuonSach.DataSource, "MaNV");

            dateTra.DataBindings.Clear();
            dateTra.DataBindings.Add("Text", dgvMuonSach.DataSource, "NgayMuon");
        }

        void ganDL(MuonSachDT dt)
        {
            dt.Sophieumuon = txtSoPhieuMuon.Text.Trim();
            dt.Mathe = txtMaThe.Text.Trim();
            dt.Manv = txtMaNV.Text.Trim();
            dt.Ngaymuon = dateTra.Text.Trim();

        }

        void ANTT(bool e)
        {

            txtSoPhieuMuon.Enabled = e;
            txtMaThe.Enabled = e;
            txtMaNV.Enabled = e;
            dateTra.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnThoat.Enabled = !e;

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
                if (k.DeleteData(txtSoPhieuMuon.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmMuonSach_Load(sender, e);
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

            frmMuonSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmMuonSach_Load(sender, e);
            ANTT(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

        
