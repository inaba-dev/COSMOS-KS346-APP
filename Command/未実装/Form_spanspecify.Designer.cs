namespace APP
{
    partial class Form_spanspecify
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
            this.textBox_lowAD_7 = new APP.TextBoxAD();
            this.textBox_highAD_7 = new APP.TextBoxAD();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.numericUpDown_day_7 = new System.Windows.Forms.NumericUpDown();
            this.label59 = new System.Windows.Forms.Label();
            this.numericUpDown_month_7 = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.numericUpDown_year_7 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_adjustpoint_7 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.comboBox_gas_7 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_7)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_lowAD_7
            // 
            this.textBox_lowAD_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_lowAD_7.Location = new System.Drawing.Point(397, 27);
            this.textBox_lowAD_7.Multiline = true;
            this.textBox_lowAD_7.Name = "textBox_lowAD_7";
            this.textBox_lowAD_7.Size = new System.Drawing.Size(120, 26);
            this.textBox_lowAD_7.TabIndex = 155;
            // 
            // textBox_highAD_7
            // 
            this.textBox_highAD_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_highAD_7.Location = new System.Drawing.Point(397, 116);
            this.textBox_highAD_7.Multiline = true;
            this.textBox_highAD_7.Name = "textBox_highAD_7";
            this.textBox_highAD_7.Size = new System.Drawing.Size(120, 26);
            this.textBox_highAD_7.TabIndex = 156;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label63.Location = new System.Drawing.Point(393, 93);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(152, 20);
            this.label63.TabIndex = 143;
            this.label63.Text = "Data7-8:高濃度側AD値";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label64.Location = new System.Drawing.Point(393, 4);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(152, 20);
            this.label64.TabIndex = 142;
            this.label64.Text = "Data5-6:低濃度側AD値";
            // 
            // label58
            // 
            this.label58.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label58.Location = new System.Drawing.Point(188, 181);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(139, 17);
            this.label58.TabIndex = 141;
            this.label58.Text = "Data4:調整実施日";
            // 
            // numericUpDown_day_7
            // 
            this.numericUpDown_day_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_7.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_7.Location = new System.Drawing.Point(192, 201);
            this.numericUpDown_day_7.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_7.Name = "numericUpDown_day_7";
            this.numericUpDown_day_7.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_7.TabIndex = 154;
            this.numericUpDown_day_7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label59
            // 
            this.label59.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label59.Location = new System.Drawing.Point(188, 93);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(139, 17);
            this.label59.TabIndex = 139;
            this.label59.Text = "Data3:調整実施月";
            // 
            // numericUpDown_month_7
            // 
            this.numericUpDown_month_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_7.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_7.Location = new System.Drawing.Point(192, 114);
            this.numericUpDown_month_7.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_7.Name = "numericUpDown_month_7";
            this.numericUpDown_month_7.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_7.TabIndex = 153;
            this.numericUpDown_month_7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label60
            // 
            this.label60.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label60.Location = new System.Drawing.Point(188, 7);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(139, 17);
            this.label60.TabIndex = 137;
            this.label60.Text = "Data2:調整実施年";
            // 
            // numericUpDown_year_7
            // 
            this.numericUpDown_year_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_7.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_7.Location = new System.Drawing.Point(192, 27);
            this.numericUpDown_year_7.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_7.Name = "numericUpDown_year_7";
            this.numericUpDown_year_7.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_7.TabIndex = 152;
            // 
            // comboBox_adjustpoint_7
            // 
            this.comboBox_adjustpoint_7.BackColor = System.Drawing.Color.White;
            this.comboBox_adjustpoint_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_adjustpoint_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_adjustpoint_7.FormattingEnabled = true;
            this.comboBox_adjustpoint_7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_adjustpoint_7.Location = new System.Drawing.Point(8, 113);
            this.comboBox_adjustpoint_7.Name = "comboBox_adjustpoint_7";
            this.comboBox_adjustpoint_7.Size = new System.Drawing.Size(119, 26);
            this.comboBox_adjustpoint_7.TabIndex = 151;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label61.Location = new System.Drawing.Point(4, 93);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(155, 17);
            this.label61.TabIndex = 134;
            this.label61.Text = "Data1:調整ポイント";
            // 
            // comboBox_gas_7
            // 
            this.comboBox_gas_7.BackColor = System.Drawing.Color.White;
            this.comboBox_gas_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gas_7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_gas_7.FormattingEnabled = true;
            this.comboBox_gas_7.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_gas_7.Location = new System.Drawing.Point(8, 26);
            this.comboBox_gas_7.Name = "comboBox_gas_7";
            this.comboBox_gas_7.Size = new System.Drawing.Size(119, 26);
            this.comboBox_gas_7.TabIndex = 150;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label62.Location = new System.Drawing.Point(4, 7);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(139, 17);
            this.label62.TabIndex = 132;
            this.label62.Text = "Data0:ガス種No";
            // 
            // Form_spanspecify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox_lowAD_7);
            this.Controls.Add(this.textBox_highAD_7);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.numericUpDown_day_7);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.numericUpDown_month_7);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.numericUpDown_year_7);
            this.Controls.Add(this.comboBox_adjustpoint_7);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.comboBox_gas_7);
            this.Controls.Add(this.label62);
            this.Name = "Form_spanspecify";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxAD textBox_lowAD_7;
        private TextBoxAD textBox_highAD_7;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_7;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_7;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_7;
        private System.Windows.Forms.ComboBox comboBox_adjustpoint_7;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox comboBox_gas_7;
        private System.Windows.Forms.Label label62;
    }
}
