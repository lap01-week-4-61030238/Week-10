﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void BtnFontDialog_Click(object sender, EventArgs e)
        {   
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = textBox1.Text;
                propertyGrid1.Refresh();
            }

        }

    }
}
