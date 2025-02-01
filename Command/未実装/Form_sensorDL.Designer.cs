namespace APP
{
    partial class Form_sensorDL
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_proofday = new System.Windows.Forms.CheckBox();
            this.checkBox_proofinterval = new System.Windows.Forms.CheckBox();
            this.checkBox_changeday = new System.Windows.Forms.CheckBox();
            this.checkBox_changeinterval = new System.Windows.Forms.CheckBox();
            this.textBox2byte_proofinterval = new APP.TextBox2byte();
            this.textBox2byte_changeinterval = new APP.TextBox2byte();
            this.numericUpDown_day_proof_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_month_proof_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_year_proof_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_day_change_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_month_change_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_year_change_1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_proof_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_proof_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_proof_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_change_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_change_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_change_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(218, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 17);
            this.label12.TabIndex = 175;
            this.label12.Text = "Data4:センサ交換実施月";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(218, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 17);
            this.label13.TabIndex = 173;
            this.label13.Text = "Data3:センサ交換実施年";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(218, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 17);
            this.label15.TabIndex = 179;
            this.label15.Text = "Data5:センサ交換実施日";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(218, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 17);
            this.label10.TabIndex = 178;
            this.label10.Text = "Data1-2:センサ交換間隔 (単位:日)";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(4, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 17);
            this.label14.TabIndex = 177;
            this.label14.Text = "Data0:設定データフラグ";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(482, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 17);
            this.label16.TabIndex = 183;
            this.label16.Text = "Data10:センサ校正実施日";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(482, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 17);
            this.label9.TabIndex = 182;
            this.label9.Text = "Data9:センサ校正実施月";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(482, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 181;
            this.label7.Text = "Data8:センサ校正実施年";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(482, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 17);
            this.label11.TabIndex = 180;
            this.label11.Text = "Data6-7:センサ校正間隔 (単位:日)";
            // 
            // checkBox_proofday
            // 
            this.checkBox_proofday.AutoSize = true;
            this.checkBox_proofday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_proofday.Checked = true;
            this.checkBox_proofday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_proofday.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_proofday.Location = new System.Drawing.Point(6, 127);
            this.checkBox_proofday.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_proofday.Name = "checkBox_proofday";
            this.checkBox_proofday.Size = new System.Drawing.Size(147, 22);
            this.checkBox_proofday.TabIndex = 203;
            this.checkBox_proofday.Text = "センサ校正実施年月日";
            this.checkBox_proofday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_proofday.UseVisualStyleBackColor = true;
            this.checkBox_proofday.CheckedChanged += new System.EventHandler(this.checkBox_proofday_CheckedChanged);
            // 
            // checkBox_proofinterval
            // 
            this.checkBox_proofinterval.AutoSize = true;
            this.checkBox_proofinterval.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_proofinterval.Checked = true;
            this.checkBox_proofinterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_proofinterval.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_proofinterval.Location = new System.Drawing.Point(42, 97);
            this.checkBox_proofinterval.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_proofinterval.Name = "checkBox_proofinterval";
            this.checkBox_proofinterval.Size = new System.Drawing.Size(111, 22);
            this.checkBox_proofinterval.TabIndex = 202;
            this.checkBox_proofinterval.Text = "センサ校正間隔";
            this.checkBox_proofinterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_proofinterval.UseVisualStyleBackColor = true;
            this.checkBox_proofinterval.CheckedChanged += new System.EventHandler(this.checkBox_proofinterval_CheckedChanged);
            // 
            // checkBox_changeday
            // 
            this.checkBox_changeday.AutoSize = true;
            this.checkBox_changeday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_changeday.Checked = true;
            this.checkBox_changeday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_changeday.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_changeday.Location = new System.Drawing.Point(6, 67);
            this.checkBox_changeday.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_changeday.Name = "checkBox_changeday";
            this.checkBox_changeday.Size = new System.Drawing.Size(147, 22);
            this.checkBox_changeday.TabIndex = 201;
            this.checkBox_changeday.Text = "センサ交換実施年月日";
            this.checkBox_changeday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_changeday.UseVisualStyleBackColor = true;
            this.checkBox_changeday.CheckedChanged += new System.EventHandler(this.checkBox_changeday_CheckedChanged);
            // 
            // checkBox_changeinterval
            // 
            this.checkBox_changeinterval.AutoSize = true;
            this.checkBox_changeinterval.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_changeinterval.Checked = true;
            this.checkBox_changeinterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_changeinterval.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_changeinterval.Location = new System.Drawing.Point(42, 37);
            this.checkBox_changeinterval.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_changeinterval.Name = "checkBox_changeinterval";
            this.checkBox_changeinterval.Size = new System.Drawing.Size(111, 22);
            this.checkBox_changeinterval.TabIndex = 200;
            this.checkBox_changeinterval.Text = "センサ交換間隔";
            this.checkBox_changeinterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_changeinterval.UseVisualStyleBackColor = true;
            this.checkBox_changeinterval.CheckedChanged += new System.EventHandler(this.checkBox_changeinterval_CheckedChanged);
            // 
            // textBox2byte_proofinterval
            // 
            this.textBox2byte_proofinterval.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2byte_proofinterval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2byte_proofinterval.Location = new System.Drawing.Point(486, 27);
            this.textBox2byte_proofinterval.MaxLength = 5;
            this.textBox2byte_proofinterval.Multiline = true;
            this.textBox2byte_proofinterval.Name = "textBox2byte_proofinterval";
            this.textBox2byte_proofinterval.Size = new System.Drawing.Size(120, 26);
            this.textBox2byte_proofinterval.TabIndex = 208;
            // 
            // textBox2byte_changeinterval
            // 
            this.textBox2byte_changeinterval.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2byte_changeinterval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2byte_changeinterval.Location = new System.Drawing.Point(222, 27);
            this.textBox2byte_changeinterval.MaxLength = 5;
            this.textBox2byte_changeinterval.Multiline = true;
            this.textBox2byte_changeinterval.Name = "textBox2byte_changeinterval";
            this.textBox2byte_changeinterval.Size = new System.Drawing.Size(120, 26);
            this.textBox2byte_changeinterval.TabIndex = 204;
            // 
            // numericUpDown_day_proof_1
            // 
            this.numericUpDown_day_proof_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_proof_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_proof_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_proof_1.Location = new System.Drawing.Point(486, 241);
            this.numericUpDown_day_proof_1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_proof_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_proof_1.Name = "numericUpDown_day_proof_1";
            this.numericUpDown_day_proof_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_proof_1.TabIndex = 211;
            this.numericUpDown_day_proof_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_month_proof_1
            // 
            this.numericUpDown_month_proof_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_proof_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_proof_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_proof_1.Location = new System.Drawing.Point(486, 171);
            this.numericUpDown_month_proof_1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_proof_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_proof_1.Name = "numericUpDown_month_proof_1";
            this.numericUpDown_month_proof_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_proof_1.TabIndex = 210;
            this.numericUpDown_month_proof_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_year_proof_1
            // 
            this.numericUpDown_year_proof_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_proof_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_proof_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_proof_1.Location = new System.Drawing.Point(486, 97);
            this.numericUpDown_year_proof_1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_proof_1.Name = "numericUpDown_year_proof_1";
            this.numericUpDown_year_proof_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_proof_1.TabIndex = 209;
            // 
            // numericUpDown_day_change_1
            // 
            this.numericUpDown_day_change_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day_change_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_day_change_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_day_change_1.Location = new System.Drawing.Point(222, 241);
            this.numericUpDown_day_change_1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day_change_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day_change_1.Name = "numericUpDown_day_change_1";
            this.numericUpDown_day_change_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_day_change_1.TabIndex = 207;
            this.numericUpDown_day_change_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_month_change_1
            // 
            this.numericUpDown_month_change_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_month_change_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_month_change_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_month_change_1.Location = new System.Drawing.Point(222, 171);
            this.numericUpDown_month_change_1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month_change_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month_change_1.Name = "numericUpDown_month_change_1";
            this.numericUpDown_month_change_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_month_change_1.TabIndex = 206;
            this.numericUpDown_month_change_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_year_change_1
            // 
            this.numericUpDown_year_change_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year_change_1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_year_change_1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown_year_change_1.Location = new System.Drawing.Point(222, 96);
            this.numericUpDown_year_change_1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_year_change_1.Name = "numericUpDown_year_change_1";
            this.numericUpDown_year_change_1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_year_change_1.TabIndex = 205;
            // 
            // Form_sensorDL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.numericUpDown_day_proof_1);
            this.Controls.Add(this.numericUpDown_month_proof_1);
            this.Controls.Add(this.numericUpDown_year_proof_1);
            this.Controls.Add(this.numericUpDown_day_change_1);
            this.Controls.Add(this.numericUpDown_month_change_1);
            this.Controls.Add(this.numericUpDown_year_change_1);
            this.Controls.Add(this.textBox2byte_proofinterval);
            this.Controls.Add(this.textBox2byte_changeinterval);
            this.Controls.Add(this.checkBox_proofday);
            this.Controls.Add(this.checkBox_proofinterval);
            this.Controls.Add(this.checkBox_changeday);
            this.Controls.Add(this.checkBox_changeinterval);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "Form_sensorDL";
            this.Size = new System.Drawing.Size(1140, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_proof_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_proof_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_proof_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day_change_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month_change_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year_change_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_proofday;
        private System.Windows.Forms.CheckBox checkBox_proofinterval;
        private System.Windows.Forms.CheckBox checkBox_changeday;
        private System.Windows.Forms.CheckBox checkBox_changeinterval;
        private TextBox2byte textBox2byte_proofinterval;
        private TextBox2byte textBox2byte_changeinterval;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_proof_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_proof_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_proof_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_day_change_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_month_change_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_year_change_1;
    }
}
