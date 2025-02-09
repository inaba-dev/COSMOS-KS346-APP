using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class FormMain
    {
        private string configfile = Define.defConfigFile;

        /// <summary>
        /// アプリケーションの設定をXMLファイルから取り込む
        /// </summary>
        protected void execLoadConfig()
        {
            try
            {
                //// ファイルが存在しているかどうか確認し、なければデフォルト値で作成する
                if (!System.IO.File.Exists(Define.defConfigFile))
                {
                    Common.Config = new ClassConfig();
                }
                else
                {
                    //// XmlSerializerオブジェクトの作成
                    System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(ClassConfig));
                    System.IO.StreamReader sr = new System.IO.StreamReader(Define.defConfigFile, new System.Text.UTF8Encoding(false));
                    Common.Config = (ClassConfig)serializer.Deserialize(sr);
                    sr.Close();
                }
            }
            catch
            {
                Common.Config = new ClassConfig();
            }

            //// フォームに設定

            setFormData();
        }

        /// <summary>
        /// アプリケーションの設定をXMLファイルに保存する
        /// </summary>
        protected void execSaveConfig()
        {
            //// ファイルが存在しているかどうか確認し、なければデフォルト値で作成する
            if (!System.IO.File.Exists(configfile))
            {
                configfile = Define.defConfigFile;
                Common.Config = new ClassConfig();
            }

            //// フォームから取得
            getFromData();

            //// XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(ClassConfig));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(configfile, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, Common.Config);
            sw.Close();

            ////
            execLoadConfig();
        }

        /// <summary>
        /// 
        /// </summary>

        private void setFormData()
        {
            CH1.checkValid.Checked = Common.Config.checkboxes[0];
            CH2.checkValid.Checked = Common.Config.checkboxes[1];
            CH3.checkValid.Checked = Common.Config.checkboxes[2];
            CH4.checkValid.Checked = Common.Config.checkboxes[3];
            CH5.checkValid.Checked = Common.Config.checkboxes[4];
            CH6.checkValid.Checked = Common.Config.checkboxes[5];
            CH7.checkValid.Checked = Common.Config.checkboxes[6];
            CH8.checkValid.Checked = Common.Config.checkboxes[7];

            numericInterval.Value = (decimal)Common.Config.interval;

            textBox_path.Text = Common.Config.folderpath;
    }

        /// <summary>
        /// 
        /// </summary>

        private void getFromData()
        {
            Common.Config.checkboxes[0] = CH1.checkValid.Checked;
            Common.Config.checkboxes[1] = CH2.checkValid.Checked;
            Common.Config.checkboxes[2] = CH3.checkValid.Checked;
            Common.Config.checkboxes[3] = CH4.checkValid.Checked;
            Common.Config.checkboxes[4] = CH5.checkValid.Checked;
            Common.Config.checkboxes[5] = CH6.checkValid.Checked;
            Common.Config.checkboxes[6] = CH7.checkValid.Checked;
            Common.Config.checkboxes[7] = CH8.checkValid.Checked;

            Common.Config.interval = (int)numericInterval.Value;

            Common.Config.folderpath = textBox_path.Text;
        }
    }
}
