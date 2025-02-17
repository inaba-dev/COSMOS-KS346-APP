using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static APP.ClassSensorMain;

namespace APP
{
    public partial class UserControlDevice : UserControl
    {
        /// 自CH情報
        private int CH = 0;

        /// 更新イベント
        public event EventHandler UpdateEvent;

        /// 保存クラス
        public ClassLogger Logger;

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

            ///インスタンス定義
            Logger = new ClassLogger(ch);
        }

        /// <summary>
        /// 
        /// </summary>

        public void StatusRenewEvent()
        {
            if (checkValid.Checked)
            {
                buttonData_Click(null, EventArgs.Empty);

                Logger.Write(Common.Sensor.CurrentStatus[CH - 1]);
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public void Valid(bool flag_comopen, bool flag_timer)
        {
            bool valid = flag_comopen && checkValid.Checked;

            if (valid)
            {
                this.BackColor = !flag_timer ? Color.PaleTurquoise : Color.Red;
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
            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ状態取得, CH, null);

            /// 受信パケット解析
            ClassNdirSensorStatus CurrentStatus = Common.Sensor.ControlNdirSensorStatus.Parse(receivedatas);

            if (CurrentStatus == null) return;

            /// ラベル表示
            textStatus.Text = CurrentStatus.Status.ToString("X2");
            textAlarm.Text = CurrentStatus.Alarm.ToString("X2");
            textError.Text = CurrentStatus.Error.ToString("X4");
            textGasConc.Text = CurrentStatus.GasConc.ToString();
            textCount.Text = CurrentStatus.RawCount.ToString();
            textTemp.Text = CurrentStatus.Temperature.ToString();

            ///
            Common.Sensor.CurrentStatus[CH - 1] = CurrentStatus;
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

        private void buttonSerial_Click(object sender, EventArgs e)
        {
            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ情報取得, CH, null);

            /// 受信パケット解析
            var temporary = Common.Sensor.ControlNdirSensorInfo.Parse(receivedatas);
            if (temporary == null) return;

            /// ラベル表示
            textSerial.Text = temporary.シリアルNo.ToString("X8");
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
            bool ret = SetNdirSensorParam(0x01, (int)numericW_B0.Value);
            if (ret) buttonGet_B0_Click(null, null);
        }

        private void buttonSet_B1_Click(object sender, EventArgs e)
        {
            bool ret = SetNdirSensorParam(0x02, (int)numericW_B1.Value);
            if (ret) buttonGet_B1_Click(null, null);
        }

        private void buttonSet_B2_Click(object sender, EventArgs e)
        {
            bool ret = SetNdirSensorParam(0x04, (int)numericW_B2.Value);
            if (ret) buttonGet_B2_Click(null, null);
        }

        private void buttonSet_B3_Click(object sender, EventArgs e)
        {
            bool ret = SetNdirSensorParam(0x08, (int)numericW_B3.Value);
            if (ret) buttonGet_B3_Click(null, null);
        }

        private void buttonSet_B4_Click(object sender, EventArgs e)
        {
            bool ret = SetNdirSensorParam(0x10, (int)numericW_B4.Value);
            if (ret) buttonGet_B4_Click(null, null);
        }

        private void buttonSet_B5_Click(object sender, EventArgs e)
        {
            bool ret = SetNdirSensorParam(0x20, (int)numericW_B5.Value);
            if (ret) buttonGet_B5_Click(null, null);
        }

        private bool SetNdirSensorParam(byte flag, Int32 wdata)
        {
            ClassNdirSensorParam param = new ClassNdirSensorParam();

            byte[] data = Func.Change_4bytes(wdata.ToString());

            /// 書込みデータ
            List<byte> writedatas = new List<byte>();
            writedatas.Add(flag);
            writedatas.Add(data[3]);
            writedatas.Add(data[2]);
            writedatas.Add(data[1]);
            writedatas.Add(data[0]);

            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサパラメータ設定, CH, writedatas);

            if (receivedatas == null) return false;

            /// Return
            return true;
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonGet_B0_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x01);
            if(temporary == null) return;

            /// ラベル表示
            textR_B0.Text = temporary.spanConcentration.ToString();
        }

        private void buttonGet_B1_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x02);
            if (temporary == null) return;

            /// ラベル表示
            textR_B1.Text = temporary.lowAlarmThreshold.ToString();
        }

        private void buttonGet_B2_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x04);
            if (temporary == null) return;

            /// ラベル表示
            textR_B2.Text = temporary.highAlarmThreshold.ToString();
        }

        private void buttonGet_B3_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x08);
            if (temporary == null) return;

            /// ラベル表示
            textR_B3.Text = temporary.spanHighConcentration.ToString();
        }

        private void buttonGet_B4_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x10);
            if (temporary == null) return;

            /// ラベル表示
            textR_B4.Text = temporary.spanHighConcentration.ToString();
        }

        private void buttonGet_B5_Click(object sender, EventArgs e)
        {
            var temporary = GetNdirSensorParam(0x20);
            if (temporary == null) return;

            /// ラベル表示
            textR_B5.Text = temporary.spanHighConcentration.ToString();
        }

        private ClassNdirSensorParam GetNdirSensorParam(byte flag)
        {
            ClassNdirSensorParam param = new ClassNdirSensorParam();
            
            /// 書込みデータ
            List<byte> writedatas = new List<byte>();
            writedatas.Add(flag);

            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサパラメータ取得, CH, writedatas);

            /// 受信パケット解析
            param = Common.Sensor.ControlNdirSensorParam.Parse(receivedatas);
            if (param == null) return null;

            /// Return
            return param;
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            /// 受信処理
            List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサフォーマット取得, CH, null);

            /// 受信パケット解析
            //var temporary = Common.Sensor.ControlNdirVersion.Parse(receivedatas);
            //if (temporary == null) return;
        }
    }
}
