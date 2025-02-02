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
        public void InitializeView()
        {             
            /// センサのインスタンス
            Common.Sensor = new ClassSensorMain();

            /// ステータス画面のインスタンス
            //Common.Status = new UserControlDevice();
            //Common.Status.Location = new System.Drawing.Point(15, 80);
            //Common.Status.Name = "Status";
            //Common.Status.Size = new System.Drawing.Size(500, 320);
            //this.Controls.Add(Common.Status);

            /// ログ表示画面のインスタンス
            Common.richTextBox = new UserControlLog();
            Common.richTextBox.Location = new System.Drawing.Point(1065, 690);
            Common.richTextBox.Name = "richTextBox";
            Common.richTextBox.Size = new System.Drawing.Size(500, 200);
            this.Controls.Add(Common.richTextBox);

            /// 各デバイス画面の初期化
            CH1.Setup(1);
            CH2.Setup(2);
            CH3.Setup(3);
            CH4.Setup(4);
            CH5.Setup(5);
            CH6.Setup(6);
            CH7.Setup(7);
            CH8.Setup(8);
        }

        /// <summary>
        /// 
        /// </summary>

        private void FormViewRenew()
        {
            bool bOpen = Common.Sensor.Com.IsOpen();

            Func.sendbutton_Color_control(buttonConnect, !bOpen);
            Func.sendbutton_Color_control(buttonDisConnect, bOpen);

            //Func.sendbutton_Color_control(button_Logsave, valid);
            //Func.sendbutton_Color_control(button_Logclear, true);

            Func.sendbutton_Color_control(button_start, bOpen && !timer.Enabled);
            Func.sendbutton_Color_control(button_stop, bOpen && timer.Enabled);

            numericInterval.Enabled = !timer.Enabled;

            CH1.Enabled = !timer.Enabled;
            CH2.Enabled = !timer.Enabled;
            CH3.Enabled = !timer.Enabled;
            CH4.Enabled = !timer.Enabled;
            CH5.Enabled = !timer.Enabled;
            CH6.Enabled = !timer.Enabled;
            CH7.Enabled = !timer.Enabled;
            CH8.Enabled = !timer.Enabled;

            CH1.Valid(bOpen, timer.Enabled);
            CH2.Valid(bOpen, timer.Enabled);
            CH3.Valid(bOpen, timer.Enabled);
            CH4.Valid(bOpen, timer.Enabled);
            CH5.Valid(bOpen, timer.Enabled);
            CH6.Valid(bOpen, timer.Enabled);
            CH7.Valid(bOpen, timer.Enabled);
            CH8.Valid(bOpen, timer.Enabled);
        }
    }
}
