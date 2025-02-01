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

    public class ClassSensorParam
    {
        public byte 設定データフラグ;
        public byte センサ種;
        public byte ガス種数;
        public UInt32 シリアルNo;
        public UInt16 センサ断線エラー1;
        public UInt16 サプレッション範囲内;
        public UInt16 サプレッション範囲外;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_SensorParam
    {
        /// <summary>
        /// 
        /// </summary>

        public string GetGasName(ClassSensorParam param)
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

        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassSensorParam param = Parse(datas);

            //　Data1：センサ種
            sensordata.Add("センサ種：" + GetGasName(param));

            //　Data2：ガス種数
            sensordata.Add("ガス種数：" + param.ガス種数.ToString());

            //　Data3-6：シリアルNO           
            sensordata.Add("シリアルNo：" + param.シリアルNo.ToString("D9"));

            //　Data7-8：センサ断線エラー1判定値
            sensordata.Add("センサ断線エラー1判定値：" + param.センサ断線エラー1.ToString());

            //　Data9-10：サプレッション範囲内
            sensordata.Add("サプレッション範囲内濃度取得周期：" + param.サプレッション範囲内.ToString());

            //　Data11 - 12：サプレッション範囲外
            sensordata.Add("サプレッション範囲外濃度取得周期：" + param.サプレッション範囲外.ToString());

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassSensorParam Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 16) return null;

            ClassSensorParam param = new ClassSensorParam();

            //　Data1：センサ種
            param.センサ種 = datas[5];

            //　Data2：ガス種数
            param.ガス種数 = datas[6];

            //　Data3-6：シリアルNO
            param.シリアルNo = Func.combine_4byte(datas[7].ToString(), datas[8].ToString(), datas[9].ToString(), datas[10].ToString());

            //　Data7-8：センサ断線エラー1判定値
            param.センサ断線エラー1 = (UInt16)Func.combine_2byte(datas[11].ToString(), datas[12].ToString());

            //　Data9-10：サプレッション範囲内
            param.サプレッション範囲内 = (UInt16)Func.combine_2byte(datas[13].ToString(), datas[14].ToString());

            //　Data11 - 12：サプレッション範囲外
            param.サプレッション範囲外 = (UInt16)Func.combine_2byte(datas[15].ToString(), datas[16].ToString());

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassSensorParam param)
        {
            List<byte> sendlist = new List<byte>();

            //　Data0：設定データフラグ
            sendlist.Add((byte)param.設定データフラグ);

            //　Data1：センサ種
            sendlist.Add((byte)param.センサ種);

            //　Data2：ガス種数
            sendlist.Add((byte)param.ガス種数);

            //　Data3-6：シリアルNO
            sendlist.Add((byte)((param.シリアルNo >> 24) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 16) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 8) & 0xFF));
            sendlist.Add((byte)((param.シリアルNo >> 0) & 0xFF));

            //　Data7-8：センサ断線エラー1判定値
            sendlist.Add((byte)((param.センサ断線エラー1 >> 8) & 0xFF));
            sendlist.Add((byte)((param.センサ断線エラー1 >> 0) & 0xFF));

            //　Data9-10：サプレッション範囲内
            sendlist.Add((byte)((param.サプレッション範囲内 >> 8) & 0xFF));
            sendlist.Add((byte)((param.サプレッション範囲内 >> 0) & 0xFF));

            //　Data11 - 12：サプレッション範囲外
            sendlist.Add((byte)((param.サプレッション範囲外 >> 8) & 0xFF));
            sendlist.Add((byte)((param.サプレッション範囲外 >> 0) & 0xFF));

            return sendlist;
        }
    }
}
