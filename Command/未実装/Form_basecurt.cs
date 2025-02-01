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
    public partial class Form_basecurt : UserControl
    {
        public Form_basecurt()
        {
            InitializeComponent();
            comboBox_gas_4.Text = "1";
            numericUpDown_year_4.Value = DateTime.Today.Year % 100;
            numericUpDown_month_4.Value = DateTime.Today.Month;
            numericUpDown_day_4.Value = DateTime.Today.Day;

        }

        public bool data_check()
        {
            if (comboBox_gas_4.SelectedItem == null || numericUpDown_year_4.Value.ToString() == "" || numericUpDown_month_4.Value.ToString() == "" || numericUpDown_day_4.Value.ToString() == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> basenowsetting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_4.SelectedItem.ToString());
            sendlist.Add((byte)Data0);


            int Data1 = int.Parse(numericUpDown_year_4.Value.ToString());
            sendlist.Add((byte)Data1);

            int Data2 = int.Parse(numericUpDown_month_4.Value.ToString());
            sendlist.Add((byte)Data2);

            int Data3 = int.Parse(numericUpDown_day_4.Value.ToString());
            sendlist.Add((byte)Data3);

            return sendlist;
        }
    }
}
