namespace APP
{
    partial class Form_basespecify
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
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.numericUpDown_month_5 = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.numericUpDown_year_5 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_gas_5 = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.numericUpDown_day_5 = new System.Windows.Forms.NumericUpDown();
            this.textBox_lowAD_5 = new APP.TextBoxAD();
            this.textBox_highAD_5 = new APP.TextBoxAD();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_5)).BeginInit();
            this.SuspendLayout();
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label51.Location = new System.Drawing.Point(393, 93);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(152, 20);
            this.label51.TabIndex = 135;
            this.label51.Text = "Data6-7:高濃度側AD値";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label52.Location = new System.Drawing.Point(393, 4);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(152, 20);
            this.label52.TabIndex = 134;
            this.label52.Text = "Data4-5:低濃度側AD値";
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label48.Location = new System.Drawing.Point(188, 93);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(139, 17);
            this.label48.TabIndex = 133;
            this.label48.Text = "Data2:調整実施月";
            // 
            // numericUpDown_month_5
            // 
            this.numericUpDown_month_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_5.Location = new System.Drawing.Point(192, 113);
            this.numericUpDown_month_5.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_5.Name = "numericUpDown_month_5";
            this.numericUpDown_month_5.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_5.TabIndex = 152;
            this.numericUpDown_month_5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label49.Location = new System.Drawing.Point(188, 7);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(139, 17);
            this.label49.TabIndex = 131;
            this.label49.Text = "Data1:調整実施年";
            // 
            // numericUpDown_year_5
            // 
            this.numericUpDown_year_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_5.Location = new System.Drawing.Point(192, 28);
            this.numericUpDown_year_5.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_5.Name = "numericUpDown_year_5";
            this.numericUpDown_year_5.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_5.TabIndex = 151;
            // 
            // comboBox_gas_5
            // 
            this.comboBox_gas_5.BackColor = System.Drawing.Color.White;
            this.comboBox_gas_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gas_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_gas_5.FormattingEnabled = true;
            this.comboBox_gas_5.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_gas_5.Location = new System.Drawing.Point(8, 27);
            this.comboBox_gas_5.Name = "comboBox_gas_5";
            this.comboBox_gas_5.Size = new System.Drawing.Size(119, 26);
            this.comboBox_gas_5.TabIndex = 150;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label50.Location = new System.Drawing.Point(4, 7);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(139, 17);
            this.label50.TabIndex = 128;
            this.label50.Text = "Data0:ガス種No";
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label47.Location = new System.Drawing.Point(188, 181);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(139, 17);
            this.label47.TabIndex = 139;
            this.label47.Text = "Data3:調整実施日";
            // 
            // numericUpDown_day_5
            // 
            this.numericUpDown_day_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_5.Location = new System.Drawing.Point(192, 201);
            this.numericUpDown_day_5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_5.Name = "numericUpDown_day_5";
            this.numericUpDown_day_5.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_5.TabIndex = 153;
            this.numericUpDown_day_5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_lowAD_5
            // 
            this.textBox_lowAD_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_lowAD_5.Location = new System.Drawing.Point(397, 28);
            this.textBox_lowAD_5.Multiline = true;
            this.textBox_lowAD_5.Name = "textBox_lowAD_5";
            this.textBox_lowAD_5.Size = new System.Drawing.Size(120, 26);
            this.textBox_lowAD_5.TabIndex = 154;
            // 
            // textBox_highAD_5
            // 
            this.textBox_highAD_5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_highAD_5.Location = new System.Drawing.Point(397, 116);
            this.textBox_highAD_5.Multiline = true;
            this.textBox_highAD_5.Name = "textBox_highAD_5";
            this.textBox_highAD_5.Size = new System.Drawing.Size(120, 26);
            this.textBox_highAD_5.TabIndex = 155;
            // 
            // Form_basespecify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label47);
            this.Controls.Add(this.numericUpDown_day_5);
            this.Controls.Add(this.textBox_lowAD_5);
            this.Controls.Add(this.textBox_highAD_5);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.numericUpDown_month_5);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.numericUpDown_year_5);
            this.Controls.Add(this.comboBox_gas_5);
            this.Controls.Add(this.label50);
            this.Name = "Form_basespecify";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxAD textBox_lowAD_5;
        private TextBoxAD textBox_highAD_5;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_5;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_5;
        private System.Windows.Forms.ComboBox comboBox_gas_5;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_5;
    }
}
