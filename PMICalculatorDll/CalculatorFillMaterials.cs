using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculatorDll
{
    public partial class CalculatorFillMaterials : Form
    {
        public CalculatorFillMaterials()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }
    }
}
