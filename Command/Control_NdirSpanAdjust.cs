﻿using MathNet.Numerics.Distributions;
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

    public class ClassNdirSpanAdjust
    {

    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirSpanAdjust
    {
        /// <summary>
        /// ログ出力変換
        /// </summary>

        public List<string> Output(List<byte> datas)
        {
            List<string> sensordata = new List<string>();

            return sensordata;
        }

        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirSpanAdjust Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 35) return null;

            ClassNdirSpanAdjust param = new ClassNdirSpanAdjust();

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirSpanAdjust param)
        {
            List<byte> sendlist = new List<byte>();

            return sendlist;
        }
    }
}
