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
    public partial class Form_spancurt : UserControl
    {
        public Form_spancurt()
        {
            InitializeComponent();
            comboBox_gas_6.Text = "1";
            numericUpDown_year_6.Value = DateTime.Today.Year % 100;
            numericUpDown_month_6.Value = DateTime.Today.Month;
            numericUpDown_day_6.Value = DateTime.Today.Day;
        }

        
        public bool data_check()
        {
            if (comboBox_gas_6.SelectedItem == null || comboBox_adjustpoint_6.SelectedItem == null || numericUpDown_year_6.Value.ToString() == "" || numericUpDown_month_6.Value.ToString() == "" || numericUpDown_day_6.Value.ToString() == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }

            return true;
        }

        public List<byte> spannowsetting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_6.SelectedItem.ToString());
            sendlist.Add((byte)Data0);

            int Data1 = int.Parse(comboBox_adjustpoint_6.SelectedItem.ToString());
            sendlist.Add((byte)Data1);

            int Data2 = int.Parse(numericUpDown_year_6.Value.ToString());
            sendlist.Add((byte)Data2);

            int Data3 = int.Parse(numericUpDown_month_6.Value.ToString());
            sendlist.Add((byte)Data3);

            int Data4 = int.Parse(numericUpDown_day_6.Value.ToString());
            sendlist.Add((byte)Data4);

            return sendlist;
        }

    }
}
