﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void AddControls(Form frm)
        {
            CenterPanel.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new categoryForm());
        }
    }
}
