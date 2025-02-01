using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class Define
    {
        /// <summary>
        /// 全般設定
        /// <summary>

        public enum StatusResponse : int
        {
            FatalError = -1, // 致命的なエラー(強制終了)
            Failure = 0,     // 失敗
            Success = 1      // 成功
        };

        public enum FileResponse : int
        {
            FatalError = 0,
            OpenError = -1,
            Success = 1
        };

        //　リトライ回数
        public static int defRetry = 2;

        /// <summary>
        /// フォルダ設定
        /// <summary>

        public static readonly string defAppFolder = Directory.GetCurrentDirectory();

        //
        public static readonly string defConfigFile = Define.defAppFolder + @"\" + "config.xml";
    }
}
