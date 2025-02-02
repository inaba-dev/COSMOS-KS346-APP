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

    public class ClassNdirVersion
    {
        public byte Major;
        public byte Minor;
        public byte Build;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirVersion
    {
        public string GetVersion(ClassNdirVersion param)
        {
            return param.Major.ToString("X") + "." + param.Minor.ToString("X") + "." + param.Build.ToString("X");
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirVersion Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 8) return null;

            ClassNdirVersion param = new ClassNdirVersion();

            param.Major = datas[5];
            param.Minor = datas[6];
            param.Build = datas[7];

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirSensorInfo param)
        {
            List<byte> sendlist = new List<byte>();

            return sendlist;
        }
    }
}
