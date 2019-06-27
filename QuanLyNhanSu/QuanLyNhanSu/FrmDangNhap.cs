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
    public partial class FrmDangNhap : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show( cls.thu(textBox2.Text, "select pass from tbuser").ToString());
            if ((cls.kt(textBox1.Text, "select * from tbuser", 0) == true) && (cls.kt(textBox2.Text, "select * from tbuser", 1) == true))
            {

                //this.Hide();
                //Global.frmmain.k = 4;
                //Global.frmmain.Refresh();
                //Global.frmmain.truyen();

                //Global.frmmain.ShowDialog();
                //MessageBox.Show("Bạn đã đăng nhập thành công");

                this.Hide();
                Form1 fm = new Form1();
                fm.k = 4;
                fm.truyen();
                MessageBox.Show("Bạn đã đăng nhập thành công");
                fm.ShowDialog();

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
