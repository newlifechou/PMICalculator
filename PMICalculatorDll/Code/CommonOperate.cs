using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculatorDll
{
    /// <summary>
    /// 这个静态类主要用于通用的Form操作
    /// </summary>
    public class CommonOperate
    {

        public static void IsNullOrEmptyString(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                throw new Exception("所有输入不能为空");
            }
        }
        /// <summary>
        /// 转换string到double，如果不行，就抛出异常
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="number"></param>
        public static void ConvertStringToDouble(TextBox txt, out double number)
        {
            IsNullOrEmptyString(txt);
            if (!double.TryParse(txt.Text, out number))
            {
                throw new Exception("所有输入必须是数字");
            }
        }
        /// <summary>
        /// 将窗体设置为必要的对话框模式
        /// </summary>
        /// <param name="form"></param>
        public static void SetFormToFixedSingleDialog(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
        }
    }
}
