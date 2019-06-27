using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int k = 1;
        public void truyen()
        {

            if (k == 4)
            {
                
            }
        }

        private void tTCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTNhanNV frmNV = new TTNhanNV();
            frmNV.Show();
            
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy fmDk = new FrmDangKy();
            fmDk.Show();
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmTk = new FrmTimKiem();
            frmTk.Show();
        }

        private void nhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanSu frmNS = new FrmNhanSu();
            frmNS.Show();

        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan frmPB = new FrmPhongBan();
            frmPB.Show();

        }

        private void boPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBoPhan frmBP = new FrmBoPhan();
            frmBP.Show();
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
