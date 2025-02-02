using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public class ClassWriteLog
    {
        /// <summary>
        /// 関数：接続終了メッセージ
        /// </summary>
        
        public static string Finish_Log(int CH, string result)
        {
            string Result = "# (CH:" + CH + ")  " + result;
            return Result;
        }
    }
}
