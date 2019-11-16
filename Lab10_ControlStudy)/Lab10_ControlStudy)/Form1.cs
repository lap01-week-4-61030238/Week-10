using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab10_ControlStudy_
{
    public partial class Form1 : Form
    {
        Button btnHello;
        Color btnBackColor;
        public Form1()
        {
            InitializeComponent();
            btnHello = new Button();
            btnHello.Location = new Point(20, 20);
            btnHello.Text = "Hello";
            this.Controls.Add(btnHello);
            btnHello.Click += btnHello_Click;
            btnBackColor = btnHello.BackColor;
            btnHello.MouseEnter += BtnHello_MouseEnter;
            btnHello.MouseLeave += BtnHello_MouseLeave;

        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
        private void BtnHello_MouseLeave(object sender, EventArgs e)
        {
            btnHello.BackColor = btnBackColor;
        }
        private void BtnHello_MouseEnter(object sender, EventArgs e)
        {
            btnHello.BackColor = Color.Green;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");

        }
    }
}
