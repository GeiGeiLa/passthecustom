using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace LetMePassTheCustom.CustomLibs
{
    /// <summary>
    /// 這是我寫的Lib
    /// </summary>
    public sealed class Utils:Form
    {
        /// <summary> 拖拉的 method
        /// <para>Form 直接傳入 this 即可</para>
        /// 需要自己在外面建立一個 bool 表示允許拖拉
        /// </summary>
        public static void mouseDrag(Form form, Control control, MouseEventArgs e, bool canDrag, Point oldPoint)
        {
            if (canDrag && e.Button == MouseButtons.Left)
            {
                int x = control.Left + (e.X - oldPoint.X);
                if (x > form.ClientSize.Width - control.Width)
                {
                    x = form.ClientSize.Width - control.Width;
                }
                x = (x < 0) ? 0 : x;
                control.Left = x;
                int y = control.Top + (e.Y - oldPoint.Y);
                if (y > form.ClientSize.Height - control.Height)
                {
                    y = form.ClientSize.Height - control.Height;
                }
                y = (y < 0) ? 0 : y;
                control.Top = y;
            }
        }
        /// <summary> 取得控制項的中間位置
        /// <para>Form 直接傳入 button, label 所有控制項</para>
        /// </summary>
        public static Point CenterOf(Control control)
        {
            return new Point(
                control.Left + control.Width / 2,
                control.Top + control.Height / 2);
        }
    }
}
