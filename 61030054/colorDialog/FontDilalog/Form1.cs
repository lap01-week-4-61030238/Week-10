using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDilalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.Font = fontDialog1.Font;
                propertyGrid1.Refresh();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
