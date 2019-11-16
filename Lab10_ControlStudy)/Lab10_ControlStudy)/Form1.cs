using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_ControlStudy_
{
    public partial class Form1 : Form
    {
        Button btnHello;
        public Form1()
        {
            InitializeComponent();
            btnHello = new Button();
            btnHello.Location = new Point(20, 20);
            btnHello.Text = "Hello";
            this.Controls.Add(btnHello);
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {

        }
    }
}
