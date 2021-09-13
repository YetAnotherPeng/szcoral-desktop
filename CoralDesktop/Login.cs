using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoralDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelLoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            if(user != "" & pass != ""){
                Auth auth = new Auth();
                if (auth.Verify(user, pass))
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
            }
            else
            {
                MessageBox.Show("请输入用户名或密码");
            }            
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //textBoxPassword.Text += "*";
        }
    }
}
