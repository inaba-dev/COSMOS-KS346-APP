using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APP.ClassSensorMain;

namespace APP
{
    public partial class UserControlDevice : UserControl
    {
        private int CH = 0;

        public event EventHandler UpdateEvent;

        public UserControlDevice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Setup(int ch)
        {
            ///自チャンネルの定義
            CH = ch;

            ///ラベルを更新
            checkValid.Text = ch + "CH";
        }

        /// <summary>
        /// 
        /// </summary>

        public void Valid(bool flag_comopen)
        {
            bool valid = flag_comopen && checkValid.Checked;

            if (valid)
            {
                this.BackColor = Color.PaleTurquoise;
                tabControl.Enabled = true;
            }
            else 
            {
                this.BackColor = Color.Transparent; 
                tabControl.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonZero_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpan_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonData_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonVer_Click(object sender, EventArgs e)
        {
            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサバージョン取得, CH, null);

            /// 受信パケット解析
            var temporary = Common.Sensor.ControlNdirVersion.Parse(receivedatas);
            if (temporary == null) return;

            /// ラベル表示
            textVer.Text = Common.Sensor.ControlNdirVersion.GetVersion(temporary);
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ情報取得, CH, null);

            /// 受信パケット解析
            var temporary = Common.Sensor.ControlNdirSensorInfo.Parse(receivedatas);
            if (temporary == null) return;

            /// ラベル表示
            textGas.Text = Common.Sensor.ControlNdirSensorInfo.GetGasName(temporary);
        }

        /// <summary>
        /// 
        /// </summary>

        private void valid_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEvent(this, EventArgs.Empty);
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonSet_B0_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_B1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_B2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_B3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_B4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_B5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_製造番号_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonGet_B0_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_B1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_B2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_B3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_B4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_B5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_製造番号_Click(object sender, EventArgs e)
        {

        }
    }
}
