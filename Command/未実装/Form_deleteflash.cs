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
    public partial class Form_deleteflash : UserControl
    {
        public Form_deleteflash()
        {
            InitializeComponent();
        }

        public List<byte> deletedataflashsetting()
        {
            List<byte> sendlist = new List<byte>();


            string[] datas = new string[4];
            if (checkBox_area1.Checked == true) datas[0] = "1";
            else datas[0] = "0";
            if (checkBox_area2.Checked == true) datas[1] = "1";
            else datas[1] = "0";
            if (checkBox_area3.Checked == true) datas[2] = "1";
            else datas[2] = "0";
            if (checkBox_area4.Checked == true) datas[3] = "1";
            else datas[3] = "0";


            string Data = "0000" + datas[3] + datas[2] + datas[1] + datas[0];
            int _Data = Convert.ToInt32(Data, 2);
            sendlist.Add((byte)_Data);

            return sendlist;
        }
    }
}
