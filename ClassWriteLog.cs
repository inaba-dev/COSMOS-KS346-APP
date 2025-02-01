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
        /// 関数：接続開始メッセージ
        /// </summary>
        
        public static string Start_Log(int CH)
        {
            string Result = "/////////////////////////////////////////////////////" + Environment.NewLine
                          + "# 選択CH  ：" + CH + Environment.NewLine
                          + "# 作業内容：" + Common.Config.config.funcstring + Environment.NewLine
                          + "# 作業開始：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            return Result;
        }

        /// <summary>
        /// 関数：接続終了メッセージ
        /// </summary>
        
        public static string Finish_Log(string result)
        {
            string Result = "# 作業結果：" + result;
            return Result;
        }
    }
}
