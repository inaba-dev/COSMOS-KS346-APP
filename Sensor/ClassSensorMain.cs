using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using MathNet.Numerics.Statistics;
using static APP.ClassSensorMain;

namespace APP
{
    public class ClassSensorMain
    {
        public ClasssCom Com = new ClasssCom();

        private ClassSensorPacket Packet = new ClassSensorPacket();

        public Control_NdirSensorInfo ControlNdirSensorInfo = new Control_NdirSensorInfo();
        public Control_NdirSensorParam ControlNdirSensorParam = new Control_NdirSensorParam();
        public Control_NdirSensorStatus ControlNdirSensorStatus = new Control_NdirSensorStatus();
        public Control_NdirSpanAdjust ControlNdirSpanAdjust = new Control_NdirSpanAdjust();
        public Control_NdirZeroAdjust ControlNdirZeroAdjust = new Control_NdirZeroAdjust();
        public Control_NdirVersion ControlNdirVersion = new Control_NdirVersion();

        public delegate List<string> FuncDelegate(List<byte> datas);

        /// <summary>
        /// 
        /// </summary>

        public class StFunc
        {
            public byte code;
            public string name;
        }

        public enum FuncCode : int
        {
            センサ情報取得,
            センサ情報設定,
            ガス情報取得,
            ガス情報設定,
            ガス調整情報取得,
            ガス調整情報設定,
            警報設定情報取得,
            警報設定情報設定,
            センサ期限情報取得,
            センサ使用時間取得,
            センサ使用時間設定,
            バージョン取得,
            NDIRセンサ情報取得,
            NDIRセンサ状態取得,
            NDIRセンサパラメータ取得,
            NDIRセンサパラメータ設定,
            NDIRセンサゼロ調整要求,
            NDIRセンサゼロ調整結果,
            NDIRセンサスパン調整要求,
            NDIRセンサスパン調整結果,
            NDIRセンサバージョン取得,
        };

        public static StFunc[] Command = new StFunc[]
        {
            new StFunc() {code = 0x00, name = "センサ情報取得"},
            new StFunc() {code = 0x01, name = "センサ情報設定"},
            new StFunc() {code = 0x02, name = "ガス情報取得"},
            new StFunc() {code = 0x03, name = "ガス情報設定"},
            new StFunc() {code = 0x04, name = "ガス調整情報取得"},
            new StFunc() {code = 0x05, name = "ガス調整情報設定"},
            new StFunc() {code = 0x0E, name = "警報設定情報取得"},
            new StFunc() {code = 0x0F, name = "警報設定情報設定"},
            new StFunc() {code = 0x14, name = "センサ期限情報取得"},
            new StFunc() {code = 0x16, name = "センサ使用時間取得"},
            new StFunc() {code = 0x17, name = "センサ使用時間設定"},
            new StFunc() {code = 0xC4, name = "バージョン取得"},
            new StFunc() {code = 0x40, name = "NDIRセンサ情報取得"},
            new StFunc() {code = 0x41, name = "NDIRセンサ状態取得"},
            new StFunc() {code = 0x43, name = "NDIRセンサパラメータ取得"},
            new StFunc() {code = 0x44, name = "NDIRセンサパラメータ設定"},
            new StFunc() {code = 0x45, name = "NDIRセンサゼロ調整要求"},
            new StFunc() {code = 0x46, name = "NDIRセンサゼロ調整結果"},
            new StFunc() {code = 0x47, name = "NDIRセンサスパン調整要求"},
            new StFunc() {code = 0x48, name = "NDIRセンサスパン調整結果"},
            new StFunc() {code = 0x49, name = "NDIRセンサバージョン取得"},
        };

