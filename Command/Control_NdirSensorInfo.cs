using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// 
    /// </summary>

    public class ClassNdirSensorInfo
    {
        public byte センサ種;
        public UInt32 シリアルNo;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirSensorInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public string GetGasName(ClassNdirSensorInfo param)
        {
            switch (param.センサ種)
            {
                case (byte)0x00: return ("未定義");
                case (byte)0x01: return ("定電位(O2)");
                case (byte)0x02: return ("定電位(CL2)");
                case (byte)0x03: return ("定電位(SO2)");
                case (byte)0x04: return ("定電位(NH3)");
                case (byte)0x05: return ("定電位(CO)");
                case (byte)0x06: return ("定電位(H2S)");
                case (byte)0x21: return ("NDIR(CO2)");
                case (byte)0x22: return ("NDIR(CH4)");
                case (byte)0x40: return ("MC2");
                case (byte)0x60: return ("MEMS-CH");
                default:         return ("不明");
            }
        }

        public string GetSerial(ClassNdirSensorInfo param)
        {
            switch (param.センサ種)
            {
                case (byte)0x00: return ("未定義");
                case (byte)0x01: return ("定電位(O2)");
                case (byte)0x02: return ("定電位(CL2)");
                case (byte)0x03: return ("定電位(SO2)");
                case (byte)0x04: return ("定電位(NH3)");
                case (byte)0x05: return ("定電位(CO)");
                case (byte)0x06: return ("定電位(H2S)");
                case (byte)0x21: return ("NDIR(CO2)");
                case (byte)0x22: return ("NDIR(CH4)");
                case (byte)0x40: return ("MC2");
                case (byte)0x60: return ("MEMS-CH");
                default: return ("不明");
            }
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirSensorInfo Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 16) return null;

            ClassNdirSensorInfo param = new ClassNdirSensorInfo();

            //　センサ種
            param.センサ種 = datas[5];

            //　シリアルNO
            param.シリアルNo = Func.combine_4byte(datas[7], datas[8], datas[9], datas[10]);

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirSensorInfo param)
        {
            List<byte> sendlist = new List<byte>();

            //　センサ種
            sendlist.Add((byte)param.センサ種);

            //　シリアルNO
            sendlist.Add((byte)((param.シリアルNo >> 24) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 16) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 8) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 0) & 0xFF));

            return sendlist;
        }
    }
}
