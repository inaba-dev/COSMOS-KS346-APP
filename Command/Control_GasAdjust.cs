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

    public class ClassGasAdjust
    {
        public byte 小数点位置;
        public byte ガス種No;
        public byte 調整ポイント数;
        public UInt16 調整ポイント1濃度;
        public UInt16 調整ポイント2濃度;
        public UInt16 調整ポイント3濃度;
        public UInt16 調整ポイント4濃度;
        public UInt16 調整ポイント5濃度;
        public UInt16 調整ポイント6濃度;
        public UInt16 調整ポイント7濃度;
        public UInt16 調整ポイント8濃度;
        public byte 手動Span調整方法;
    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_GasAdjust
    {
        public byte ConvertIndex(string name)
        {
            switch (name)
            {
                case "1：ピークモード":
                    return ((byte)0x00);
                case "2：ピークモード2":
                    return ((byte)0x01);
                case "3：ピークディレイモード":
                    return ((byte)0x02);
                case "4：ボタンモード":
                    return ((byte)0x03);
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
            ClassGasAdjust param = Parse(datas);

            /// 調整ポイント数
            sensordata.Add("調整ポイント数：" + param.調整ポイント数);

            /// 調整ポイント濃度
            sensordata.Add("調整ポイント1濃度：" + DecimalPoint_add(param.調整ポイント1濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント2濃度：" + DecimalPoint_add(param.調整ポイント2濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント3濃度：" + DecimalPoint_add(param.調整ポイント3濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント4濃度：" + DecimalPoint_add(param.調整ポイント4濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント5濃度：" + DecimalPoint_add(param.調整ポイント5濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント6濃度：" + DecimalPoint_add(param.調整ポイント6濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント7濃度：" + DecimalPoint_add(param.調整ポイント7濃度.ToString(), param.小数点位置));
            sensordata.Add("調整ポイント8濃度：" + DecimalPoint_add(param.調整ポイント8濃度.ToString(), param.小数点位置));

            /// 手動Span調整方法
            switch (param.手動Span調整方法)
            {
                case (byte)0x00:
                    sensordata.Add("手動Span調整方法：ピークモード");
                    break;
                case (byte)0x01:
                    sensordata.Add("手動Span調整方法：ピークモード2");
                    break;
                case (byte)0x02:
                    sensordata.Add("手動Span調整方法：ピークディレイモード");
                    break;
                case (byte)0x03:
                    sensordata.Add("手動Span調整方法：ボタンモード");
                    break;
                default:
                    sensordata.Add("手動Span調整方法：不正なデータを受信しました。" + "(0x" + param.手動Span調整方法.ToString("X") + ")");
                    break;
            }

            return sensordata;

            /// <summary>
            /// 関数：小数点位置の制御
            /// </summary>

            string DecimalPoint_add(string _data, int _decimal)
            {
                if (_data == "0") return _data;
                if (_decimal == 0) return _data;

                // 元の文字列が負の数であるかどうかを確認
                bool isNegative = false;
                if (_data.StartsWith("-"))
                {
                    isNegative = true;
                    _data = _data.Substring(1);
                }

                string modifiedString;

                //　10倍時の処理
                if (_decimal == 10)
                {
                    modifiedString = (int.Parse(_data) * 10).ToString();
                }
                else //小数点の処理 
                {
                    // 文字列が指定された小数点以下の桁数よりも短い場合、必要な桁数まで先頭に0を追加
                    while (_data.Length <= _decimal)
                    {
                        _data = "0" + _data;
                    }

                    // 小数点を挿入して新しい文字列を作成
                    modifiedString = _data.Insert(_data.Length - _decimal, ".");
                }


                // 負の数の場合、再度符号を追加して返す
                if (isNegative)
                {
                    modifiedString = "-" + modifiedString;
                }

                return modifiedString;
            }
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassGasAdjust Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 23) return null;

            ClassGasAdjust param = new ClassGasAdjust();

            /// 調整ポイント数
            param.調整ポイント数 = datas[5];

            /// 調整ポイント濃度
            param.調整ポイント1濃度 = (UInt16)Func.combine_2byte(datas[6].ToString(), datas[7].ToString());
            param.調整ポイント2濃度 = (UInt16)Func.combine_2byte(datas[8].ToString(), datas[9].ToString());
            param.調整ポイント3濃度 = (UInt16)Func.combine_2byte(datas[10].ToString(), datas[11].ToString());
            param.調整ポイント4濃度 = (UInt16)Func.combine_2byte(datas[12].ToString(), datas[13].ToString());
            param.調整ポイント5濃度 = (UInt16)Func.combine_2byte(datas[14].ToString(), datas[15].ToString());
            param.調整ポイント6濃度 = (UInt16)Func.combine_2byte(datas[16].ToString(), datas[17].ToString());
            param.調整ポイント7濃度 = (UInt16)Func.combine_2byte(datas[18].ToString(), datas[19].ToString());
            param.調整ポイント8濃度 = (UInt16)Func.combine_2byte(datas[20].ToString(), datas[21].ToString());

            /// 手動Span調整方法
            param.手動Span調整方法 = datas[22];

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassGasAdjust param)
        {
            List<byte> sendlist = new List<byte>();

            /// ガス種No.1～3
            sendlist.Add((byte)param.ガス種No);

            /// 調整ポイント数
            sendlist.Add((byte)param.調整ポイント数);

            /// 調整ポイント濃度
            sendlist.Add((byte)((param.調整ポイント1濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント1濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント2濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント2濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント3濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント3濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント4濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント4濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント5濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント5濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント6濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント6濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント7濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント7濃度 >> 0) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント8濃度 >> 8) & 0xFF));
            sendlist.Add((byte)((param.調整ポイント8濃度 >> 0) & 0xFF));

            /// 手動Span調整方法
            sendlist.Add((byte)param.手動Span調整方法);

            return sendlist;
        }
    }
}
