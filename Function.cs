using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;

namespace APP
{
    public static class Func
    {
        /// <summary>
        /// 関数：送信ボタンの色制御
        /// </summary>

        public static void sendbutton_Color_control(System.Windows.Forms.Button button, bool result)
        {
            button.Enabled = result;
            button.BackColor = result ? Color.Turquoise : Color.DarkGray;
        }

        /// <summary>
        /// 関数：テキストボックスのバリデーションチェック
        /// </summary>

        public static bool validate_text(string msg, System.Windows.Forms.TextBox form)
        {
            if (form.Text == "" || form.Text == null)
            {
                ClassMessageBox.textbox_ErrorMessage(msg);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 関数：セレクトボックスのバリデーションチェック
        /// </summary>

        public static bool validate_select(string msg, System.Windows.Forms.ComboBox form)
        {
            if (form.SelectedIndex == -1)
            {
                ClassMessageBox.combobox_ErrorMessage(msg);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>

        public static int int2asc(int src)
        {
            if (src < 10) return (src + 0x30);
            else if (src < 16) return ((src - 10) + 0x41);
            else return 0;
        }

        public static int asc2int(int src)
        {
            if (src > 0x40) return (src - 0x41 + 10);
            else if (src >= 0x30) return (src - 0x30);
            else return 0;
        }

        /// <summary>
        /// 関数：2バイトを10進数に変換
        /// </summary>

        public static UInt16 combine_2byte(byte data1, byte data2)
        {
            // 文字列を2進数に変換
            string binaryStr1 = Convert.ToString(int.Parse(data1.ToString()), 2);
            string binaryStr2 = Convert.ToString(int.Parse(data2.ToString()), 2);

            // 左側に0を詰める
            binaryStr1 = binaryStr1.PadLeft(8, '0');
            binaryStr2 = binaryStr2.PadLeft(8, '0');

            // 2進数を結合
            string combinedBinary = binaryStr1 + binaryStr2;

            // 結合した2進数を10進数に変換
            UInt16 result = Convert.ToUInt16(combinedBinary, 2);

            return result;
        }

        /// <summary>
        /// 関数：2バイトを10進数に変換(符号あり)
        /// </summary>

        public static int signcombine_2byte(byte data1, byte data2)
        {
            // 文字列を2進数に変換
            string binaryStr1 = Convert.ToString(int.Parse(data1.ToString()), 2);
            string binaryStr2 = Convert.ToString(int.Parse(data2.ToString()), 2);

            // 左側に0を詰める
            binaryStr1 = binaryStr1.PadLeft(8, '0');
            binaryStr2 = binaryStr2.PadLeft(8, '0');

            // 2進数を結合
            string combinedBinary = binaryStr1 + binaryStr2;

            // 結合した2進数を10進数に変換
            int result = Convert.ToInt32(combinedBinary, 2);

            return result;
        }

        /// <summary>
        /// 関数：4バイトを10進数に変換(符号なし)
        /// </summary>

        public static uint combine_4byte(byte data1, byte data2, byte data3, byte data4)
        {
            // 文字列を2進数に変換
            string binaryStr1 = Convert.ToString(int.Parse(data1.ToString()), 2);
            string binaryStr2 = Convert.ToString(int.Parse(data2.ToString()), 2);
            string binaryStr3 = Convert.ToString(int.Parse(data3.ToString()), 2);
            string binaryStr4 = Convert.ToString(int.Parse(data4.ToString()), 2);

            // 左側に0を詰める
            binaryStr1 = binaryStr1.PadLeft(8, '0');
            binaryStr2 = binaryStr2.PadLeft(8, '0');
            binaryStr3 = binaryStr3.PadLeft(8, '0');
            binaryStr4 = binaryStr4.PadLeft(8, '0');

            // 2進数を結合
            string combinedBinary = binaryStr1 + binaryStr2 + binaryStr3 + binaryStr4;

            // 結合した2進数を10進数に変換
            uint result = Convert.ToUInt32(combinedBinary, 2);

            return result;
        }

        /// <summary>
        /// 関数：4バイトを10進数に変換(符号あり)
        /// </summary>

        public static int signcombine_4byte(byte data1, byte data2, byte data3, byte data4)
        {
            // 文字列を2進数に変換
            string binaryStr1 = Convert.ToString(int.Parse(data1.ToString()), 2);
            string binaryStr2 = Convert.ToString(int.Parse(data2.ToString()), 2);
            string binaryStr3 = Convert.ToString(int.Parse(data3.ToString()), 2);
            string binaryStr4 = Convert.ToString(int.Parse(data4.ToString()), 2);

            // 左側に0を詰める
            binaryStr1 = binaryStr1.PadLeft(8, '0');
            binaryStr2 = binaryStr2.PadLeft(8, '0');
            binaryStr3 = binaryStr3.PadLeft(8, '0');
            binaryStr4 = binaryStr4.PadLeft(8, '0');

            // 2進数を結合
            string combinedBinary = binaryStr1 + binaryStr2 + binaryStr3 + binaryStr4;

            // 結合した2進数を10進数に変換
            int result = Convert.ToInt32(combinedBinary, 2);

            return result;
        }

        /// <summary>
        /// 関数：2バイトに変換
        /// </summary>

        public static byte[] Change_2bytes(string data)
        {
            //　string型をint型に変換
            if (int.TryParse(data, out int value))
            {
                ushort shortvalue = (ushort)value; //16ビットで表現
                byte[] bytesArray = BitConverter.GetBytes(shortvalue);
                return bytesArray;
            }
            else return null;
        }

        /// <summary>
        /// 4バイトに変換
        /// </summary>

        public static byte[] Change_4bytes(string data)
        {
            //　string型をuint型に変換
            if (uint.TryParse(data, out uint value))
            {
                uint shortvalue = (uint)value; //32ビットで表現
                byte[] bytesArray = BitConverter.GetBytes(shortvalue);
                return bytesArray;
            }
            else return null;
        }
    }
}
