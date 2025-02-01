using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace APP
{
    /// <summary>
    /// 
    /// </summary>

    public class ClassSensorUseTime
    {
        public UInt32 センサ使用時間;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_SensorUseTime
    {
        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassSensorUseTime param = Parse(datas);

            sensordata.Add("センサ使用時間(秒)：" + param.センサ使用時間.ToString());

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassSensorUseTime Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 9) return null;

            ClassSensorUseTime param = new ClassSensorUseTime();

            param.センサ使用時間 = Func.combine_4byte(datas[5].ToString(), datas[6].ToString(), datas[7].ToString(), datas[8].ToString());

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassSensorUseTime param)
        {
            List<byte> sendlist = new List<byte>();

            sendlist.Add((byte)((param.センサ使用時間 >> 24) & 0xFF));
            sendlist.Add((byte)((param.センサ使用時間 >> 16) & 0xFF));
            sendlist.Add((byte)((param.センサ使用時間 >> 8) & 0xFF));
            sendlist.Add((byte)((param.センサ使用時間 >> 0) & 0xFF));

            return sendlist;
        }
    }
}
