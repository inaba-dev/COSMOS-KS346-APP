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
    public partial class Form_sensorDL : UserControl
    {
        public Form_sensorDL()
        {
            InitializeComponent();

            numericUpDown_year_change_1.Value = DateTime.Today.Year % 100;
            numericUpDown_year_proof_1.Value = DateTime.Today.Year % 100;

            numericUpDown_month_change_1.Value = DateTime.Today.Month;
            numericUpDown_month_proof_1.Value = DateTime.Today.Month;

            numericUpDown_day_change_1.Value = DateTime.Today.Day;
            numericUpDown_day_proof_1.Value = DateTime.Today.Day;
        }

        public bool data_check()
        {
            if ( (textBox2byte_changeinterval.Enabled&& textBox2byte_changeinterval.Text == "") || (textBox2byte_proofinterval.Enabled && textBox2byte_proofinterval.Text == "") )
            {
                ClassMessageBox.setting_ErrorMessage();
                return false;
            }
            return true;
        }

        public List<byte> sensordeadlinesetting()
        {
            List<byte> sendlist = new List<byte>();

            string[] datas = new string[4];
            if (checkBox_changeinterval.Checked == true) datas[0] = "1";
            else datas[0] = "0";
            if (checkBox_changeday.Checked == true) datas[1] = "1";
            else datas[1] = "0";
            if (checkBox_proofinterval.Checked == true) datas[2] = "1";
            else datas[2] = "0";
            if (checkBox_proofday.Checked == true) datas[3] = "1";
            else datas[3] = "0";

            string setting = "0000" + datas[3] + datas[2] + datas[1] + datas[0];
            int hexvalue_setting = Convert.ToInt32(setting, 2);
            sendlist.Add((byte)hexvalue_setting);



            ClassCreatePacket classCreatePacket = new ClassCreatePacket();
            string changeinterval = textBox2byte_changeinterval.Text;
            if (changeinterval == "") changeinterval = "0";
            sendlist.Add((byte)classCreatePacket.Change_2bytes(changeinterval)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(changeinterval)[0]);

            int changeyear = int.Parse(numericUpDown_year_change_1.Value.ToString());
            sendlist.Add((byte)changeyear);

            int changemonth = int.Parse(numericUpDown_month_change_1.Value.ToString());
            sendlist.Add((byte)changemonth);

            int changeday = int.Parse(numericUpDown_day_change_1.Value.ToString());
            sendlist.Add((byte)changeday);

            string proofinterval = textBox2byte_proofinterval.Text;
            if (proofinterval == "") proofinterval = "0";
            sendlist.Add((byte)classCreatePacket.Change_2bytes(proofinterval)[1]);
            sendlist.Add((byte)classCreatePacket.Change_2bytes(proofinterval)[0]);

            int proofyear = int.Parse(numericUpDown_year_proof_1.Value.ToString());
            sendlist.Add((byte)proofyear);

            int proofmonth = int.Parse(numericUpDown_month_proof_1.Value.ToString());
            sendlist.Add((byte)proofmonth);

            int proofday = int.Parse(numericUpDown_day_proof_1.Value.ToString());
            sendlist.Add((byte)proofday);

            return sendlist;

        }

        private void checkBox_changeinterval_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_changeinterval.Checked)
            textBox2byte_changeinterval.Enabled = true;
            else textBox2byte_changeinterval.Enabled = false;
        }

        private void checkBox_changeday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_changeday.Checked) 
            {
                numericUpDown_year_change_1.Enabled = true;
                numericUpDown_month_change_1.Enabled=true;
                numericUpDown_day_change_1.Enabled = true;
            }
            else 
            {
                numericUpDown_year_change_1.Enabled = false;
                numericUpDown_month_change_1.Enabled = false;
                numericUpDown_day_change_1.Enabled = false;
            }
        }

        private void checkBox_proofinterval_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_proofinterval.Checked) 
            {
                textBox2byte_proofinterval.Enabled = true;
            }
            else 
            {
                textBox2byte_proofinterval.Enabled = false;
            }
                
        }

        private void checkBox_proofday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_proofday.Checked) 
            {
                numericUpDown_year_proof_1.Enabled = true;
                numericUpDown_month_proof_1.Enabled=true;
                numericUpDown_day_proof_1.Enabled = true;
            }
            else
            {
                numericUpDown_year_proof_1.Enabled = false;
                numericUpDown_month_proof_1.Enabled = false;
                numericUpDown_day_proof_1.Enabled = false;
            }
        }
    }
}
