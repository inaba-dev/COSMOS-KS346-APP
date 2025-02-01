using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// 
    /// </summary>

    public class ClassReset
    {
        public byte 処理結果;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_Reset
    {
        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassReset param = Parse(datas);

            string msg = "処理結果：" + (param.処理結果 == 0x00 ? "OK" : "NG");
            sensordata.Add(msg);

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassReset Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 5) return null;

            ClassReset param = new ClassReset();

            param.処理結果 = datas[5];

            return param;
        }
    }
}
