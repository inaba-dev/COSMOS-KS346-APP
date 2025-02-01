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
    public partial class Form_spanconc : UserControl
    {
        public Form_spanconc()
        {
            InitializeComponent();
            comboBox_gas_8.Text = "1";
            numericUpDown_year_8.Value = DateTime.Today.Year % 100;
            numericUpDown_month_8.Value = DateTime.Today.Month;
            numericUpDown_day_8.Value = DateTime.Today.Day;
        }

        public bool data_check()
        {
            if (comboBox_gas_8.SelectedItem == null || textBox2byte_adjustfull.Text == "" || numericUpDown_year_8.Value.ToString() == "" || numericUpDown_month_8.Value.ToString() == "" || numericUpDown_day_8.Value.ToString() == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }

            return true;
        }

        public List<byte> spanadjustsetting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_8.SelectedItem.ToString());
            sendlist.Add((byte)Data0);

            ClassCreatePacket classCreatePacket = new ClassCreatePacket();
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox2byte_adjustfull.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox2byte_adjustfull.Text)[0]);

            int Data3 = int.Parse(numericUpDown_year_8.Value.ToString());
            sendlist.Add((byte)Data3);

            int Data4 = int.Parse(numericUpDown_month_8.Value.ToString());
            sendlist.Add((byte)Data4);

            int Data5 = int.Parse(numericUpDown_day_8.Value.ToString());
            sendlist.Add((byte)Data5);


            return sendlist;
        }


    }
}
