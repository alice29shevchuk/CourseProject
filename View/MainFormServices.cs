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
    public partial class MainFormServices : Form
    {
        public MainFormServices()
        {
            InitializeComponent();
        }

        private void MainFormServices_Load(object sender, EventArgs e){}
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseMainFormServices_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseMainFormServices_MouseEnter(object sender, EventArgs e)
        {
            labelCloseMainFormServices.ForeColor = Color.Red;
        }

        private void labelCloseMainFormServices_MouseLeave(object sender, EventArgs e)
        {
            labelCloseMainFormServices.ForeColor = Color.LightSeaGreen;
        }
    }
}
