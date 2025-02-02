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

    public class ClassNdirSensorParam
    {

    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirSensorParam
    {
        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirSensorParam Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 35) return null;

            ClassNdirSensorParam param = new ClassNdirSensorParam();

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirSensorParam param)
        {
            List<byte> sendlist = new List<byte>();

            return sendlist;
        }
    }
}
