namespace APP
{
    partial class Form_status
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
            this.checkBox_temp = new System.Windows.Forms.CheckBox();
            this.checkBox_hum = new System.Windows.Forms.CheckBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown_hum = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.numericUpDown_temp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_temp
            // 
            this.checkBox_temp.AutoSize = true;
            this.checkBox_temp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_temp.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_temp.Location = new System.Drawing.Point(135, 29);
            this.checkBox_temp.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_temp.Name = "checkBox_temp";
            this.checkBox_temp.Size = new System.Drawing.Size(54, 24);
            this.checkBox_temp.TabIndex = 190;
            this.checkBox_temp.Text = "不明";
            this.checkBox_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_temp.UseVisualStyleBackColor = true;
            this.checkBox_temp.CheckedChanged += new System.EventHandler(this.checkBox_temp_CheckedChanged);
            // 
            // checkBox_hum
            // 
            this.checkBox_hum.AutoSize = true;
            this.checkBox_hum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_hum.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_hum.Location = new System.Drawing.Point(135, 110);
            this.checkBox_hum.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_hum.Name = "checkBox_hum";
            this.checkBox_hum.Size = new System.Drawing.Size(54, 24);
            this.checkBox_hum.TabIndex = 192;
            this.checkBox_hum.Text = "不明";
            this.checkBox_hum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_hum.UseVisualStyleBackColor = true;
            this.checkBox_hum.CheckedChanged += new System.EventHandler(this.checkBox_hum_CheckedChanged);
            // 
            // label72
            // 
            this.label72.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label72.Location = new System.Drawing.Point(4, 154);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(356, 58);
            this.label72.TabIndex = 193;
            this.label72.Text = "※温度、湿度不明の場合は\r\n　『不明チェックボックス』にチェックをしてください。";
            // 
            // label68
            // 
            this.label68.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label68.Location = new System.Drawing.Point(4, 88);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(139, 17);
            this.label68.TabIndex = 192;
            this.label68.Text = "Data1:湿度(%RH)";
            // 
            // numericUpDown_hum
            // 
            this.numericUpDown_hum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_hum.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_hum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_hum.Location = new System.Drawing.Point(8, 108);
            this.numericUpDown_hum.Name = "numericUpDown_hum";
            this.numericUpDown_hum.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_hum.TabIndex = 191;
            // 
            // label71
            // 
            this.label71.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label71.Location = new System.Drawing.Point(4, 7);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(171, 17);
            this.label71.TabIndex = 190;
            this.label71.Text = "Data0:摂氏温度(℃)";
            // 
            // numericUpDown_temp
            // 
            this.numericUpDown_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_temp.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_temp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_temp.Location = new System.Drawing.Point(8, 27);
            this.numericUpDown_temp.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_temp.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDown_temp.Name = "numericUpDown_temp";
            this.numericUpDown_temp.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_temp.TabIndex = 189;
            // 
            // Form_status
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.checkBox_temp);
            this.Controls.Add(this.checkBox_hum);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.numericUpDown_hum);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.numericUpDown_temp);
            this.Name = "Form_status";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_temp;
        private System.Windows.Forms.CheckBox checkBox_hum;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numericUpDown_hum;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.NumericUpDown numericUpDown_temp;
    }
}
