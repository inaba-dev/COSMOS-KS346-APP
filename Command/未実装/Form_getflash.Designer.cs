namespace APP
{
    partial class Form_getflash
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_15_starthex = new System.Windows.Forms.Label();
            this.label_15_areahex = new System.Windows.Forms.Label();
            this.comboBox_byte = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.textBoxadress_startadress = new APP.TextBoxadress();
            this.textBox1byte_area = new APP.TextBox1byte();
            this.SuspendLayout();
            // 
            // label_15_starthex
            // 
            this.label_15_starthex.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_15_starthex.Location = new System.Drawing.Point(134, 114);
            this.label_15_starthex.Name = "label_15_starthex";
            this.label_15_starthex.Size = new System.Drawing.Size(107, 30);
            this.label_15_starthex.TabIndex = 218;
            this.label_15_starthex.Text = "(0x)";
            // 
            // label_15_areahex
            // 
            this.label_15_areahex.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_15_areahex.Location = new System.Drawing.Point(133, 30);
            this.label_15_areahex.Name = "label_15_areahex";
            this.label_15_areahex.Size = new System.Drawing.Size(64, 30);
            this.label_15_areahex.TabIndex = 217;
            this.label_15_areahex.Text = "(0xFF)";
            // 
            // comboBox_byte
            // 
            this.comboBox_byte.BackColor = System.Drawing.Color.White;
            this.comboBox_byte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_byte.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_byte.FormattingEnabled = true;
            this.comboBox_byte.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox_byte.Location = new System.Drawing.Point(9, 200);
            this.comboBox_byte.Name = "comboBox_byte";
            this.comboBox_byte.Size = new System.Drawing.Size(119, 26);
            this.comboBox_byte.TabIndex = 242;
            // 
            // label100
            // 
            this.label100.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label100.Location = new System.Drawing.Point(4, 180);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(208, 17);
            this.label100.TabIndex = 214;
            this.label100.Text = "Data3:バイト数";
            // 
            // label98
            // 
            this.label98.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label98.Location = new System.Drawing.Point(5, 91);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(208, 17);
            this.label98.TabIndex = 212;
            this.label98.Text = "Data1-2:開始アドレス";
            // 
            // label99
            // 
            this.label99.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label99.Location = new System.Drawing.Point(4, 7);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(227, 17);
            this.label99.TabIndex = 211;
            this.label99.Text = "Data0:エリア(現状0xFFのみ)";
            // 
            // textBoxadress_startadress
            // 
            this.textBoxadress_startadress.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxadress_startadress.Location = new System.Drawing.Point(9, 111);
            this.textBoxadress_startadress.Multiline = true;
            this.textBoxadress_startadress.Name = "textBoxadress_startadress";
            this.textBoxadress_startadress.Size = new System.Drawing.Size(120, 26);
            this.textBoxadress_startadress.TabIndex = 241;
            this.textBoxadress_startadress.TextChanged += new System.EventHandler(this.textBoxadress_startadress_TextChanged);
            // 
            // textBox1byte_area
            // 
            this.textBox1byte_area.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1byte_area.Location = new System.Drawing.Point(8, 27);
            this.textBox1byte_area.Multiline = true;
            this.textBox1byte_area.Name = "textBox1byte_area";
            this.textBox1byte_area.Size = new System.Drawing.Size(120, 26);
            this.textBox1byte_area.TabIndex = 240;
            this.textBox1byte_area.Text = "255";
            this.textBox1byte_area.TextChanged += new System.EventHandler(this.textBox1byte_area_TextChanged);
            // 
            // Form_getflash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label_15_starthex);
            this.Controls.Add(this.label_15_areahex);
            this.Controls.Add(this.comboBox_byte);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.textBoxadress_startadress);
            this.Controls.Add(this.textBox1byte_area);
            this.Name = "Form_getflash";
            this.Size = new System.Drawing.Size(1140, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_15_starthex;
        private System.Windows.Forms.Label label_15_areahex;
        private System.Windows.Forms.ComboBox comboBox_byte;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private TextBoxadress textBoxadress_startadress;
        private TextBox1byte textBox1byte_area;
    }
}
