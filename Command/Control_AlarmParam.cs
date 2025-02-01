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

    public class ClassAlarmParam
    {
        public byte ガス種No;
        public UInt16 設定データフラグ;
        public byte 警報有効設定;
        public byte 警報判定モード;
        public UInt16 AL1設定値;
        public UInt16 AL2設定値;
        public UInt16 AL3設定値;
        public UInt16 AL設定値上限;
        public UInt16 AL設定値下限;
        public UInt16 STEL設定値;
        public UInt16 STEL設定値上限;
        public UInt16 STEL設定値下限;
        public UInt16 TWA設定値;
        public UInt16 TWA設定値上限;
        public UInt16 TWA設定値下限;
        public UInt16 TxC設定値;
        public UInt16 TxC設定値上限;
        public UInt16 TxC設定値下限;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_AlarmParam
    {
        public enum 警報Code : int
        {
            警報有効設定AL1,
            警報有効設定AL2,
            警報有効設定AL3,
            警報有効設定STEL,
            警報有効設定TWA,
            警報有効設定TxC,
        };

        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassAlarmParam param = Parse(datas);

            // Data1：警報有効設定
            sensordata.Add("警報有効設定AL1："  + ((param.警報有効設定 & 0x01) == 0x01 ? "有効" : "無効"));
            sensordata.Add("警報有効設定AL2："  + ((param.警報有効設定 & 0x02) == 0x02 ? "有効" : "無効"));
            sensordata.Add("警報有効設定AL3："  + ((param.警報有効設定 & 0x04) == 0x04 ? "有効" : "無効"));
            sensordata.Add("警報有効設定STEL：" + ((param.警報有効設定 & 0x08) == 0x08 ? "有効" : "無効"));
            sensordata.Add("警報有効設定TWA："  + ((param.警報有効設定 & 0x10) == 0x10 ? "有効" : "無効"));
            sensordata.Add("警報有効設定TxC："  + ((param.警報有効設定 & 0x20) == 0x20 ? "有効" : "無効"));

            //　Data2：警報判定モード
            sensordata.Add("警報判定モードAL1：" + ((param.警報判定モード & 0x01) == 0x01 ? "上限警報" : "下限警報"));
            sensordata.Add("警報判定モードAL2：" + ((param.警報判定モード & 0x02) == 0x02 ? "上限警報" : "下限警報"));
            sensordata.Add("警報判定モードAL3：" + ((param.警報判定モード & 0x04) == 0x04 ? "上限警報" : "下限警報"));

            //　Data3-4：AL1設定値
            sensordata.Add("AL1設定値：" + param.AL1設定値.ToString());
            sensordata.Add("AL2設定値：" + param.AL2設定値.ToString());
            sensordata.Add("AL3設定値：" + param.AL3設定値.ToString());
            sensordata.Add("AL設定値上限：" + param.AL設定値上限.ToString());
            sensordata.Add("AL設定値下限：" + param.AL設定値下限.ToString());
            sensordata.Add("STEL設定値：" + param.STEL設定値.ToString());
            sensordata.Add("STEL設定値上限：" + param.STEL設定値上限.ToString());
            sensordata.Add("STEL設定値下限：" + param.STEL設定値下限.ToString());
            sensordata.Add("TWA設定値：" + param.TWA設定値.ToString());
            sensordata.Add("TWA設定値上限：" + param.TWA設定値上限.ToString());
            sensordata.Add("TWA設定値下限：" + param.TWA設定値下限.ToString());
            sensordata.Add("TxC設定値：" + param.TxC設定値.ToString());
            sensordata.Add("TxC設定値上限：" + param.TxC設定値上限.ToString());
            sensordata.Add("TxC設定値下限：" + param.TxC設定値下限.ToString());

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassAlarmParam Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 35) return null;

            ClassAlarmParam param = new ClassAlarmParam();

            // Data1：警報有効設定
            param.警報有効設定 = datas[5];

            //　Data2：警報判定モード
            param.警報判定モード = datas[6];

            //　設定値
            param.AL1設定値      = (UInt16)(Func.combine_2byte(datas[7].ToString(), datas[8].ToString()));
            param.AL2設定値      = (UInt16)(Func.combine_2byte(datas[9].ToString(), datas[10].ToString()));
            param.AL3設定値      = (UInt16)(Func.combine_2byte(datas[11].ToString(), datas[12].ToString()));
            param.AL設定値上限   = (UInt16)(Func.combine_2byte(datas[13].ToString(), datas[14].ToString()));
            param.AL設定値下限   = (UInt16)(Func.combine_2byte(datas[15].ToString(), datas[16].ToString()));
            param.STEL設定値     = (UInt16)(Func.combine_2byte(datas[17].ToString(), datas[18].ToString()));
            param.STEL設定値上限 = (UInt16)(Func.combine_2byte(datas[19].ToString(), datas[20].ToString()));
            param.STEL設定値下限 = (UInt16)(Func.combine_2byte(datas[21].ToString(), datas[22].ToString()));
            param.TWA設定値      = (UInt16)(Func.combine_2byte(datas[23].ToString(), datas[24].ToString()));
            param.TWA設定値上限  = (UInt16)(Func.combine_2byte(datas[25].ToString(), datas[26].ToString()));
            param.TWA設定値下限  = (UInt16)(Func.combine_2byte(datas[27].ToString(), datas[28].ToString()));
            param.TxC設定値      = (UInt16)(Func.combine_2byte(datas[29].ToString(), datas[30].ToString()));
            param.TxC設定値上限  = (UInt16)(Func.combine_2byte(datas[31].ToString(), datas[32].ToString()));
            param.TxC設定値下限  = (UInt16)(Func.combine_2byte(datas[33].ToString(), datas[34].ToString()));

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassAlarmParam param)
        {
            List<byte> sendlist = new List<byte>();

            /// ガス種No.1～3
            sendlist.Add((byte)param.ガス種No);

            /// 設定データフラグ
            sendlist.Add((byte)((param.設定データフラグ >> 8) & 0xFF));
            sendlist.Add((byte)((param.設定データフラグ >> 0) & 0xFF));

            //警報有効設定
            sendlist.Add((byte)param.警報有効設定);

            //警報判定モード
            sendlist.Add((byte)param.警報判定モード);

            //設定値
            sendlist.Add((byte)((param.AL1設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.AL1設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.AL2設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.AL2設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.AL3設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.AL3設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.AL設定値上限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.AL設定値上限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.AL設定値下限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.AL設定値下限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値上限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値上限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値下限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.STEL設定値下限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値上限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値上限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値下限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TWA設定値下限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値上限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値上限 >> 0) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値下限 >> 8) & 0xFF));
            sendlist.Add((byte)((param.TxC設定値下限 >> 0) & 0xFF));

            return sendlist;
        }
    }
}
