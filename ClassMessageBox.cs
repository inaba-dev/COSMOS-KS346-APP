using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public class ClassMessageBox
    {
        public static void csv_ErrorMessage()
        {
            MessageBox.Show("DBファイルが開かれています。\n" + "「設定画面」から設定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void deffile_NotExistMessage()
        {
            MessageBox.Show("DBファイルが存在しませんでした。\n" + "「設定画面」から設定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void deffile_NotExist_stopchartMessage()
        {
            MessageBox.Show("DBファイルが存在しませんでした。\n" + "連続読み出しを停止します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string connect_ErrorLog()
        {
            connect_ErrorMessage();

            string Result = "////【シリアルポート接続失敗】////" + Environment.NewLine
                               + "# 作業結果：" + "シリアルポート接続に失敗しました。" /*+ Environment.NewLine
                               + "# 作業終了：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")*/;

            return Result;
        }

        public static void character_ErrorMessage() 
        {
            MessageBox.Show("意図しない文字が含まれているため、貼り付けできません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void com_ErrorMessage()
        {
            MessageBox.Show("「COM番号」が選択されていません。\n" + "選択後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void CH_ErrorMessage()
        {
            MessageBox.Show("「CH」が選択されていません。\n" + "選択後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Cmd_ErrorMessage()
        {
            MessageBox.Show("「コマンド」が選択されていません。\n" + "選択後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void byte4_ErrorMessage()
        {
            MessageBox.Show("値が”4,294,967,295”より大きいため、貼り付けできません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void byte2_ErrorMessage()
        {
            MessageBox.Show("値が”65,535”より大きいため、貼り付けできません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void byte1_ErrorMessage()
        {
            MessageBox.Show("値が”255”より大きいため、貼り付けできません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void auto_ErrorMessage(int ch)
        {
            MessageBox.Show(ch+"CH以降の連番が「99999」を超えたため自動入力できません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void format_ErrorMessage() 
        {
            MessageBox.Show("DBファイルの中身がフォーマットに沿っていません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Format_ErrorMessage()
        {
            MessageBox.Show("DBファイルの中身に空欄箇所がございます。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void load_SuccessMessage() 
        {
            MessageBox.Show("読み込み成功しました。", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void gastype_ErrorMessage()
        {
            MessageBox.Show("「ガス種」が選択されていません。\n" + "選択後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void connect_ErrorMessage() 
        {
            MessageBox.Show("シリアルポート接続に失敗しました。\n"+"PCに接続されていることを確認してから再度実行してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void saveLog__ErrorMessage()
        {
            MessageBox.Show("「製造番号」「ガス情報」「調整情報」「警報情報」のいずれかにチェックをいれてから、実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void saveLog__SuccessMessage() 
        {
            MessageBox.Show("保存成功しました。", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void savepath_ErrorMessage() 
        {
            MessageBox.Show("保存先が設定されていません。\n" + "左上の「設定」から設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void filename_ErrorMessage() 
        {
            MessageBox.Show("ファイル名が設定されていません。\n" + "左上の「設定」から設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void selectCycle_ErrorMessage()
        {
            MessageBox.Show("「周期」が選択されていません。\n" + "選択後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void updatepath_ErrorMessage()
        {
            MessageBox.Show("「ファイル」が設定されていません。\n" + "設定後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void exist_boot()
        {
            MessageBox.Show("設定した場所にブート領域ファイルが存在しません。\n" + "再度、設定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void exist_appli()
        {
            MessageBox.Show("設定した場所にアプリ領域ファイルが存在しません。\n" + "再度、設定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void openfile_ErrorMessage()
        {
            MessageBox.Show("ファイルが開かれています。\n"+ "ファイルを閉じてから、再度ファイルを読み込んでください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
        public static void sendAPPLI_ErrorMessage()
        {
            MessageBox.Show("「APPLI」を確認できませんでした\n" + "ブート領域を再度書きこみます。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void sendVer_ErrorMessage()
        {
            MessageBox.Show("コマンドを受信できませんでした\n" + "アプリ領域を再度書きこみます。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Noserial_ErrorMessage()
        {
            MessageBox.Show("製造番号が設定できていません。\n" + "確認後、再度実行してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Noserial_ErrorMessage(int CH)
        {
            MessageBox.Show(CH + "CHの製造番号が空欄です。\n" + "自動入力ボタンを押下、もしくは製造番号を記入してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void setboot_ErrorMessage()
        {
            MessageBox.Show("「起動設定」が設定されていません。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void setcustom_ErrorMessage()
        {
            MessageBox.Show("カスタム設定が完了されていません。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
       
        public static void setting_ErrorMessage()
        {
            MessageBox.Show("設定が完了されていません。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Serial_ErrorMessage()
        {
            MessageBox.Show("製造番号「連番5桁」に意図しない文字が含まれています。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Serial_ErrorMessage(int CH)
        {
            MessageBox.Show(CH+"CHの製造番号「連番5桁」に意図しない文字が含まれています。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void SerialLength_ErrorMessage(int CH)
        {
            MessageBox.Show(CH + "CHの製造番号が9桁未満です。\n" + "再度、設定してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void textbox_ErrorMessage(string msg)
        {
            MessageBox.Show("[" + msg + "] テキスト入力エラー", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void combobox_ErrorMessage(string msg)
        {
            MessageBox.Show("[" + msg + "] 選択エラー", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
