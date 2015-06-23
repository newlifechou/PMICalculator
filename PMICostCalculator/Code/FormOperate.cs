using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    /// <summary>
    /// 窗体操作类
    /// </summary>
    public static class FormOperate
    {
        /// <summary>
        /// 设置窗体为居中显示的对话框
        /// </summary>
        /// <param name="form"></param>
        public static void SetFormToDialog(Form form,bool showInTaskBar)
        {
            if (form != null)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowInTaskbar = showInTaskBar;
            }
        }
    }
}
