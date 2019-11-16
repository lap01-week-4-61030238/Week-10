using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtboxFileName.Text = openFileDialog1.FileName;
                DirectoryInfo di = new DirectoryInfo(openFileDialog1.FileName);
                propertyGrid2.Selectedobject = di;
                propertyGrid1.Refresh();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PropertyGrid2_Click(object sender, EventArgs e)
        {

        }

        private void PropertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
