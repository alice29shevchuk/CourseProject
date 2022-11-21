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
    public partial class ClientAutorization : Form
    {
        public ClientAutorization()
        {
            InitializeComponent();
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            ClientRegistration clientRegistration = new ClientRegistration();
            clientRegistration.ShowDialog();
        }

        private void buttonBackClientAutorization_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOKAutorization_Click(object sender, EventArgs e)
        {
            MainFormServices mainFormServices = new MainFormServices();
            mainFormServices.ShowDialog();
        }

        private void labelCloseClientAutorization_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseClientAutorization_MouseEnter(object sender, EventArgs e)
        {
            labelCloseClientAutorization.ForeColor = Color.Red;
        }

        private void labelCloseClientAutorization_MouseLeave(object sender, EventArgs e)
        {
            labelCloseClientAutorization.ForeColor = Color.LightSeaGreen;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
