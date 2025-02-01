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

    public class ClassGasParam
    {
        public byte ガス種No;
        public UInt16 設定データフラグ;
        public byte ガス種;
        public UInt16 フルスケール;
        public byte 濃度小数点位置;
        public byte 濃度単位;
        public UInt16 アンプ設定切り替え濃度;
        public byte サプレッション濃度上側;
        public byte サプレッション濃度下側;
        public string ガス名;
        public UInt16 ゼロ安定閾値;
        public byte オートゼロ;
        public UInt16 断線エラー2閾値;
        public UInt16 ベースエラー上限閾値;
        public UInt16 ベースエラー下限閾値;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_GasParam
    {
        public byte ConvertIndex(string name)
        {
            switch (name)
            {
                case "COMB":
                    return ((byte)0x00);
                case "O2":
                    return ((byte)0x01);
                case "CL2":
                    return ((byte)0x02);
                case "SO2":
                    return ((byte)0x03);
                case "NH3":
                    return ((byte)0x04);
                case "CO":
                    return ((byte)0x05);
                case "H2S":
                    return ((byte)0x06);
                case "CO2":
                    return ((byte)0X07);
                default:
                    return ((byte)0x00);
            } 
        }

        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            /// 受信データ解析
            ClassGasParam param = Parse(datas);

            //　Data1：ガス種
            switch (param.ガス種)
            {
                case (byte)0x00:
                    sensordata.Add("ガス種：COMB");
                    break;
                case (byte)0x01:
                    sensordata.Add("ガス種：O2");
                    break;
                case (byte)0x02:
                    sensordata.Add("ガス種：CL2");
                    break;
                case (byte)0x03:
                    sensordata.Add("ガス種：SO2");
                    break;
                case (byte)0x04:
                    sensordata.Add("ガス種：NH3");
                    break;
                case (byte)0x05:
                    sensordata.Add("ガス種：CO");
                    break;
                case (byte)0x06:
                    sensordata.Add("ガス種：H2S");
                    break;
                case (byte)0x07:
                    sensordata.Add("ガス種：CO2");
                    break;
                default:
                    sensordata.Add("ガス種：不正なデータを受信しました。" + "(0x" + datas[5].ToString("X") + ")");
                    break;
            }

            //　Data2-3：フルスケール　         
            sensordata.Add("フルスケール：" + param.フルスケール);

            //　Data4：濃度小数点位置
            switch (param.濃度小数点位置)
            {
                case (byte)0x00:
                    sensordata.Add("濃度小数点位置：小数点なし");
                    break;
                case (byte)0x01:
                    sensordata.Add("濃度小数点位置：小数点第一位まで");
                    break;
                case (byte)0x02:
                    sensordata.Add("濃度小数点位置：小数点第二位まで");
                    break;
                case (byte)0x03:
                    sensordata.Add("濃度小数点位置：10倍");
                    break;
                default:
                    sensordata.Add("濃度小数点位置：不正なデータを受信しました。" + "(0x" + param.濃度小数点位置.ToString("X") + ")");
                    break;
            }

            //　Data5：濃度単位
            switch (param.濃度単位)
            {
                case (byte)0x00:
                    sensordata.Add("濃度単位：ppm");
                    break;
                case (byte)0x01:
                    sensordata.Add("濃度単位：ppb");
                    break;
                case (byte)0x02:
                    sensordata.Add("濃度単位：%LEL");
                    break;
                case (byte)0x03:
                    sensordata.Add("濃度単位：vol%");
                    break;
                default:
                    sensordata.Add("濃度単位：不正なデータを受信しました。" + "(0x" + param.濃度単位.ToString("X") + ")");
                    break;
            }

            //　Data6-7：アンプ設定切替濃度            
            sensordata.Add("アンプ設定切替濃度：" + param.アンプ設定切り替え濃度.ToString());

            //　Data8：サプレッション濃度上側
            sensordata.Add("サプレッション濃度上側：" + param.サプレッション濃度上側.ToString());

            //　Data9：サプレッション濃度下側
            sensordata.Add("サプレッション濃度下側：" + param.サプレッション濃度下側.ToString());

            //　Data10-19：ガス名
            sensordata.Add("ガス名：" + param.ガス名);

            //　Data20-21：ゼロ安定閾値
            sensordata.Add("ゼロ安定閾値：" + param.ゼロ安定閾値);

            //　Data22：オートゼロ
            switch (param.オートゼロ)
            {
                case (byte)0x00:
                    sensordata.Add("オートゼロ：無効");
                    break;
                case (byte)0x01:
                    sensordata.Add("オートゼロ：有効");
                    break;
                default:
                    sensordata.Add("オートゼロ：不正なデータを受信しました。" + "(0x" + param.オートゼロ.ToString("X") + ")");
                    break;
            }

            //　Data23-24：断線エラー2閾値
            sensordata.Add("断線エラー2閾値：" + param.断線エラー2閾値.ToString());

            //　Data25-26：ベースエラー上限閾値
            sensordata.Add("ベースエラー上限閾値：" + param.ベースエラー上限閾値.ToString());

            //　Data27-28：ベースエラー下限閾値
            sensordata.Add("ベースエラー下限閾値：" + param.ベースエラー下限閾値.ToString());

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassGasParam Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 33) return null;

            ClassGasParam param = new ClassGasParam();

            //　Data1：ガス種
            param.ガス種 = datas[5];

            //　Data2-3：フルスケール　         
            param.フルスケール = (UInt16)Func.combine_2byte(datas[6].ToString(), datas[7].ToString());

            //　Data4：濃度小数点位置
            param.濃度小数点位置 = datas[8];

            //　Data5：濃度単位
            param.濃度単位 = datas[9];

            //　Data6-7：アンプ設定切替濃度            
            param.アンプ設定切り替え濃度 = (UInt16)Func.combine_2byte(datas[10].ToString(), datas[11].ToString());

            //　Data8：サプレッション濃度上側
            param.サプレッション濃度上側 = datas[12];

            //　Data9：サプレッション濃度下側
            param.サプレッション濃度下側 = datas[13];

            //　Data10-19：ガス名                        
            param.ガス名 = get_gasname(datas);

            //　Data20-21：ゼロ安定閾値            
            param.アンプ設定切り替え濃度 = (UInt16)Func.combine_2byte(datas[24].ToString(), datas[25].ToString());

            //　Data22：オートゼロ
            param.オートゼロ = datas[26];

            //　Data23-24：断線エラー2閾値
            param.断線エラー2閾値 = (UInt16)Func.combine_2byte(datas[27].ToString(), datas[28].ToString());

            //　Data25-26：ベースエラー上限閾値
            param.ベースエラー上限閾値 = (UInt16)Func.combine_2byte(datas[29].ToString(), datas[30].ToString());

            //　Data27-28：ベースエラー下限閾値
            param.ベースエラー下限閾値 = (UInt16)Func.combine_2byte(datas[31].ToString(), datas[32].ToString());

            return param;

            /// <summary>
            /// 関数：ガス名を取得
            /// </summary>

            string get_gasname(List<byte> _datas)
            {
                string _gasname = "";

                for (int i = 14; i < 24; i++)
                {
                    //if (datas[i]!=0 && datas[i] != 42) 
                    if (datas[i] != 0)
                    {
                        _gasname += (char)_datas[i];
                    }
                }
                return _gasname;
            }
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassGasParam param)
        {
            List<byte> sendlist = new List<byte>();

            //　ガス種No.
            sendlist.Add((byte)param.ガス種No);

            //　設定データフラグ
            sendlist.Add((byte)(param.設定データフラグ));

            //　ガス種
            sendlist.Add((byte)param.ガス種);

            //　フルスケール
            sendlist.Add((byte)((param.フルスケール >> 8) & 0xFF));
            sendlist.Add((byte)((param.フルスケール >> 0) & 0xFF));

            //　濃度小数点位置
            sendlist.Add((byte)param.濃度小数点位置);

            //　濃度単位
            sendlist.Add((byte)param.濃度単位);

            //　アンプ設定切替濃度            
            sendlist.Add((byte)((param.アンプ設定切り替え濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.アンプ設定切り替え濃度 >> 0) & 0xFF));

            //　サプレッション濃度上側
            sendlist.Add((byte)param.サプレッション濃度上側);

            //　サプレッション濃度下側
            sendlist.Add((byte)param.サプレッション濃度下側);

            //　ガス名                        
            sendlist.Add((byte)param.ガス種);

            //　ゼロ安定閾値            
            sendlist.Add((byte)((param.フルスケール >> 8) & 0xFF));
            sendlist.Add((byte)((param.フルスケール >> 0) & 0xFF));

            //　オートゼロ
            sendlist.Add((byte)param.オートゼロ);

            //　断線エラー2閾値
            sendlist.Add((byte)((param.断線エラー2閾値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.断線エラー2閾値 >> 0) & 0xFF));

            //　ベースエラー上限閾値
            sendlist.Add((byte)((param.ベースエラー上限閾値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.ベースエラー上限閾値 >> 0) & 0xFF));

            //　ベースエラー下限閾値
            sendlist.Add((byte)((param.ベースエラー下限閾値 >> 8) & 0xFF));
            sendlist.Add((byte)((param.ベースエラー下限閾値 >> 0) & 0xFF));

            return sendlist;
        }
    }
}
