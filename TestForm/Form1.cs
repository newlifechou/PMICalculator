using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMICalculator;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorArchimedesDensity adc = new CalculatorArchimedesDensity();
            adc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorRectangleTargetDensity rtdc = new CalculatorRectangleTargetDensity();
            rtdc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorCircleTargetDensity ctdc = new CalculatorCircleTargetDensity();
            ctdc.ShowDialog();
        }
    }
}