        /// <summary>
        /// 
        /// </summary>
        /*
        public void ReadSequence(byte cmd)
        {
            List<byte> writedatas = new List<byte>();
            FuncDelegate readfunc;

            /// 事前準備(情報取得)
            if (!Common.PrepareProc()) return;

            switch (cmd)
            {
                case (byte)FuncCode.センサ情報取得:

                    /// 画面表示のファンクション定義(Delegate)
                    readfunc = new FuncDelegate(Common.Sensor.ControlSensorParam.Output);

                    Common.Sensor.ExecAll(cmd, null, readfunc);
                    
                    break;

                case (byte)FuncCode.ガス情報取得:

                    /// 画面表示のファンクション定義(Delegate)
                    readfunc = new FuncDelegate(Common.Sensor.ControlGasParam.Output);

                    Common.Sensor.ExecAll(cmd, writedatas, readfunc);

                    break;

                case (byte)FuncCode.ガス調整情報取得:

                    /// 画面表示のファンクション定義(Delegate)
                    readfunc = new FuncDelegate(Common.Sensor.ControlGasAdjust.Output);

                    Common.Sensor.ExecAll(cmd, writedatas, readfunc);

                    break;

                case (byte)FuncCode.警報設定情報取得:

                    /// 画面表示のファンクション定義(Delegate)
                    readfunc = new FuncDelegate(Common.Sensor.ControlAlarmParam.Output);

                    Common.Sensor.ExecAll(cmd, writedatas, readfunc);

                    break;                    


                case (byte)FuncCode.バージョン取得:

                    /// 画面表示のファンクション定義(Delegate)
                    readfunc = new FuncDelegate(Common.Sensor.ControlVersion.Output);

                    Common.Sensor.ExecAll(cmd, null, readfunc);

                    break;

                default:

                    break;
            }
        }
        */
        /// <summary>
        /// 
        /// </summary>
        /*
        public void WriteSequence(byte cmd, List<byte> writedatas)
        {
            /// 事前準備(情報取得)
            if (!Common.PrepareProc()) return;

            switch (cmd)
            {
                case (byte)FuncCode.センサ情報設定:

                    Common.Sensor.ExecAll(cmd, writedatas, null);
                    break;

                case (byte)FuncCode.ガス情報設定:

                    Common.Sensor.ExecAll(cmd, writedatas, null);
                    break;

                case (byte)FuncCode.ガス調整情報設定:

                    Common.Sensor.ExecAll(cmd, writedatas, null);
                    break;

                case (byte)FuncCode.警報設定情報設定:

                    Common.Sensor.ExecAll(cmd, writedatas, null);
                    break;

                case (byte)FuncCode.センサ使用時間設定:

                    Common.Sensor.ExecAll(cmd, writedatas, null);
                    break;

                default:

                    break;
            }
        }
        */
        /// <summary>
        /// 関数：応答結果(Data[0])の確認
        /// </summary>

        public string Response_Data(byte data)
        {
            switch (data)
            {
                case (byte)0x00: return "OK";
                case (byte)0x01: return "チェックサムエラー";
                case (byte)0x02: return "パラメータ不正";
                case (byte)0x03: return "タイムアウトエラー";
                case (byte)0x04: return "内部エラー";
                case (byte)0x05: return "モードエラー";
                case (byte)0x06: return "該当コマンドなし";
                case (byte)0x07: return "未実装";
                case (byte)0x08: return "コマンド長不正";
                default: return "意図しないデータが確認されました。" + "(0x" + data.ToString("X") + ")";
            }
        }

        /// <summary>
        /// 固有のCHのみ実行
        /// </summary>

        public List<byte> Exec(int cmd, int ch, List<byte> writedatas)
        {
            List<byte> receivedatas = new List<byte>();

            Communication(Command[cmd], ch, writedatas, null, out receivedatas);

            return receivedatas;
        }

        /// <summary>
        /// すべてのCHを実行
        /// </summary>

        public void ExecAll(int cmd, List<byte> writedatas, FuncDelegate readfunc)
        {
            List<byte> receivedatas = new List<byte>();

            foreach (var result in Common.Config.config.checkboxes.Select((p, x) => new { p, x }))
            {
                int ch = result.x + 1;

                if (result.p)
                {
                    Communication(Command[cmd], ch, writedatas, readfunc, out receivedatas);
                }
            }
        }

