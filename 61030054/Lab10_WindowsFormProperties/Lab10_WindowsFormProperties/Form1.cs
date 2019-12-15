using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_WindowsFormProperties
{
    public partial class Form1 : Form
    {
        Button btnHello;
        Color btnBackColr;
        private Color btnBackColor;

        public Form1()
        {
            InitializeComponent();
            btnHello = new Button();
            btnHello.Location = new Point(20, 20);
            btnHello.Text = "Hello";
            this.Controls.Add(btnHello);
            btnHello.Click += BtnHello_Click;
            btnBackColor = btnHello.BackColor;
            btnHello.MouseEnter += BtnHello_MouseEnter;
            btnHello.MouseLeave += BtnHello_MouseLeave;
        }

        private void BtnHello_MouseLeave(object sender, EventArgs e)
        {
            btnHello.BackColor = btnHello.BackColor;

        }

        private void BtnHello_MouseEnter(object sender, EventArgs e)
        {
            btnHello.BackColor  = Color.Green;

        }


        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");

        }
    }
}

    
 
