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
    public class ClassSensorDebug
    {
        Random rnd = new Random();

        public List<byte> RecievePacket(byte cmd)
        {
            List<byte> packet = new List<byte>();

            switch (cmd)
            {
                /// NDIRセンサ情報取得

                case (byte)0x40:

                    packet.Add(0xC0);
                    packet.Add(0x10);
                    packet.Add(0x40);
                    packet.Add(0xFF);
                    packet.Add(0x00);
                    packet.Add(0x21);
                    packet.Add(0x01);
                    packet.Add(0x00);
                    packet.Add(0x90);
                    packet.Add(0x80);
                    packet.Add(0xD4);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    break;

                /// NDIRセンサ状態取得

                case (byte)0x41:

                    int value = rnd.Next(0, 40000);
                    byte[] data = Func.Change_4bytes(value.ToString());

                    packet.Add(0xC0);
                    packet.Add(0x0F);
                    packet.Add(0x41);
                    packet.Add(0xFF);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x04);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(data[3]);
                    packet.Add(data[2]);
                    packet.Add(data[1]);
                    packet.Add(data[0]);
                    packet.Add(0x00);
                    packet.Add(0x00);
                    packet.Add(0x55);
                    break;

                /// NDIRセンサバージョン取得

                case (byte)0x49:

                    packet.Add(0xC0);
                    packet.Add(0x07);
                    packet.Add(0x49);
                    packet.Add(0xFF);
                    packet.Add(0x00);
                    packet.Add(0x01);
                    packet.Add(0x00);
                    packet.Add(0x0B);
                    break;

                default:
                    break;
            }

            /// Check Sum
            int sum = 0;
            for (int i = 0; i < packet.Count(); i++) sum += (int)packet[i];
            packet.Add((byte)(sum & 0xFF));

            return packet;
        }
    }
}
