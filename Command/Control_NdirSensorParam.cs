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
        public Int32 spanConcentration;
        public Int32 lowAlarmThreshold;
        public Int32 highAlarmThreshold;
        public Int32 spanHighConcentration;
        public Int32 overRange;
        public Int32 overRangeHigh;
        public Int32 driftAlarmThreshold;
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
            if (datas == null || datas.Count < 30) return null;

            ClassNdirSensorParam param = new ClassNdirSensorParam();

            int p = 5;
            param.spanConcentration     = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;
            param.lowAlarmThreshold     = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;
            param.highAlarmThreshold    = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;
            param.spanHighConcentration = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;
            param.overRange             = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;
            param.overRangeHigh         = Func.signcombine_4byte(datas[p], datas[p + 1], datas[p + 2], datas[p + 3]); p += 4;

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
