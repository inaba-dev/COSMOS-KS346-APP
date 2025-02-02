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

    public class ClassNdirZeroAdjust
    {

    }

    /// <summary>
    /// 
    /// </summary>

    public class Control_NdirZeroAdjust
    {
        /// <summary>
        /// 受信データ解析
        /// </summary>

        public ClassNdirZeroAdjust Parse(List<byte> datas)
        {
            if (datas == null || datas.Count < 35) return null;

            ClassNdirZeroAdjust param = new ClassNdirZeroAdjust();

            return param;
        }

        /// <summary>
        /// 送信データ生成
        /// </summary>

        public List<byte> CreatePacket(ClassNdirZeroAdjust param)
        {
            List<byte> sendlist = new List<byte>();

            return sendlist;
        }
    }
}
