using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoralDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoralData cd = new CoralData();
            labelCO2DereaseValue.Text = cd.GetCoralCO2Digest().ToString();
            labelWanlitongValue.Text = cd.GetWanlitongValue().ToString() + "g";
            pictureBoxCoral.Image = Properties.Resources.coral_reef_4;
        }

        private void buttonCoralAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("需要下载另一个工具来展示AR");
        }

        private void buttonCoralBaike_Click(object sender, EventArgs e)
        {
            CoralBaike cb = new CoralBaike();
            cb.Show();
        }

        private void buttonCoralVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未接入VR");
        }
    }
}
