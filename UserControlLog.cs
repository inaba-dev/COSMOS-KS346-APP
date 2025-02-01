using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class UserControlLog : UserControl
    {
        public UserControlLog()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            richTextBox.Clear();
        }

        /// <summary>
        /// 関数：状態表示（改行あり）
        /// </summary>

        public void WriteLF(string line)
        {
            richTextBox.Text += line + "\r\n";

            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.ScrollToCaret();
        }

        /// <summary>
        /// 関数：未実装表示（改行あり）
        /// </summary>

        public void Nothing()
        {
            richTextBox.Text += "[未実装]\r\n";

            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.ScrollToCaret();
        }

        public void Nothing(string msg)
        {
            richTextBox.Text += "[未実装]" + msg +"\r\n";

            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.ScrollToCaret();
        }
    }
}
