namespace APP
{
    partial class Form_peak
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
            this.comboBox_peak = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.comboBox_detect = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_peak
            // 
            this.comboBox_peak.BackColor = System.Drawing.Color.White;
            this.comboBox_peak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_peak.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_peak.FormattingEnabled = true;
            this.comboBox_peak.Items.AddRange(new object[] {
            "最大値",
            "最小値"});
            this.comboBox_peak.Location = new System.Drawing.Point(8, 108);
            this.comboBox_peak.Name = "comboBox_peak";
            this.comboBox_peak.Size = new System.Drawing.Size(119, 26);
            this.comboBox_peak.TabIndex = 204;
            // 
            // label97
            // 
            this.label97.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label97.Location = new System.Drawing.Point(4, 88);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(208, 17);
            this.label97.TabIndex = 203;
            this.label97.Text = "Data1:ピーク種別";
            // 
            // comboBox_detect
            // 
            this.comboBox_detect.BackColor = System.Drawing.Color.White;
            this.comboBox_detect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_detect.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_detect.FormattingEnabled = true;
            this.comboBox_detect.Items.AddRange(new object[] {
            "検出開始条件なし",
            "センサ出力(規定値以下で検出開始)",
            "センサ出力(規定値以上で検出開始)"});
            this.comboBox_detect.Location = new System.Drawing.Point(8, 27);
            this.comboBox_detect.Name = "comboBox_detect";
            this.comboBox_detect.Size = new System.Drawing.Size(245, 26);
            this.comboBox_detect.TabIndex = 202;
            // 
            // label96
            // 
            this.label96.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label96.Location = new System.Drawing.Point(4, 7);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(208, 17);
            this.label96.TabIndex = 201;
            this.label96.Text = "Data0:検出条件";
            // 
            // Form_peak
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.comboBox_peak);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.comboBox_detect);
            this.Controls.Add(this.label96);
            this.Name = "Form_peak";
            this.Size = new System.Drawing.Size(1140, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_peak;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.ComboBox comboBox_detect;
        private System.Windows.Forms.Label label96;
    }
}
