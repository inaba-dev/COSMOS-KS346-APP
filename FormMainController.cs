using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class FormMain
    {
        /// <summary>
        /// 
        /// </summary>

        public string SelectedCOM()
        {
            try
            {
                return this.comboBox_COM.SelectedItem.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// COM検索
        /// </summary>

        public void SearchCom()
        {
            /// セレクトボックス項目削除
            this.comboBox_COM.Items.Clear();
            this.comboBox_COM.Text = "";
            this.comboBox_COM.Refresh();

#if DEMO
            this.comboBox_COM.Items.Add("COM00");
#else

            /// COMポートの取得
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                this.comboBox_COM.Items.Add(port);
            }
#endif
            /// 先頭をフォーカス
            if (this.comboBox_COM.Items.Count > 0) this.comboBox_COM.SelectedIndex = 0;
        }

        /// <summary>
        /// ログ保存先設定
        /// </summary>

        public void SearchFolder()
        {
            // FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // 上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";

            // ルートフォルダを指定する(デフォルトでDesktop)
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            // 最初に選択するフォルダを指定する
            if (System.IO.Directory.Exists(textBox_path.Text))
            {
                fbd.SelectedPath = textBox_path.Text;
            }
            else
            {
                fbd.SelectedPath = @"C:\Windows";
            }

            // ユーザーが新しいフォルダを作成できるようにする
            fbd.ShowNewFolderButton = true;

            // ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                /// 選択されたフォルダを表示する
                textBox_path.Text = fbd.SelectedPath;
            }
        }
    }
}
