using System;
using System.Threading;
using System.IO.Ports;

namespace APP
{
    public class ClasssCom
    {
        private SerialPort serial = new SerialPort();

#if DEMO
        private bool bOpen = false;
#endif

        public bool IsOpen()
        {
#if DEMO
            return bOpen;
#else
            return serial.IsOpen;
#endif
        }

        public bool Open(string portName, int baudRate, int readSize)
        {
            serial.PortName = portName;
            serial.BaudRate = baudRate;          //転送速度を設定するパラメータ
            serial.Parity = Parity.None;          //パリティチェックは行わない
            serial.DataBits = 8;                //データは8bit
            serial.StopBits = StopBits.One;       //ストップビットを1ビットに設定
            serial.Handshake = Handshake.None;    //ハンドシェイクは行わない　ただ、データを送受信するだけ
            serial.ReadBufferSize = readSize;     //データを受信する際にバッファ(一時的にデータを貯め、蓄えるメモリー)を使用する
            serial.ReadTimeout = 1000;            //データの受信が1秒以内に入るように
            serial.DtrEnable = true;             //電源が入っていることを相手に知らせるためのもの
            serial.NewLine = "\n";

            try
            {
#if DEMO
                bOpen = true;
                return true;
#else
                serial.Open();

                serial.DiscardOutBuffer(); //送信バッファをクリアする　  
                serial.DiscardInBuffer();　 //受信バッファをクリアする
                return true;
#endif
            }
            catch (Exception)
            {
                return false;
            }


        }

        public void Close()
        {
#if DEMO
            bOpen = false;
#else
            if (IsOpen())
            {
                serial.Close();
            }
#endif
        }

        public void Send(byte[] srcBuff)
        {
            if (!IsOpen())
            {
                Console.WriteLine("シリアルポートが開いていません。");
                return;
            }

            Console.WriteLine("送信開始");
#if DEBUG
            int i = 1;
            foreach (byte b in srcBuff)
            {
                Console.WriteLine("　送信データ" + "(" + i + ")" + "_" + b.ToString("X2"));
                i++;
            }
#endif
            try
            {
                serial.Write(srcBuff, 0, srcBuff.Length);

                serial.DiscardOutBuffer();
                serial.DiscardInBuffer();
            }
            catch (Exception)
            {
                Console.WriteLine("送信失敗");
            }
        }

        public bool Read(byte[] dstBuff, out int resLen)
        {
            resLen = 0;

            if (!IsOpen())
            {
                Console.WriteLine("シリアルポートが開いていません。");
                return false;
            }

            try
            {
                resLen = serial.Read(dstBuff, 0, dstBuff.Length);

                for (int i = 0; i < resLen; i++)
                {
                    Console.WriteLine("　- 受信データ" + "(" + i + ")" + "_" + dstBuff[i].ToString("X2"));
                }

                serial.DiscardOutBuffer();
                serial.DiscardInBuffer();

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("受信失敗");
                return false;
            }
        }
    }
}
