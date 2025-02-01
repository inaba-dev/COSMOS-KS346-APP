namespace APP
{
    partial class Form_basecurt
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
            this.label45 = new System.Windows.Forms.Label();
            this.numericUpDown_month_4 = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.numericUpDown_year_4 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_gas_4 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown_day_4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_4)).BeginInit();
            this.SuspendLayout();
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label45.Location = new System.Drawing.Point(188, 93);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(139, 17);
            this.label45.TabIndex = 88;
            this.label45.Text = "Data2:調整実施月";
            // 
            // numericUpDown_month_4
            // 
            this.numericUpDown_month_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_4.Location = new System.Drawing.Point(192, 113);
            this.numericUpDown_month_4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_4.Name = "numericUpDown_month_4";
            this.numericUpDown_month_4.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_4.TabIndex = 87;
            this.numericUpDown_month_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label44.Location = new System.Drawing.Point(188, 7);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(139, 17);
            this.label44.TabIndex = 86;
            this.label44.Text = "Data1:調整実施年";
            // 
            // numericUpDown_year_4
            // 
            this.numericUpDown_year_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_4.Location = new System.Drawing.Point(192, 28);
            this.numericUpDown_year_4.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_4.Name = "numericUpDown_year_4";
            this.numericUpDown_year_4.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_4.TabIndex = 85;
            // 
            // comboBox_gas_4
            // 
            this.comboBox_gas_4.BackColor = System.Drawing.Color.White;
            this.comboBox_gas_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gas_4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_gas_4.FormattingEnabled = true;
            this.comboBox_gas_4.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_gas_4.Location = new System.Drawing.Point(8, 27);
            this.comboBox_gas_4.Name = "comboBox_gas_4";
            this.comboBox_gas_4.Size = new System.Drawing.Size(119, 26);
            this.comboBox_gas_4.TabIndex = 84;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label42.Location = new System.Drawing.Point(4, 7);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(139, 17);
            this.label42.TabIndex = 83;
            this.label42.Text = "Data0:ガス種No";
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label46.Location = new System.Drawing.Point(188, 181);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(139, 17);
            this.label46.TabIndex = 90;
            this.label46.Text = "Data3:調整実施日";
            // 
            // numericUpDown_day_4
            // 
            this.numericUpDown_day_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_4.Location = new System.Drawing.Point(192, 201);
            this.numericUpDown_day_4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_4.Name = "numericUpDown_day_4";
            this.numericUpDown_day_4.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_4.TabIndex = 89;
            this.numericUpDown_day_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_basecurt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label46);
            this.Controls.Add(this.numericUpDown_day_4);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.numericUpDown_month_4);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.numericUpDown_year_4);
            this.Controls.Add(this.comboBox_gas_4);
            this.Controls.Add(this.label42);
            this.Name = "Form_basecurt";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_4;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_4;
        private System.Windows.Forms.ComboBox comboBox_gas_4;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_4;
    }
}
