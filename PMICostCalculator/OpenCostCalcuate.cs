using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    public partial class OpenCostCalcuate : Form
    {
        public OpenCostCalcuate()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this,false);
        }
    }
}
