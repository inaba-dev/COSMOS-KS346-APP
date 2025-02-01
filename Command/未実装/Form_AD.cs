using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace APP
{
    public partial class Form_AD : UserControl
    {
       
        public Form_AD()
        {
            InitializeComponent();

        }



        public void sendbutton_Color_control(bool result)
        {
            button_send.Enabled = result;
            button_send.BackColor = result ? Color.Turquoise : Color.DarkGray;
        }


        private async void button_send_Click(object sender, EventArgs e)
        {
            if (checkBox_cont.Checked && comboBox_Cycle.SelectedIndex == -1)
            {
                ClassMessageBox.selectCycle_ErrorMessage();
                return;
            }

            FormMaincmd formMainWritecmd=new FormMaincmd();

            ClassGetcmddatas classGetcmddatas = new ClassGetcmddatas();

            if (!formMainWritecmd.prepare_proc("AD値取得")) return;

            //　連続にチェックが入っているとき
            if (checkBox_cont.Checked)
            {
                FormMain.Formmain.groupBox_cmd_control(true);
                button_send.Enabled=false;
                formMainWritecmd.ComboBox_cmd.Enabled=false;
                checkBox_cont.Enabled=false;
                comboBox_Cycle.Enabled=false;
                stopbutton_control(true);
            }

            int count = 1;

            while (true)
            {
                int ch = 1;
                foreach (bool result in FormMain.Formmain.g_ClassControlcmd.g_checkboxes)
                {
                    if (result)
                    {
                        if (stop == true)
                        {
                            formMainWritecmd.WriteLF("////【強制停止】////");

                            //　停止ボタンのみ操作不可                  
                            button_send.Enabled = true;
                            formMainWritecmd.ComboBox_cmd.Enabled = true;
                            checkBox_cont.Enabled = true;
                            comboBox_Cycle.Enabled = true;
                            stopbutton_control(false);
                            FormMain.Formmain.finish_proc();

                            stop = false;
                            return;
                        }


                        formMainWritecmd.WriteLF(ClassWriteLog.Start_Log(ch));

                        List<byte> Selectpacket = FormMain.Formmain.g_ClassControlcmd.selectpacket_get();

                        //List<byte> receivedatas = await Task.Run(() => FormMain.Formmain.g_ClassControlcmd.Exec_ReadNocmdDatas((byte)0xC3, 16, Selectpacket));
                        List<byte> receivedatas = await Task.Run(() => FormMain.Formmain.g_ClassControlcmd.Exec_ReadNocmdDatas((byte)0xC3, 14, Selectpacket));
                        if (receivedatas == null || receivedatas.Count() == 0)
                        {
                            formMainWritecmd.WriteLF("///AD値取得：応答なし///");
                            formMainWritecmd.label_proc(ch, "NG", "AD値取得失敗");
                            formMainWritecmd.WriteLF(ClassWriteLog.finish_Log("AD値取得失敗"));
                            ch++;
                            continue;
                        }
                        string response = FormMain.Formmain.g_ClassControlcmd.Response_Data(receivedatas[4]);
                        formMainWritecmd.WriteLF("///AD値取得：" + response + "///");
                        if (response != "OK")
                        {
                            formMainWritecmd.label_proc(ch, "NG", "AD値取得失敗");
                            formMainWritecmd.WriteLF(ClassWriteLog.finish_Log("AD値取得失敗"));
                            ch++;
                            continue;
                        }

                        formMainWritecmd.label_proc(ch, "OK", "AD値取得成功");
                        List<string> datas = classGetcmddatas.get_ADdatas(receivedatas);
                        foreach (string data in datas) formMainWritecmd.WriteLF(data);

                        formMainWritecmd.WriteLF(ClassWriteLog.finish_Log("AD値取得成功"));

                        if (stop == true)
                        {
                            formMainWritecmd.WriteLF("////【強制停止】////");

                            //　停止ボタンのみ操作不可                  
                            button_send.Enabled = true;
                            formMainWritecmd.ComboBox_cmd.Enabled = true;
                            checkBox_cont.Enabled = true;
                            comboBox_Cycle.Enabled = true;
                            stopbutton_control(false);
                            FormMain.Formmain.finish_proc();


                            stop = false;
                            return;
                        }
                    }
                    ch++;



                }

                //　連続ボタン押されていなかったら処理終了
                if (!checkBox_cont.Checked)
                {
                    FormMain.Formmain.finish_proc();
                    return;
                }

                int _data = Int32.Parse(comboBox_Cycle.SelectedItem.ToString());

                _cancellationTokenSource = new CancellationTokenSource();

                try
                {
                    //　周期
                    await Task.Delay(_data * 1000, _cancellationTokenSource.Token);
                }
                catch (TaskCanceledException)
                {
                    formMainWritecmd.WriteLF("////【強制停止】////");

                    //　停止ボタンのみ操作不可                  
                    button_send.Enabled = true;
                    formMainWritecmd.ComboBox_cmd.Enabled = true;
                    checkBox_cont.Enabled = true;
                    comboBox_Cycle.Enabled = true;
                    stopbutton_control(false);
                    FormMain.Formmain.finish_proc();


                    stop = false;
                    return;
                }
                formMainWritecmd.WriteLF("////【" + count + "周目終了】////");
                FormMain.Formmain.checkboxes_get();
                count++;
            }


        }

        private bool stop = false;
        private CancellationTokenSource _cancellationTokenSource;

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            stop = true;

            _cancellationTokenSource?.Cancel();
        }

        private void checkBox_cont_CheckedChanged(object sender, EventArgs e)
        {
                        if (checkBox_cont.Checked == false)
            {
                comboBox_Cycle.Enabled = false;
                comboBox_Cycle.SelectedItem = null;
            }
            else comboBox_Cycle.Enabled = true;
        }

        public void stopbutton_control(bool result)
        {
            button_stop.Enabled = result;
            button_stop.BackColor = result ? Color.Tomato : Color.DarkGray;
            button_stop.Font = result ? new Font("Meiryo", 10, FontStyle.Bold) : new Font("Meiryo", 10, FontStyle.Regular);

        }
    }
}
