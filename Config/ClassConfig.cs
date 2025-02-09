using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// XML形式で外部保存するデータクラス
    /// </summary>

    public class ClassConfig
    {
        public bool[] checkboxes = new bool[8];

        public int interval { get; set; }

        public string folderpath { get; set; }

        /// 初期化

        public ClassConfig()
        {
            checkboxes = (Enumerable.Range(0, 8).Select(x => false).ToArray());
            interval = 1;
        }
    }
}
