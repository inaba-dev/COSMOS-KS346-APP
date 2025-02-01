using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Form_peak : UserControl
    {
        public Form_peak()
        {
            InitializeComponent();
        }

        public bool data_check()
        {
            if (comboBox_detect.SelectedItem == null || comboBox_peak.SelectedItem == null)
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> peakdetectstartsetting()
        {
            List<byte> sendlist = new List<byte>();

            switch (comboBox_detect.SelectedItem.ToString())
            {
                case "検出開始条件なし":
                    sendlist.Add((byte)0x00);
                    break;
                case "センサ出力(規定値以下で検出開始)":
                    sendlist.Add((byte)0x01);
                    break;
                case "センサ出力(規定値以上で検出開始)":
                    sendlist.Add((byte)0x02);
                    break;
            }

            switch (comboBox_peak.SelectedItem.ToString())
            {
                case "最大値":
                    sendlist.Add((byte)0x00);
                    break;
                case "最小値":
                    sendlist.Add((byte)0x01);
                    break;
            }

            return sendlist;
        }
    }
}
