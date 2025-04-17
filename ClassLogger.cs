using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace APP
{
    public class ClassLogger
    {
        public bool bValid { get; set; }

        public List<ClassNdirSensorStatusV2> DataBuffer = new List<ClassNdirSensorStatusV2>();

        /// 自CH情報
        private int CH = 0;

        private string[] Header = new string[] {
                "時刻",
                "RawCount",
                "GasConc",
                "Temperature",
                "Status",
                "Alarm",
                "Error",
            };

        private string filepath = "";
        private bool bInit = false;

        /// <summary>
        /// 
        /// </summary>

        public ClassLogger(int ch)
        {
            ///自チャンネルの定義
            CH = ch;
        }

        /// <summary>
        /// ロギング
        /// </summary>

        /*** 書き込みファイルパス ***/
        public bool Init(string path, bool valid)
        {
            ///有効無効
            bValid = valid;

            if (!bValid) return true;

            ///出力ファイルパス
            filepath = "";
            filepath += path + @"\";
            filepath += DateTime.Now.ToString("yyyyMMdd_HHmmss_") + CH + "ch" + ".csv";

            StreamWriter _stream = null;

            ///Open
            _stream = new StreamWriter(filepath, true, System.Text.Encoding.GetEncoding("shift_jis"));
            if (_stream == null) return false;

            ///ヘッダーの書き込み
            _stream.WriteLine(String.Join(",", Header));

            ///Close
            _stream.Flush();
            _stream.Close();

            ///データバッファをクリア
            DataBuffer.Clear();

            ///初期化完了
            bInit = true;

            return true;
        }

        /*** クローズ ***/
        public void Close()
        {
            filepath = "";

            ///初期化フラグクリア
            bInit = false;
        }

        /*** データ書込み ***/
        public void Write(ClassNdirSensorStatusV2 data)
        {
            if (!bInit || !bValid) return; 

            DataBuffer.Add(data);

            ///ログデータ書き込み

            if (DataBuffer.Count > 10)
            {
                ///書き込みデータ生成
                string str = _WriteData();

                ///ログ書き込み
                _WriteExec(str);

                ///データバッファをクリア
                DataBuffer.Clear();
            }
        }

        private string _WriteData()
        {
            string str = "";

            DateTime now = DateTime.Now;
            string TimeStamp = "'" + now.ToString("yyyy/MM/dd HH:mm:ss.") + now.Millisecond;

            foreach (var buff in DataBuffer)
            {
                ///書込みデータ生成
                str +=
                TimeStamp + "," +
                "0" + "," +
                buff.GasConc + "," +
                "0" + "," + 
                "0x" + buff.Status.ToString("X2") + "," +
                "0x00" + "," +
                "0x" + buff.Error.ToString("X4") + "\n";
            }

            return str;
        }

        private async void _WriteExec(string str)
        {
            try
            {
                StreamWriter _stream = null;

                await Task.Run(() =>
                {
                    ///Open
                    _stream = new StreamWriter(filepath, true, System.Text.Encoding.GetEncoding("shift_jis"));

                    ///Write
                    _stream.Write(str);

                    ///Close
                    if (_stream != null)
                    {
                        _stream.Flush();
                        _stream.Close();
                    }
                });
            }
            catch
            {

            }
        }
    }
}
