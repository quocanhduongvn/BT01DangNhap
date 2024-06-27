using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT001
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao; ;
            thongbao = (MessageBox.Show("Bạn Có Muốn Thoát ?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.tbTenDangNhap.Text == "tamga")
                if (this.tbMatKhau.Text == "123")
                {
                    MessageBox.Show("Bạn Đăng nhập Thành Công!");
                }

                else
                {
                    MessageBox.Show("Bạn Vui Lòng nhập lại mật khẩu");
                    this.tbMatKhau.Focus();
                }
            else
            {
                MessageBox.Show("Bạn Vui Lòng nhập lại Tên Dăng Nhập");
                this.tbTenDangNhap.Focus();

            }
                    
                
        }
    }
}
