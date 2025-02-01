using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP
{
    public partial class Form_adjustresult : UserControl
    {
        public Form_adjustresult()
        {
            InitializeComponent();
            comboBox_gas_10.Text = "1";
        }

        public bool data_check()
        {
            if (comboBox_gas_10.SelectedItem == null || comboBox_adjustspecies.Text == "" || comboBox_concspecies.Text == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }

            return true;
        }

        public List<byte> gasadjustresult_setting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_10.SelectedItem.ToString());
            sendlist.Add((byte)Data0);

            switch (comboBox_adjustspecies.SelectedItem.ToString())
            {
                case "ベース調整":
                    sendlist.Add((byte)0x00);
                    break;
                case "スパン調整(調整ポイント1)":
                    sendlist.Add((byte)0x01);
                    break;
                case "スパン調整(調整ポイント2)":
                    sendlist.Add((byte)0x02);
                    break;
                case "スパン調整(調整ポイント3)":
                    sendlist.Add((byte)0x03);
                    break;
                case "スパン調整(調整ポイント4)":
                    sendlist.Add((byte)0x04);
                    break;
                case "スパン調整(調整ポイント5)":
                    sendlist.Add((byte)0x05);
                    break;
                case "スパン調整(調整ポイント6)":
                    sendlist.Add((byte)0x06);
                    break;
                case "スパン調整(調整ポイント7)":
                    sendlist.Add((byte)0x07);
                    break;
                case "スパン調整(調整ポイント8)":
                    sendlist.Add((byte)0x08);
                    break;
                case "スパン調整(濃度指定)":
                    sendlist.Add((byte)0x09);
                    break;
                case "予約":
                    sendlist.Add((byte)0xA);
                    break;
                case "エア調整(酸素23.0vol%)":
                    sendlist.Add((byte)0xB);
                    break;

            }


            switch (comboBox_concspecies.SelectedItem.ToString())
            {
                case "低濃度用調整値":
                    sendlist.Add((byte)0x00);
                    break;
                case "高濃度用調整値":
                    sendlist.Add((byte)0x01);
                    break;
            }

            return sendlist;

        }

        private void comboBox_adjustspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_adjustspecies.SelectedItem.ToString()== "エア調整(酸素23.0vol%)") 
            {
                comboBox_concspecies.SelectedIndex = 0;

                comboBox_concspecies.Enabled= false;
            }
            else comboBox_concspecies.Enabled = true;
        }
    }
}
