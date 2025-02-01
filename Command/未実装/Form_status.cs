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
    public partial class Form_status : UserControl
    {
        public Form_status()
        {
            InitializeComponent();
        }

        public List<byte> statussetting()
        {
            List<byte> sendlist = new List<byte>();

            if (checkBox_temp.Checked == true) sendlist.Add((byte)255);
            else 
            {
                int Data0 = int.Parse((numericUpDown_temp.Value + 60).ToString());
                sendlist.Add((byte)Data0);
            }

            if (checkBox_hum.Checked == true) sendlist.Add((byte)255);
            else 
            {
                int Data1 = int.Parse(numericUpDown_hum.Value.ToString());
                sendlist.Add((byte)Data1);
            }
           



            return sendlist;
        }

        private void checkBox_temp_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_temp.Checked==true)
            numericUpDown_temp.Enabled= false;
            else numericUpDown_temp.Enabled= true;
        }

        private void checkBox_hum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hum.Checked == true)
                numericUpDown_hum.Enabled= false;
            else numericUpDown_hum.Enabled = true;
        }
    }
}
