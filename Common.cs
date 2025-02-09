using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Statistics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP
{
    public static class Common
    {
        /// センサ
        static public ClassSensorMain Sensor;

        /// UserControl
        static public UserControlLog richTextBox;

        /// Configデータ
        static public ClassConfig Config = new ClassConfig();

        /// ログ開始時間
        static public DateTime StartTime;

        /// <summary>
        /// 共通変数
        /// </summary> 

        public const byte g_SERIAL_sendSOH = (byte)0x40;

        /// <summary>
        /// 関数：ガス種の選択
        /// </summary>        

        static public byte Select_Gasspecies(string Gastype)
        {
            switch (Gastype)
            {
                case "COMB": return (byte)0x00;
                case "O2": return (byte)0x01;
                case "CL2": return (byte)0x02;
                case "SO2": return (byte)0x03;
                case "NH3": return (byte)0x04;
                case "CO": return (byte)0x05;
                case "H2S": return (byte)0x06;
                case "CO2": return (byte)0x07;
                default: return (byte)0xFF;
            }
        }

        /// <summary>
        /// 関数：事前準備
        /// </summary>

        static public bool PrepareProc()
        {
            /// COMの確認
            if (!Common.Sensor.Com.IsOpen())
            {
                ClassMessageBox.com_ErrorMessage();
                return false;
            }

            /// チェックボックスを取得
            //Common.Status.GetSelectCH();

            /// チェックボックス確認
            if (Common.Config.checkboxes.Count(s => s == true) == 0)
            {
                ClassMessageBox.CH_ErrorMessage();
                return false;
            }

            /// シリアル番号の取得
            //Common.Status.GetSerialNumber();

            /// 全ラベルの値をクリア
            //Common.Status.ClearStatus();

            /// ログクリア
            Common.richTextBox.Clear();

            return true;
        }
    }
}
