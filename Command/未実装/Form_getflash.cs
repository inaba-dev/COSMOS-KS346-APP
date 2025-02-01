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
    public partial class Form_getflash : UserControl
    {
        public Form_getflash()
        {
            InitializeComponent();
        }


        public bool data_check()
        {
            if (textBox1byte_area.Text == "" || textBoxadress_startadress.Text == "" || comboBox_byte.SelectedItem == null)
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> getdataflashsetting()
        {
            List<byte> sendlist = new List<byte>();


            int Data0 = int.Parse(textBox1byte_area.Text);
            sendlist.Add((byte)Data0);

            ClassCreatePacket classCreatePacket = new ClassCreatePacket();
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBoxadress_startadress.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBoxadress_startadress.Text)[0]);

            int Data3 = int.Parse(comboBox_byte.SelectedItem.ToString());
            sendlist.Add((byte)Data3);

            return sendlist;
        }







        private void textBox1byte_area_TextChanged(object sender, EventArgs e)
        {
            if (textBox1byte_area.Text == "")
            {
                label_15_areahex.Text = "(0x)";
                return;
            }
            int num = Convert.ToInt32(textBox1byte_area.Text);

            label_15_areahex.Text = "(0x" + num.ToString("X") + ")";
        }

        private void textBoxadress_startadress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxadress_startadress.Text == "")
            {
                label_15_starthex.Text = "(0x)";
                return;
            }
            int num = Convert.ToInt32(textBoxadress_startadress.Text);

            label_15_starthex.Text = "(0x" + num.ToString("X") + ")";
        }
    }
}
