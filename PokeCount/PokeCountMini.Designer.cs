namespace ns_PokeCount
{
    partial class PokeCountMini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.total_label = new System.Windows.Forms.Label();
            this.total_num_label = new System.Windows.Forms.Label();
            this.menuBar1 = new ns_PokeCount.MenuBar();
            this.SuspendLayout();
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.total_label.Location = new System.Drawing.Point(12, 39);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(98, 33);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "合計：";
            // 
            // total_num_label
            // 
            this.total_num_label.AutoSize = true;
            this.total_num_label.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.total_num_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.total_num_label.Location = new System.Drawing.Point(116, 39);
            this.total_num_label.Name = "total_num_label";
            this.total_num_label.Size = new System.Drawing.Size(32, 33);
            this.total_num_label.TabIndex = 2;
            this.total_num_label.Text = "0";
            // 
            // menuBar1
            // 
            this.menuBar1.Location = new System.Drawing.Point(0, -1);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(647, 25);
            this.menuBar1.TabIndex = 0;
            // 
            // PokeCountMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 1061);
            this.Controls.Add(this.total_num_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.menuBar1);
            this.Name = "PokeCountMini";
            this.Text = "PokeCount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuBar menuBar1;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label total_num_label;
    }
}