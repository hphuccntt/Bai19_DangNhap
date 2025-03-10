using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai19_DangNhap
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string u = "admin";
            string p = "123";
            if (txtTen.Text == u && txtMatkhau.Text == p)
            {
                Mainchinh mainchinh = new Mainchinh();
                this.Hide();
                mainchinh.ShowDialog();
                this.Close();
            }
            else
            {
                if (txtTen.TextLength == 0)
                {
                    errorProvider1.SetError(txtTen, " Không Được Để Trống ");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if(txtMatkhau.TextLength == 0)
                {
                    errorProvider2.SetError(txtMatkhau, " Không Được Để Trống ");
                }
                else
                {
                    errorProvider2.Clear();
                }



                lblInfor.Text = " Sai Tên Đăng Nhập Hoặc Mật Khẩu ";
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfor.Text = " "; 
        }
    }
}
