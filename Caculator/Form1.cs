﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a - b;
                txtKetQua.Text = c.ToString();
            
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (txtA.Text!=String.Empty) {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKetQua.Text = c.ToString();
             }
        }
    }
}
