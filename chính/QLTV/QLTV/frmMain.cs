using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien sv = new frmSinhVien();
            sv.ShowDialog();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB nxb = new frmNXB();
            nxb.ShowDialog();
        }

        private void sáchCóTrongThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach sach = new frmSach();
            sach.ShowDialog();
        
        }

        private void sốPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach nv = new frmSach();
            nv.ShowDialog();
        }

        private void nhânViênThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv1 = new frmNhanVien();
            nv1.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
