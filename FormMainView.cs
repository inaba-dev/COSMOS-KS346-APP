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
            bool valid = Common.Sensor.Com.IsOpen();

            CH1.Valid(valid);
            CH2.Valid(valid);
            CH3.Valid(valid);
            CH4.Valid(valid);
            CH5.Valid(valid);
            CH6.Valid(valid);
            CH7.Valid(valid);
            CH8.Valid(valid);

            Func.sendbutton_Color_control(buttonConnect, !valid);
            Func.sendbutton_Color_control(buttonDisConnect, valid);

            //Func.sendbutton_Color_control(button_Logsave, valid);
            //Func.sendbutton_Color_control(button_Logclear, true);

            Func.sendbutton_Color_control(button_start, valid);
            Func.sendbutton_Color_control(button_stop, valid);
        }
    }
}
