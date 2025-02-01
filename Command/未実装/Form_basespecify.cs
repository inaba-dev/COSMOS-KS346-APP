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
    public partial class Form_basespecify : UserControl
    {
        public Form_basespecify()
        {
            InitializeComponent();
            comboBox_gas_5.Text = "1";
            numericUpDown_year_5.Value = DateTime.Today.Year % 100;
            numericUpDown_month_5.Value = DateTime.Today.Month;
            numericUpDown_day_5.Value = DateTime.Today.Day;
        }

        public bool data_check()
        {
            if (comboBox_gas_5.SelectedItem == null || numericUpDown_year_5.Value.ToString() == "" || numericUpDown_month_5.Value.ToString() == "" || numericUpDown_day_5.Value.ToString() == "" || textBox_lowAD_5.Text == "" || textBox_highAD_5.Text == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> basespecifysetting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_5.SelectedItem.ToString());
            sendlist.Add((byte)Data0);


            int Data1 = int.Parse(numericUpDown_year_5.Value.ToString());
            sendlist.Add((byte)Data1);

            int Data2 = int.Parse(numericUpDown_month_5.Value.ToString());
            sendlist.Add((byte)Data2);

            int Data3 = int.Parse(numericUpDown_day_5.Value.ToString());
            sendlist.Add((byte)Data3);

            ClassCreatePacket classCreatePacket = new ClassCreatePacket();
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_lowAD_5.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_lowAD_5.Text)[0]);

            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_highAD_5.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_highAD_5.Text)[0]);

            return sendlist;
        }
    }
}
