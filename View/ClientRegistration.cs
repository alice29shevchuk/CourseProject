using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ClientRegistration : Form
    {
        public ClientRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseClientRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseClientRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelCloseClientRegistration.ForeColor = Color.Red;
        }

        private void labelCloseClientRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelCloseClientRegistration.ForeColor = Color.LightSeaGreen;
        }
    }
}
