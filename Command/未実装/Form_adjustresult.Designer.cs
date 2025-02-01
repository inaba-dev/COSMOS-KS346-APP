namespace APP
{
    partial class Form_adjustresult
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
            this.comboBox_concspecies = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.comboBox_adjustspecies = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.comboBox_gas_10 = new System.Windows.Forms.ComboBox();
            this.label73 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_concspecies
            // 
            this.comboBox_concspecies.BackColor = System.Drawing.Color.White;
            this.comboBox_concspecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_concspecies.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_concspecies.FormattingEnabled = true;
            this.comboBox_concspecies.Items.AddRange(new object[] {
            "低濃度用調整値",
            "高濃度用調整値"});
            this.comboBox_concspecies.Location = new System.Drawing.Point(8, 200);
            this.comboBox_concspecies.Name = "comboBox_concspecies";
            this.comboBox_concspecies.Size = new System.Drawing.Size(119, 26);
            this.comboBox_concspecies.TabIndex = 152;
            // 
            // label75
            // 
            this.label75.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label75.Location = new System.Drawing.Point(4, 180);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(139, 17);
            this.label75.TabIndex = 111;
            this.label75.Text = "Data2:濃度種別";
            // 
            // comboBox_adjustspecies
            // 
            this.comboBox_adjustspecies.BackColor = System.Drawing.Color.White;
            this.comboBox_adjustspecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_adjustspecies.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_adjustspecies.FormattingEnabled = true;
            this.comboBox_adjustspecies.Items.AddRange(new object[] {
            "ベース調整",
            "スパン調整(調整ポイント1)",
            "スパン調整(調整ポイント2)",
            "スパン調整(調整ポイント3)",
            "スパン調整(調整ポイント4)",
            "スパン調整(調整ポイント5)",
            "スパン調整(調整ポイント6)",
            "スパン調整(調整ポイント7)",
            "スパン調整(調整ポイント8)",
            "スパン調整(濃度指定)",
            "予約",
            "エア調整(酸素23.0vol%)"});
            this.comboBox_adjustspecies.Location = new System.Drawing.Point(8, 113);
            this.comboBox_adjustspecies.Name = "comboBox_adjustspecies";
            this.comboBox_adjustspecies.Size = new System.Drawing.Size(213, 26);
            this.comboBox_adjustspecies.TabIndex = 151;
            this.comboBox_adjustspecies.SelectedIndexChanged += new System.EventHandler(this.comboBox_adjustspecies_SelectedIndexChanged);
            // 
            // label74
            // 
            this.label74.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label74.Location = new System.Drawing.Point(4, 93);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(139, 17);
            this.label74.TabIndex = 109;
            this.label74.Text = "Data1:調整種別";
            // 
            // comboBox_gas_10
            // 
            this.comboBox_gas_10.BackColor = System.Drawing.Color.White;
            this.comboBox_gas_10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gas_10.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_gas_10.FormattingEnabled = true;
            this.comboBox_gas_10.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_gas_10.Location = new System.Drawing.Point(8, 27);
            this.comboBox_gas_10.Name = "comboBox_gas_10";
            this.comboBox_gas_10.Size = new System.Drawing.Size(119, 26);
            this.comboBox_gas_10.TabIndex = 150;
            // 
            // label73
            // 
            this.label73.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label73.Location = new System.Drawing.Point(4, 7);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(139, 17);
            this.label73.TabIndex = 107;
            this.label73.Text = "Data0:ガス種No";
            // 
            // Form_adjustresult
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.comboBox_concspecies);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.comboBox_adjustspecies);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.comboBox_gas_10);
            this.Controls.Add(this.label73);
            this.Name = "Form_adjustresult";
            this.Size = new System.Drawing.Size(1140, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_concspecies;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox comboBox_adjustspecies;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox comboBox_gas_10;
        private System.Windows.Forms.Label label73;
    }
}
