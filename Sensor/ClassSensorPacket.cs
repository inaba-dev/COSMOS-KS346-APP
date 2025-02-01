using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class ClassSensorPacket
    {
        /// <summary>
        /// 関数：セレクト信号のパケット作成
        /// </summary>

        public List<byte> SelectPacket_create(int ch)
        {
            List<byte> packet = new List<byte>();

            //　ヘッダー
            packet.Add(0x01);

            //　コマンド
            packet.Add((byte)0x10);

            //　データ長
            packet.Add((byte)0x30);
            packet.Add((byte)0x38);

            //　データ
            if      (ch == 1) packet.Add((byte)0x30);
            else if (ch == 2) packet.Add((byte)0x31);
            else if (ch == 3) packet.Add((byte)0x32);
            else if (ch == 4) packet.Add((byte)0x33);
            else if (ch == 5) packet.Add((byte)0x34);
            else if (ch == 6) packet.Add((byte)0x35);
            else if (ch == 7) packet.Add((byte)0x36);
            else if (ch == 8) packet.Add((byte)0x37);
            else              packet.Add((byte)0x30);

            //　チェックサムの処理
            int sum = 0;
            for (int i = 0; i < 5; i++) sum += (int)packet[i];
            int chksum = sum % 256;

            packet.Add((byte)Func.int2asc(chksum >> 4));
            packet.Add((byte)Func.int2asc(chksum % 16));

            //　フッター
            packet.Add(0x04);

            return packet;
        }

        /// <summary>
        /// 関数：コマンドパケット作成
        /// </summary>

        public List<byte> DataPacket_create(byte cmd, List<byte> writedatas)
        {
            List<byte> packet = new List<byte>();

            // データサイズ
            int length = writedatas == null ? 0 : writedatas.Count;

            //　ヘッダー
            packet.Add(Common.g_SERIAL_sendSOH);

            //　データ長　(データ長+3)
            packet.Add((byte)(length + 3));

            //　コマンド(引数：cmd)
            packet.Add((byte)cmd);

            //　シーケンス
            packet.Add((byte)0xFF);

            //　データ部 
            if(writedatas != null) foreach (byte data in writedatas) packet.Add((byte)data);

            //　チェックサムの処理
            int sum = 0;
            for (int i = 0; i < packet.Count(); i++) sum += (int)packet[i];
            packet.Add((byte)(sum & 0xFF));

            return packet;
        }
    }
}
