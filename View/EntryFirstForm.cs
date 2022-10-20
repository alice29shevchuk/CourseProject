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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            ClientAutorization clientAutorization = new ClientAutorization();
            clientAutorization.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminKeyEntry adminKeyEntry = new AdminKeyEntry();
            adminKeyEntry.ShowDialog();
        }

        private void labelCloseEntryFirstForm_MouseEnter(object sender, EventArgs e)
        {
            labelCloseEntryFirstForm.ForeColor = Color.Red;
        }

        private void labelCloseEntryFirstForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseEntryFirstForm_MouseLeave(object sender, EventArgs e)
        {
            labelCloseEntryFirstForm.ForeColor = Color.LightSeaGreen;
        }
        Point point;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    this.Left += e.X - point.X;
            //    this.Top += e.Y - point.Y;
            //}
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //point = new Point(e.X, e.Y);
        }
    }
}
