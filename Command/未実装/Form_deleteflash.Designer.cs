namespace APP
{
    partial class Form_deleteflash
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
            this.checkBox_area4 = new System.Windows.Forms.CheckBox();
            this.checkBox_area3 = new System.Windows.Forms.CheckBox();
            this.checkBox_area2 = new System.Windows.Forms.CheckBox();
            this.checkBox_area1 = new System.Windows.Forms.CheckBox();
            this.label101 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_area4
            // 
            this.checkBox_area4.AutoSize = true;
            this.checkBox_area4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_area4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_area4.Location = new System.Drawing.Point(7, 129);
            this.checkBox_area4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_area4.Name = "checkBox_area4";
            this.checkBox_area4.Size = new System.Drawing.Size(156, 22);
            this.checkBox_area4.TabIndex = 245;
            this.checkBox_area4.Text = "エリア4(0xC00-0xFFF)";
            this.checkBox_area4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_area4.UseVisualStyleBackColor = true;
            // 
            // checkBox_area3
            // 
            this.checkBox_area3.AutoSize = true;
            this.checkBox_area3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_area3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_area3.Location = new System.Drawing.Point(7, 99);
            this.checkBox_area3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_area3.Name = "checkBox_area3";
            this.checkBox_area3.Size = new System.Drawing.Size(156, 22);
            this.checkBox_area3.TabIndex = 243;
            this.checkBox_area3.Text = "エリア3(0x800-0xBFF)";
            this.checkBox_area3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_area3.UseVisualStyleBackColor = true;
            // 
            // checkBox_area2
            // 
            this.checkBox_area2.AutoSize = true;
            this.checkBox_area2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_area2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_area2.Location = new System.Drawing.Point(8, 69);
            this.checkBox_area2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_area2.Name = "checkBox_area2";
            this.checkBox_area2.Size = new System.Drawing.Size(155, 22);
            this.checkBox_area2.TabIndex = 242;
            this.checkBox_area2.Text = "エリア2(0x400-0x7FF)";
            this.checkBox_area2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_area2.UseVisualStyleBackColor = true;
            // 
            // checkBox_area1
            // 
            this.checkBox_area1.AutoSize = true;
            this.checkBox_area1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_area1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_area1.Location = new System.Drawing.Point(8, 39);
            this.checkBox_area1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_area1.Name = "checkBox_area1";
            this.checkBox_area1.Size = new System.Drawing.Size(155, 22);
            this.checkBox_area1.TabIndex = 241;
            this.checkBox_area1.Text = "エリア1(0x000-0x3FF)";
            this.checkBox_area1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_area1.UseVisualStyleBackColor = true;
            // 
            // label101
            // 
            this.label101.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label101.Location = new System.Drawing.Point(4, 7);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(237, 17);
            this.label101.TabIndex = 240;
            this.label101.Text = "Data0:対象エリア(フラグ指定)";
            // 
            // Form_deleteflash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.checkBox_area4);
            this.Controls.Add(this.checkBox_area3);
            this.Controls.Add(this.checkBox_area2);
            this.Controls.Add(this.checkBox_area1);
            this.Controls.Add(this.label101);
            this.Name = "Form_deleteflash";
            this.Size = new System.Drawing.Size(1140, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_area4;
        private System.Windows.Forms.CheckBox checkBox_area3;
        private System.Windows.Forms.CheckBox checkBox_area2;
        private System.Windows.Forms.CheckBox checkBox_area1;
        private System.Windows.Forms.Label label101;
    }
}
