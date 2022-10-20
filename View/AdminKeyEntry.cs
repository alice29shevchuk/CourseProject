﻿using System;
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
    public partial class AdminKeyEntry : Form
    {
        public AdminKeyEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseAdminKeyEntry_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseAdminKeyEntry_MouseEnter(object sender, EventArgs e)
        {
            labelCloseAdminKeyEntry.ForeColor = Color.Red;
        }

        private void labelCloseAdminKeyEntry_MouseLeave(object sender, EventArgs e)
        {
            labelCloseAdminKeyEntry.ForeColor = Color.LightSeaGreen;
        }
    }
}
