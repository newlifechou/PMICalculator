using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TargetDensityCalculator
{
    /// <summary>
    /// 这个静态类主要用于常用的Form操作
    /// </summary>
    public class FormOperate
    {
        public static void ClearAllTextBoxInForm(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }
    }
}
