using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculator
{
    /// <summary>
    /// 这个静态类主要用于常用的Form操作
    /// </summary>
    public class FormCommonOperate
    {
        /// <summary>
        /// 清空所选容器里所有textbox
        /// </summary>
        /// <param name="form"></param>
        public static void ClearAllTextBoxInForm(Control container)
        {
            foreach (var item in container.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }
        /// <summary>
        /// 转换string到double，如果不行，就抛出异常
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="number"></param>
        public static void ConvertStringToDouble(TextBox txt, out double number)
        {
            if (!double.TryParse(txt.Text, out number))
            {
                throw new Exception("所有输入必须是数字");
            }
        }


    }
}
