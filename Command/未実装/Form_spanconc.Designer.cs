namespace APP
{
    partial class Form_spanconc
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
            this.textBox2byte_adjustfull = new APP.TextBox2byte();
            this.label70 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.numericUpDown_day_8 = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.numericUpDown_month_8 = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.numericUpDown_year_8 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_gas_8 = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_8)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2byte_adjustfull
            // 
            this.textBox2byte_adjustfull.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2byte_adjustfull.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2byte_adjustfull.Location = new System.Drawing.Point(8, 136);
            this.textBox2byte_adjustfull.MaxLength = 5;
            this.textBox2byte_adjustfull.Multiline = true;
            this.textBox2byte_adjustfull.Name = "textBox2byte_adjustfull";
            this.textBox2byte_adjustfull.Size = new System.Drawing.Size(120, 26);
            this.textBox2byte_adjustfull.TabIndex = 201;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label70.Location = new System.Drawing.Point(4, 93);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(224, 40);
            this.label70.TabIndex = 183;
            this.label70.Text = "Data1-2:調整濃度のフルスケールの\r\n30%~100%";
            // 
            // label65
            // 
            this.label65.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label65.Location = new System.Drawing.Point(274, 181);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(139, 17);
            this.label65.TabIndex = 182;
            this.label65.Text = "Data5:調整実施日";
            // 
            // numericUpDown_day_8
            // 
            this.numericUpDown_day_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_8.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_8.Location = new System.Drawing.Point(278, 201);
            this.numericUpDown_day_8.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_8.Name = "numericUpDown_day_8";
            this.numericUpDown_day_8.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_8.TabIndex = 204;
            this.numericUpDown_day_8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label66.Location = new System.Drawing.Point(274, 93);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(139, 17);
            this.label66.TabIndex = 180;
            this.label66.Text = "Data4:調整実施月";
            // 
            // numericUpDown_month_8
            // 
            this.numericUpDown_month_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_8.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_8.Location = new System.Drawing.Point(278, 113);
            this.numericUpDown_month_8.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_8.Name = "numericUpDown_month_8";
            this.numericUpDown_month_8.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_8.TabIndex = 203;
            this.numericUpDown_month_8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label67.Location = new System.Drawing.Point(274, 7);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(139, 17);
            this.label67.TabIndex = 178;
            this.label67.Text = "Data3:調整実施年";
            // 
            // numericUpDown_year_8
            // 
            this.numericUpDown_year_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_8.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_8.Location = new System.Drawing.Point(278, 28);
            this.numericUpDown_year_8.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_8.Name = "numericUpDown_year_8";
            this.numericUpDown_year_8.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_8.TabIndex = 202;
            // 
            // comboBox_gas_8
            // 
            this.comboBox_gas_8.BackColor = System.Drawing.Color.White;
            this.comboBox_gas_8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gas_8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_gas_8.FormattingEnabled = true;
            this.comboBox_gas_8.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_gas_8.Location = new System.Drawing.Point(8, 27);
            this.comboBox_gas_8.Name = "comboBox_gas_8";
            this.comboBox_gas_8.Size = new System.Drawing.Size(119, 26);
            this.comboBox_gas_8.TabIndex = 200;
            // 
            // label69
            // 
            this.label69.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label69.Location = new System.Drawing.Point(4, 7);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(139, 17);
            this.label69.TabIndex = 175;
            this.label69.Text = "Data0:ガス種No";
            // 
            // Form_spanconc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox2byte_adjustfull);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.numericUpDown_day_8);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.numericUpDown_month_8);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.numericUpDown_year_8);
            this.Controls.Add(this.comboBox_gas_8);
            this.Controls.Add(this.label69);
            this.Name = "Form_spanconc";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox2byte textBox2byte_adjustfull;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_8;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_8;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_8;
        private System.Windows.Forms.ComboBox comboBox_gas_8;
        private System.Windows.Forms.Label label69;
    }
}
