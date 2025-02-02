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
        public string[] serialnumbers = new string[8];

        /// 初期化

        public ClassConfig()
        {

        }
    }

    public class ControlConfig
    {
        public ClassConfig config = new ClassConfig();

        /// <summary>
        /// アプリケーションの設定をXMLファイルから取り込む
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                //// ファイルが存在しているかどうか確認し、なければデフォルト値で作成する
                if (!System.IO.File.Exists(Define.defConfigFile))
                {
                    config = new ClassConfig();
                }
                else
                {
                    //// XmlSerializerオブジェクトの作成
                    System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(ClassConfig));
                    System.IO.StreamReader sr = new System.IO.StreamReader(Define.defConfigFile, new System.Text.UTF8Encoding(false));
                    config = (ClassConfig)serializer.Deserialize(sr);
                    sr.Close();
                }
            }
            catch
            {
                config = new ClassConfig();
            }

            //// フォームに設定

            setFormData();
        }

        /// <summary>
        /// アプリケーションの設定をXMLファイルに保存する
        /// </summary>
        public void SaveConfig()
        {
            //// フォームから取得
            getFromData();

            //// XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(ClassConfig));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Define.defConfigFile, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, config);
            sw.Close();

            ////
            LoadConfig();
        }

        /// <summary>
        /// 
        /// </summary>

        private void setFormData()
        {

        }

        /// <summary>
        /// 
        /// </summary>

        private void getFromData()
        {

        }
    }
}
