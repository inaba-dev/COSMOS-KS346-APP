namespace APP
{
    partial class FormMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_conc = new System.Windows.Forms.GroupBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_path = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDisConnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.buttonComSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CH8 = new APP.UserControlDevice();
            this.CH7 = new APP.UserControlDevice();
            this.CH6 = new APP.UserControlDevice();
            this.CH5 = new APP.UserControlDevice();
            this.CH4 = new APP.UserControlDevice();
            this.CH3 = new APP.UserControlDevice();
            this.CH2 = new APP.UserControlDevice();
            this.CH1 = new APP.UserControlDevice();
            this.Chart = new APP.UserControlChart();
            this.groupBox_conc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_conc
            // 
            this.groupBox_conc.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_conc.Controls.Add(this.labelStart);
            this.groupBox_conc.Controls.Add(this.labelRunTime);
            this.groupBox_conc.Controls.Add(this.label1);
            this.groupBox_conc.Controls.Add(this.button_path);
            this.groupBox_conc.Controls.Add(this.textBox_path);
            this.groupBox_conc.Controls.Add(this.numericInterval);
            this.groupBox_conc.Controls.Add(this.button_start);
            this.groupBox_conc.Controls.Add(this.button_stop);
            this.groupBox_conc.Controls.Add(this.label9);
            this.groupBox_conc.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.groupBox_conc.Location = new System.Drawing.Point(404, 5);
            this.groupBox_conc.Name = "groupBox_conc";
            this.groupBox_conc.Size = new System.Drawing.Size(1165, 60);
            this.groupBox_conc.TabIndex = 269;
            this.groupBox_conc.TabStop = false;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.labelStart.Location = new System.Drawing.Point(356, 13);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(198, 20);
            this.labelStart.TabIndex = 231;
            this.labelStart.Text = "開始：YYYY/MM/DD 00:00:00";
            this.labelStart.Visible = false;
            // 
            // labelRunTime
            // 
            this.labelRunTime.AutoSize = true;
            this.labelRunTime.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.labelRunTime.Location = new System.Drawing.Point(356, 34);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(108, 20);
            this.labelRunTime.TabIndex = 230;
            this.labelRunTime.Text = "経過：00:00:00";
            this.labelRunTime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label1.Location = new System.Drawing.Point(567, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 229;
            this.label1.Text = "保存先";
            // 
            // button_path
            // 
            this.button_path.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_path.Location = new System.Drawing.Point(1094, 19);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(53, 28);
            this.button_path.TabIndex = 228;
            this.button_path.TabStop = false;
            this.button_path.Text = "参照";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.BackColor = System.Drawing.Color.White;
            this.textBox_path.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.textBox_path.Location = new System.Drawing.Point(622, 20);
            this.textBox_path.MaxLength = 99;
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(458, 28);
            this.textBox_path.TabIndex = 227;
            this.textBox_path.TabStop = false;
            // 
            // numericInterval
            // 
            this.numericInterval.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.numericInterval.Location = new System.Drawing.Point(260, 21);
            this.numericInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(72, 27);
            this.numericInterval.TabIndex = 226;
            this.numericInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.DarkGray;
            this.button_start.Enabled = false;
            this.button_start.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.button_start.ForeColor = System.Drawing.Color.Black;
            this.button_start.Location = new System.Drawing.Point(19, 16);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(83, 34);
            this.button_start.TabIndex = 224;
            this.button_start.Text = "測定開始";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.DarkGray;
            this.button_stop.Enabled = false;
            this.button_stop.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.button_stop.ForeColor = System.Drawing.Color.Black;
            this.button_stop.Location = new System.Drawing.Point(108, 16);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(76, 34);
            this.button_stop.TabIndex = 225;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label9.Location = new System.Drawing.Point(194, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 93;
            this.label9.Text = "周期(秒)";
            // 
            // buttonDisConnect
            // 
            this.buttonDisConnect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDisConnect.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDisConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonDisConnect.Location = new System.Drawing.Point(102, 15);
            this.buttonDisConnect.Name = "buttonDisConnect";
            this.buttonDisConnect.Size = new System.Drawing.Size(75, 34);
            this.buttonDisConnect.TabIndex = 274;
            this.buttonDisConnect.Text = "切断";
            this.buttonDisConnect.UseVisualStyleBackColor = false;
            this.buttonDisConnect.Click += new System.EventHandler(this.buttonDisConnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonConnect.Location = new System.Drawing.Point(21, 15);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 34);
            this.buttonConnect.TabIndex = 273;
            this.buttonConnect.Text = "接続";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.BackColor = System.Drawing.Color.White;
            this.comboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COM.Font = new System.Drawing.Font("メイリオ", 11F);
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(187, 17);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(77, 31);
            this.comboBox_COM.TabIndex = 272;
            // 
            // buttonComSearch
            // 
            this.buttonComSearch.BackColor = System.Drawing.Color.Turquoise;
            this.buttonComSearch.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonComSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonComSearch.Location = new System.Drawing.Point(274, 16);
            this.buttonComSearch.Name = "buttonComSearch";
            this.buttonComSearch.Size = new System.Drawing.Size(91, 34);
            this.buttonComSearch.TabIndex = 271;
            this.buttonComSearch.Text = "COM更新";
            this.buttonComSearch.UseVisualStyleBackColor = false;
            this.buttonComSearch.Click += new System.EventHandler(this.buttonComSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox_COM);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.buttonComSearch);
            this.groupBox1.Controls.Add(this.buttonDisConnect);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 60);
            this.groupBox1.TabIndex = 275;
            this.groupBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CH8
            // 
            this.CH8.BackColor = System.Drawing.Color.Transparent;
            this.CH8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH8.Location = new System.Drawing.Point(1189, 382);
            this.CH8.Name = "CH8";
            this.CH8.Size = new System.Drawing.Size(380, 300);
            this.CH8.TabIndex = 287;
            // 
            // CH7
            // 
            this.CH7.BackColor = System.Drawing.Color.Transparent;
            this.CH7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH7.Location = new System.Drawing.Point(796, 382);
            this.CH7.Name = "CH7";
            this.CH7.Size = new System.Drawing.Size(380, 300);
            this.CH7.TabIndex = 286;
            // 
            // CH6
            // 
            this.CH6.BackColor = System.Drawing.Color.Transparent;
            this.CH6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH6.Location = new System.Drawing.Point(404, 382);
            this.CH6.Name = "CH6";
            this.CH6.Size = new System.Drawing.Size(380, 300);
            this.CH6.TabIndex = 285;
            // 
            // CH5
            // 
            this.CH5.BackColor = System.Drawing.Color.Transparent;
            this.CH5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH5.Location = new System.Drawing.Point(12, 382);
            this.CH5.Name = "CH5";
            this.CH5.Size = new System.Drawing.Size(380, 300);
            this.CH5.TabIndex = 284;
            // 
            // CH4
            // 
            this.CH4.BackColor = System.Drawing.Color.Transparent;
            this.CH4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH4.Location = new System.Drawing.Point(1189, 73);
            this.CH4.Name = "CH4";
            this.CH4.Size = new System.Drawing.Size(380, 300);
            this.CH4.TabIndex = 283;
            // 
            // CH3
            // 
            this.CH3.BackColor = System.Drawing.Color.Transparent;
            this.CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH3.Location = new System.Drawing.Point(796, 73);
            this.CH3.Name = "CH3";
            this.CH3.Size = new System.Drawing.Size(380, 300);
            this.CH3.TabIndex = 282;
            // 
            // CH2
            // 
            this.CH2.BackColor = System.Drawing.Color.Transparent;
            this.CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH2.Location = new System.Drawing.Point(404, 73);
            this.CH2.Name = "CH2";
            this.CH2.Size = new System.Drawing.Size(380, 300);
            this.CH2.TabIndex = 281;
            // 
            // CH1
            // 
            this.CH1.BackColor = System.Drawing.Color.Transparent;
            this.CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH1.Location = new System.Drawing.Point(12, 74);
            this.CH1.Name = "CH1";
            this.CH1.Size = new System.Drawing.Size(380, 300);
            this.CH1.TabIndex = 280;
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(13, 690);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(1040, 200);
            this.Chart.TabIndex = 288;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 901);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.CH8);
            this.Controls.Add(this.CH7);
            this.Controls.Add(this.CH6);
            this.Controls.Add(this.CH5);
            this.Controls.Add(this.CH4);
            this.Controls.Add(this.CH3);
            this.Controls.Add(this.CH2);
            this.Controls.Add(this.CH1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_conc);
            this.MaximumSize = new System.Drawing.Size(1600, 940);
            this.MinimumSize = new System.Drawing.Size(1600, 940);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox_conc.ResumeLayout(false);
            this.groupBox_conc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_conc;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDisConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button buttonComSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private UserControlDevice CH1;
        private UserControlDevice CH2;
        private UserControlDevice CH3;
        private UserControlDevice CH4;
        private UserControlDevice CH8;
        private UserControlDevice CH7;
        private UserControlDevice CH6;
        private UserControlDevice CH5;
        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelRunTime;
        private System.Windows.Forms.Timer timer;
        private UserControlChart Chart;
    }
}

