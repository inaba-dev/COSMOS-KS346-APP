using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Security.Permissions;

namespace APP
{
    /// <summary>
    /// TextBoxの拡張クラス(数字入力用：ゼロパティング無)
    /// </summary>

    public class TextBoxNumberEx : System.Windows.Forms.TextBox
    {
        /// コピペ無効（WM_PASTEメッセージを無視する）
        const int WM_PASTE = 0x302;

        [SecurityPermission(SecurityAction.Demand,
            Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
                return;

            base.WndProc(ref m);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            /// 
            if (!IsValidChar(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        protected virtual bool IsValidChar(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '.');
        }
    }
}
