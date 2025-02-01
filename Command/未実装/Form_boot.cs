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
    public partial class Form_boot : UserControl
    {
        public Form_boot()
        {
            InitializeComponent();
        }

        public bool data_check()
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false) 
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }

            /*
            if (comboBox_Warmup.SelectedItem == null)
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            */
            return true;
        }

        /*
        public List<byte> setupsetting()
        {
            List<byte> sendlist = new List<byte>();

            switch (comboBox_Warmup.SelectedItem.ToString())
            {
                case "暖機処理あり":
                    sendlist.Add((byte)0x00);
                    break;
                case "暖機処理なし":
                    sendlist.Add((byte)0x01);
                    break;
                case "暖機処理なし、前回の値でゼロ調整":
                    sendlist.Add((byte)0x02);
                    break;
            }


            return sendlist;
        }
        */

        public List<byte> setupsetting()
        {
            List<byte> sendlist = new List<byte>();

            if (radioButton1.Checked == true) sendlist.Add((byte)0x00);
            else if (radioButton2.Checked == true) sendlist.Add((byte)0x01);
            else if (radioButton3.Checked == true) sendlist.Add((byte)0x02);
            
            return sendlist;

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }
    }
}
