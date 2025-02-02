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

    public class ClassNdirSensorStatus
    {
        public UInt16 Status;
        public UInt16 Alarm;
        public UInt16 Error;
        public UInt32 GasConc;
        public UInt32 RawCount;
        public Int16 Temperature;
    }



    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirSensorStatus
    {
        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirSensorStatus Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 16) return null;

            ClassNdirSensorStatus param = new ClassNdirSensorStatus();

            param.Status = datas[5];
            param.Alarm = datas[6];
            param.Error = Func.combine_2byte(datas[7], datas[8]);
            param.GasConc = Func.combine_4byte(datas[9], datas[10], datas[11], datas[12]);
            param.RawCount = 0;
            param.Temperature = (Int16)(datas[15] - 60);

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirSensorStatus param)
        {
            List<byte> sendlist = new List<byte>();

            return sendlist;
        }
    }
}
