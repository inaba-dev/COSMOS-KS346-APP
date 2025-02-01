using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APP.ClassSensorMain;

namespace APP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            /// 画面のインスタンス
            InitializeView();

            /// COM更新
            buttonComSearch_Click(null, null);

            ///イベント登録
            CH1.UpdateEvent += new EventHandler(UpdateEvent);
            CH2.UpdateEvent += new EventHandler(UpdateEvent);
            CH3.UpdateEvent += new EventHandler(UpdateEvent);
            CH4.UpdateEvent += new EventHandler(UpdateEvent);
            CH5.UpdateEvent += new EventHandler(UpdateEvent);
            CH6.UpdateEvent += new EventHandler(UpdateEvent);
            CH7.UpdateEvent += new EventHandler(UpdateEvent);
            CH8.UpdateEvent += new EventHandler(UpdateEvent);

            /// Formリロード
            FormReload();
        }

        /// <summary>
        /// 
        /// </summary>

        public void FormReload()
        {
            ///
            Common.Config.LoadConfig();

            ///
            getSoftwareVersion();

            /// Form画面更新
            UpdateEvent(null, null);
        }

        /// <summary>
        /// ソフトウェアバージョンの読込
        /// </summary>

        private void getSoftwareVersion()
        {
            System.Diagnostics.FileVersionInfo ver =
            System.Diagnostics.FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

            this.Text = String.Format("{0} Ver {1}.{2}.{3}", ver.ProductName, ver.FileMajorPart.ToString(), ver.FileMinorPart, ver.FileBuildPart);
        }

        /// <summary>
        /// 画面更新イベント
        /// </summary>

        private void UpdateEvent(object sender, EventArgs e)
        {
            FormViewRenew();
        }

        /// <summary>
        /// 関数：終了時の処理
        /// </summary>

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("アプリケーションを終了しますか？", "終了の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            Common.Config.SaveConfig();

            e.Cancel = false;
        }

        /// <summary>
        /// 部品：「開始ボタン」の制御
        /// </summary>

        private void button_start_Click(object sender, EventArgs e)
        {
            Common.richTextBox.Nothing();
        }

        /// <summary>
        /// 部品：「停止ボタン」の制御
        /// </summary>

        private void button_stop_Click(object sender, EventArgs e)
        {
            Common.richTextBox.Nothing();
        }

        /// <summary>
        /// COMの制御
        /// </summary>

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            /// 接続確認
            if (!Common.Sensor.Com.Open(SelectedCOM(), 38400, 2048))
            {
                //　警告メッセージ表示
                Common.richTextBox.WriteLF(ClassMessageBox.connect_ErrorLog());
            }

            /// Form画面更新
            UpdateEvent(null, null);
        }

        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            /// 切断
            Common.Sensor.Com.Close();

            /// Form画面更新
            UpdateEvent(null, null);
        }

        private void buttonComSearch_Click(object sender, EventArgs e)
        {
            /// COMポートの取得
            SearchCom();

            /// Form画面更新
            UpdateEvent(null, null);
        }

        /// <summary>
        /// ログ保存先設定
        /// </summary>

        private void button_path_Click(object sender, EventArgs e)
        {
            /// ログ保存先設定
            SearchFolder();
        }
    }
}
