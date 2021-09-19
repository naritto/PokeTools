namespace ns_PokeCount
{
    partial class MenuBar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Config = new System.Windows.Forms.ToolStripMenuItem();
            this.CountTypesNumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType4 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType5 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType6 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType7 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType8 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountType9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ログ出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLogMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Config});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Config
            // 
            this.Config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountTypesNumMenuItem,
            this.ResetMenuItem,
            this.ログ出力ToolStripMenuItem});
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(58, 20);
            this.Config.Text = "表示(&V)";
            // 
            // CountTypesNumMenuItem
            // 
            this.CountTypesNumMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountType1,
            this.CountType2,
            this.CountType3,
            this.CountType4,
            this.CountType5,
            this.CountType6,
            this.CountType7,
            this.CountType8,
            this.CountType9});
            this.CountTypesNumMenuItem.Name = "CountTypesNumMenuItem";
            this.CountTypesNumMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CountTypesNumMenuItem.Text = "同時表示件数";
            // 
            // CountType1
            // 
            this.CountType1.Name = "CountType1";
            this.CountType1.Size = new System.Drawing.Size(80, 22);
            this.CountType1.Text = "1";
            this.CountType1.Click += new System.EventHandler(this.CountType1_Click);
            // 
            // CountType2
            // 
            this.CountType2.Name = "CountType2";
            this.CountType2.Size = new System.Drawing.Size(80, 22);
            this.CountType2.Text = "2";
            this.CountType2.Click += new System.EventHandler(this.CountType2_Click);
            // 
            // CountType3
            // 
            this.CountType3.Name = "CountType3";
            this.CountType3.Size = new System.Drawing.Size(80, 22);
            this.CountType3.Text = "3";
            this.CountType3.Click += new System.EventHandler(this.CountType3_Click);
            // 
            // CountType4
            // 
            this.CountType4.Name = "CountType4";
            this.CountType4.Size = new System.Drawing.Size(80, 22);
            this.CountType4.Text = "4";
            this.CountType4.Click += new System.EventHandler(this.CountType4_Click);
            // 
            // CountType5
            // 
            this.CountType5.Name = "CountType5";
            this.CountType5.Size = new System.Drawing.Size(80, 22);
            this.CountType5.Text = "5";
            this.CountType5.Click += new System.EventHandler(this.CountType5_Click);
            // 
            // CountType6
            // 
            this.CountType6.Name = "CountType6";
            this.CountType6.Size = new System.Drawing.Size(80, 22);
            this.CountType6.Text = "6";
            this.CountType6.Click += new System.EventHandler(this.CountType6_Click);
            // 
            // CountType7
            // 
            this.CountType7.Name = "CountType7";
            this.CountType7.Size = new System.Drawing.Size(80, 22);
            this.CountType7.Text = "7";
            this.CountType7.Click += new System.EventHandler(this.CountType7_Click);
            // 
            // CountType8
            // 
            this.CountType8.Name = "CountType8";
            this.CountType8.Size = new System.Drawing.Size(80, 22);
            this.CountType8.Text = "8";
            this.CountType8.Click += new System.EventHandler(this.CountType8_Click);
            // 
            // CountType9
            // 
            this.CountType9.Name = "CountType9";
            this.CountType9.Size = new System.Drawing.Size(80, 22);
            this.CountType9.Text = "9";
            this.CountType9.Click += new System.EventHandler(this.CountType9_Click);
            // 
            // ResetMenuItem
            // 
            this.ResetMenuItem.Name = "ResetMenuItem";
            this.ResetMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ResetMenuItem.Text = "リセット";
            this.ResetMenuItem.Click += new System.EventHandler(this.ResetMenuItem_Click);
            // 
            // ログ出力ToolStripMenuItem
            // 
            this.ログ出力ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLogMenuBar,
            this.saveLogMenuBar});
            this.ログ出力ToolStripMenuItem.Name = "ログ出力ToolStripMenuItem";
            this.ログ出力ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ログ出力ToolStripMenuItem.Text = "ログ";
            // 
            // loadLogMenuBar
            // 
            this.loadLogMenuBar.Name = "loadLogMenuBar";
            this.loadLogMenuBar.Size = new System.Drawing.Size(180, 22);
            this.loadLogMenuBar.Text = "ファイルから読み込み";
            this.loadLogMenuBar.Click += new System.EventHandler(this.loadLogMenuBar_Click);
            // 
            // saveLogMenuBar
            // 
            this.saveLogMenuBar.Name = "saveLogMenuBar";
            this.saveLogMenuBar.Size = new System.Drawing.Size(180, 22);
            this.saveLogMenuBar.Text = "ファイルへ保存";
            this.saveLogMenuBar.Click += new System.EventHandler(this.saveLogMenuBar_Click);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(328, 25);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Config;
        private System.Windows.Forms.ToolStripMenuItem CountTypesNumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountType1;
        private System.Windows.Forms.ToolStripMenuItem CountType2;
        private System.Windows.Forms.ToolStripMenuItem CountType3;
        private System.Windows.Forms.ToolStripMenuItem CountType4;
        private System.Windows.Forms.ToolStripMenuItem CountType5;
        private System.Windows.Forms.ToolStripMenuItem CountType6;
        private System.Windows.Forms.ToolStripMenuItem CountType7;
        private System.Windows.Forms.ToolStripMenuItem CountType8;
        private System.Windows.Forms.ToolStripMenuItem CountType9;
        private System.Windows.Forms.ToolStripMenuItem ResetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ログ出力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLogMenuBar;
        private System.Windows.Forms.ToolStripMenuItem saveLogMenuBar;
    }
}