        ////////////////////////////////////////////////////////////
        /// 処理関数
        ////////////////////////////////////////////////////////////

        /// <summary>
        /// 
        /// </summary>

        private bool Communication(StFunc cmd, int ch, List<byte> writedatas, FuncDelegate readfunc, out List<byte> receivedatas)
        {
            /// 作業名
            Common.Config.config.funcstring = cmd.name;
            Common.richTextBox.WriteLF(ClassWriteLog.Start_Log(ch));

            string funcname = Common.Config.config.funcstring;

            /// 処理実行
            bool res = _Exec_Communication(cmd, ch, writedatas, out receivedatas);

            if (!res)
            {
                //Common.Status.LabelUpdate(ch, funcname + "失敗", false);
                Common.richTextBox.WriteLF(ClassWriteLog.Finish_Log(funcname + " ** 失敗 **"));
            }
            else
            {
                //Common.Status.LabelUpdate(ch, funcname + "成功", true);
                Common.richTextBox.WriteLF(ClassWriteLog.Finish_Log(funcname + " 成功"));

                /// 結果出力(表示)
                if (readfunc != null && receivedatas != null)
                {
                    Common.richTextBox.WriteLF("---------------------");
                    foreach (string data in readfunc(receivedatas)) Common.richTextBox.WriteLF(data);
                }
            }

            return res;
        }

        /// <summary>
        /// 
        /// </summary>

        private bool _Exec_Communication(StFunc cmd, int ch, List<byte> writedatas, out List<byte> receivedatas)
        {
            receivedatas = new List<byte>();

            /// セレクタ制御
            if (!_Exec_CommSelect(ch))
            {
                receivedatas = null;
                return false;
            }

            /// センサデータ取得
            receivedatas = _Exec_ComSensor(cmd.code, writedatas);

            if (receivedatas == null || receivedatas.Count() == 0)
            {
                receivedatas = null;
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>

        private bool _Exec_CommSelect(int ch)
        {
            int RetryCount = 0;
            byte[] receivedDatas = new byte[256];

            /// 送信パケット生成
            List<byte> packet = Packet.SelectPacket_create(ch);

            while (RetryCount < Define.defRetry)
            {
                // 送信処理
                Common.Sensor.Com.Send(packet.ToArray());

                Thread.Sleep(100);

                // 受信処理  
                if (Common.Sensor.Com.Read(receivedDatas, out int len))
                {
                    /// 受信データチェック(一致)
                    foreach (var data in packet.Select((p, x) => new { p, x }))
                    {
                        if (data.p != receivedDatas[data.x]) return false;
                    }

                    return true;
                }

                RetryCount++;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>

        private List<byte> _Exec_ComSensor(byte cmd, List<byte> writedatas)
        {
            int RetryCount = 0;
            byte[] receivedDatas = new byte[256];

            /// 送信パケット生成
            List<byte> packet = Packet.DataPacket_create((byte)cmd, writedatas);

            /// 先頭にダミーパケット追加(センサ仕様で先頭にDummyが必要)
            //packet.Insert(0, (byte)0xFF);

            while (RetryCount < Define.defRetry)
            {
                //　送信処理
                Common.Sensor.Com.Send(packet.ToArray());

                Thread.Sleep(300);

                // 受信処理  
                if (Common.Sensor.Com.Read(receivedDatas, out int len))
                {
                    /// ヘッダーチェック
                    if (receivedDatas[0] != 0xC0) return null;

                    /// データ長
                    int length = receivedDatas[1] + 1;

                    /// チェックサムの処理
                    int sum = 0;
                    for (int i = 0; i < length; i++) sum += (int)receivedDatas[i];
                    if (receivedDatas[length] != (sum & 0xFF)) return null;

                    /// センサからの応答              
                    return (Response_Data(receivedDatas[4]) != "OK") ? null : receivedDatas.ToList();
                }

                RetryCount++;
            }

            return null;
        }
    }
}
