using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTwoNumbers
{
    public partial class SumTwoNumbers : Form
    {
        public SumTwoNumbers()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double number1 = Double.Parse(firstNumberTextBox.Text);
            double number2 = Double.Parse(secondNumberTextBox.Text);

            double sum = number1 + number2;

            sumLabel.Text = "Sum : " + sum;
        }
    }
}
