﻿using System;
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
    public partial class Form_spanspecify : UserControl
    {
        public Form_spanspecify()
        {
            InitializeComponent();
            comboBox_gas_7.Text = "1";
            numericUpDown_year_7.Value = DateTime.Today.Year % 100;
            numericUpDown_month_7.Value = DateTime.Today.Month;
            numericUpDown_day_7.Value = DateTime.Today.Day;
        }

        public bool data_check()
        {
            if (comboBox_gas_7.SelectedItem == null || comboBox_adjustpoint_7.SelectedItem == null || numericUpDown_year_7.Value.ToString() == "" || numericUpDown_month_7.Value.ToString() == "" || numericUpDown_day_7.Value.ToString() == "" || textBox_lowAD_7.Text == "" || textBox_highAD_7.Text == "")
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> spanspecifysetting()
        {
            List<byte> sendlist = new List<byte>();

            int Data0 = int.Parse(comboBox_gas_7.SelectedItem.ToString());
            sendlist.Add((byte)Data0);

            int Data1 = int.Parse(comboBox_adjustpoint_7.SelectedItem.ToString());
            sendlist.Add((byte)Data1);

            int Data2 = int.Parse(numericUpDown_year_7.Value.ToString());
            sendlist.Add((byte)Data2);

            int Data3 = int.Parse(numericUpDown_month_7.Value.ToString());
            sendlist.Add((byte)Data3);

            int Data4 = int.Parse(numericUpDown_day_7.Value.ToString());
            sendlist.Add((byte)Data4);

            ClassCreatePacket classCreatePacket = new ClassCreatePacket();
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_lowAD_7.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_lowAD_7.Text)[0]);

            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_highAD_7.Text)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(textBox_highAD_7.Text)[0]);

            return sendlist;
        }
    }
}
