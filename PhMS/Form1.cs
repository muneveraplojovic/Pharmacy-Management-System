﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="maja" &&  txtPassword.Text == "maja")
            {
                Adminstrator admin = new Adminstrator();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
