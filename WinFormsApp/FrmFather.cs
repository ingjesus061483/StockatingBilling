﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmFather : Form
    {
        public UserControl UserControl;
        public FrmFather()
        {
            InitializeComponent();
        }

        private void FrmFather_Load(object sender, EventArgs e)
        {
            UserControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(this.UserControl);
            this.Size=UserControl .Size;
        }

        private void FrmFather_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserControl is LoginUser)
            {
                e.Cancel = false;

            }
            else
            {
    
            }
        }
    }
}
