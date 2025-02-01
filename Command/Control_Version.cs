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

    public class ClassVersion
    {
        public byte Major;
        public byte Minor;
        public byte Build;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_Version
    {
        public string GetVersion(ClassVersion param)
        {
            return param.Major.ToString("X") + "." + param.Minor.ToString("X") + "." + param.Build.ToString("X");
        }

        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            if (datas == null || datas.Count < 8) return null;

            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassVersion param = Parse(datas);

            /// バージョン
            string Ver = GetVersion(param);
            sensordata.Add(Ver);

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassVersion Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 8) return null;

            ClassVersion param = new ClassVersion();

            param.Major = datas[5];
            param.Minor = datas[6];
            param.Build = datas[7];

            return param;
        }
    }
}
