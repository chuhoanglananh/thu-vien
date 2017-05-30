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
    public partial class frmChiTietPhieuMuon : Form
    {
        ChiTietPhieuMuon_Control chitietctr = new ChiTietPhieuMuon_Control();
        int flag = 0;
        ChiTietPhieuMuon_Ob ctOj = new ChiTietPhieuMuon_Ob();//chuyen dl qua cac form

        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            DataTable phieumuon = new DataTable();
            phieumuon = chitietctr.getData();
            dgvChiTiet.DataSource = phieumuon;
            bingding();
            dis_en(false);

        }
        void bingding()
        {
            txtSoPhieu.DataBindings.Clear();
            txtSoPhieu.DataBindings.Add("Text", dgvChiTiet.DataSource, "SoPhieuMuon");

            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvChiTiet.DataSource, "MaSach");

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dgvChiTiet.DataSource, "HenTra");
        }

        void dis_en(bool e )
        {
            txtSoPhieu.Enabled = e;
            txtMaSach.Enabled = e;
            dateTimePicker1.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        //ham lay du lieu vao control
        void ganDL(ChiTietPhieuMuon_Ob ctObj)
        {
            ctObj.SoPhieuMuon1 = txtSoPhieu.Text.Trim();
            ctObj.MaSach1 = txtMaSach.Text.Trim();
            ctObj.HenTra1 = dateTimePicker1.Text.Trim();
        }

        //load du lieu
        void loadcontrol()
        {
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
            //frmChiTietPhieuMuon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon xoa khong","Xac nhan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xoa
                if (chitietctr.delData(txtMaSach.Text.Trim()))
                    MessageBox.Show("Xoa du lieu thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    //sua
                    MessageBox.Show("Xoa them du lieu duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                frmChiTietPhieuMuon_Load(sender, e);
            return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDL(ctOj);
            if (flag == 0)
            {
                //them moi
                if (chitietctr.addData(ctOj))
                    MessageBox.Show("Them du lieu thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    //sua
                    MessageBox.Show("Khong them du lieu duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (chitietctr.upDate(ctOj))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    //sua
                    MessageBox.Show("Khong sua duoc du lieu", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmChiTietPhieuMuon_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuMuon_Load(sender, e);
            dis_en(false);

        }
    }
}
