namespace APP
{
    partial class Form_AD
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
            this.button_stop = new System.Windows.Forms.Button();
            this.comboBox_Cycle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_cont = new System.Windows.Forms.CheckBox();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.DarkGray;
            this.button_stop.Enabled = false;
            this.button_stop.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_stop.ForeColor = System.Drawing.Color.Black;
            this.button_stop.Location = new System.Drawing.Point(105, 18);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(56, 40);
            this.button_stop.TabIndex = 99;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // comboBox_Cycle
            // 
            this.comboBox_Cycle.BackColor = System.Drawing.Color.White;
            this.comboBox_Cycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cycle.Enabled = false;
            this.comboBox_Cycle.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_Cycle.FormattingEnabled = true;
            this.comboBox_Cycle.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "30",
            "60",
            "120",
            "300"});
            this.comboBox_Cycle.Location = new System.Drawing.Point(260, 23);
            this.comboBox_Cycle.Name = "comboBox_Cycle";
            this.comboBox_Cycle.Size = new System.Drawing.Size(80, 32);
            this.comboBox_Cycle.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(256, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 98;
            this.label9.Text = "読み出し周期";
            // 
            // checkBox_cont
            // 
            this.checkBox_cont.AutoSize = true;
            this.checkBox_cont.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_cont.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_cont.Location = new System.Drawing.Point(168, 26);
            this.checkBox_cont.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_cont.Name = "checkBox_cont";
            this.checkBox_cont.Size = new System.Drawing.Size(74, 27);
            this.checkBox_cont.TabIndex = 96;
            this.checkBox_cont.Text = "　連続";
            this.checkBox_cont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_cont.UseVisualStyleBackColor = true;
            this.checkBox_cont.CheckedChanged += new System.EventHandler(this.checkBox_cont_CheckedChanged);
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.DarkGray;
            this.button_send.Enabled = false;
            this.button_send.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_send.ForeColor = System.Drawing.Color.Black;
            this.button_send.Location = new System.Drawing.Point(3, 18);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(86, 40);
            this.button_send.TabIndex = 100;
            this.button_send.Text = "読出";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Form_AD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.comboBox_Cycle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox_cont);
            this.Name = "Form_AD";
            this.Size = new System.Drawing.Size(370, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ComboBox comboBox_Cycle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_cont;
        private System.Windows.Forms.Button button_send;
    }
}
