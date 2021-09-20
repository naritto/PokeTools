namespace ns_PokeCount
{
    partial class PokeMenuMini
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
            this.encount_all = new System.Windows.Forms.TextBox();
            this.plus_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pokename = new System.Windows.Forms.TextBox();
            this.dict_num = new System.Windows.Forms.TextBox();
            this.show_pic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encount_all
            // 
            this.encount_all.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.encount_all.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encount_all.Location = new System.Drawing.Point(107, 56);
            this.encount_all.Name = "encount_all";
            this.encount_all.Size = new System.Drawing.Size(132, 39);
            this.encount_all.TabIndex = 0;
            this.encount_all.Text = "0";
            this.encount_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.encount_all.TextChanged += new System.EventHandler(this.Encount_TextChanged);
            this.encount_all.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Encount_all_KeyPress);
            // 
            // plus_button
            // 
            this.plus_button.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus_button.Location = new System.Drawing.Point(257, 9);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(62, 53);
            this.plus_button.TabIndex = 2;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.Plus_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minus_button.Location = new System.Drawing.Point(257, 68);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(32, 27);
            this.minus_button.TabIndex = 3;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.Minus_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "遭遇：";
            // 
            // pokename
            // 
            this.pokename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pokename.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pokename.Location = new System.Drawing.Point(90, 11);
            this.pokename.Name = "pokename";
            this.pokename.ReadOnly = true;
            this.pokename.Size = new System.Drawing.Size(149, 34);
            this.pokename.TabIndex = 6;
            this.pokename.Text = "ポケモン名";
            this.pokename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pokename.TextChanged += new System.EventHandler(this.Pokename_TextChanged);
            // 
            // dict_num
            // 
            this.dict_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dict_num.Font = new System.Drawing.Font("Arial", 20F);
            this.dict_num.ForeColor = System.Drawing.Color.Black;
            this.dict_num.Location = new System.Drawing.Point(12, 9);
            this.dict_num.Name = "dict_num";
            this.dict_num.Size = new System.Drawing.Size(72, 38);
            this.dict_num.TabIndex = 7;
            this.dict_num.Text = "0";
            this.dict_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dict_num.TextChanged += new System.EventHandler(this.Dict_num_TextChanged);
            this.dict_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dict_num_KeyDown);
            this.dict_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dict_num_KeyPress);
            // 
            // show_pic
            // 
            this.show_pic.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.show_pic.Location = new System.Drawing.Point(295, 68);
            this.show_pic.Name = "show_pic";
            this.show_pic.Size = new System.Drawing.Size(24, 27);
            this.show_pic.TabIndex = 10;
            this.show_pic.UseVisualStyleBackColor = false;
            this.show_pic.Click += new System.EventHandler(this.Show_pic_Click);
            // 
            // PokeMenuMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.show_pic);
            this.Controls.Add(this.encount_all);
            this.Controls.Add(this.dict_num);
            this.Controls.Add(this.pokename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.plus_button);
            this.Name = "PokeMenuMini";
            this.Size = new System.Drawing.Size(330, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encount_all;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pokename;
        private System.Windows.Forms.TextBox dict_num;
        private System.Windows.Forms.Button show_pic;
    }
}

