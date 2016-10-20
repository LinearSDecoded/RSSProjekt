namespace CSharpProject.Views
{
    partial class ChangeRemoveFeed
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxChangeNewName = new System.Windows.Forms.TextBox();
            this.TbxChangeNewUrl = new System.Windows.Forms.TextBox();
            this.CmbChangeCategory = new System.Windows.Forms.ComboBox();
            this.CmbChangeIntervals = new System.Windows.Forms.ComboBox();
            this.LbxRemoveFeed = new System.Windows.Forms.ListBox();
            this.BtnRemoveFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ändra/Radera Feeds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nytt Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ny URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uppdateringsintervall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategori";
            // 
            // tbxChangeNewName
            // 
            this.tbxChangeNewName.Location = new System.Drawing.Point(199, 32);
            this.tbxChangeNewName.Name = "tbxChangeNewName";
            this.tbxChangeNewName.Size = new System.Drawing.Size(100, 20);
            this.tbxChangeNewName.TabIndex = 5;
            this.tbxChangeNewName.TextChanged += new System.EventHandler(this.tbxChangeNewName_TextChanged);
            // 
            // TbxChangeNewUrl
            // 
            this.TbxChangeNewUrl.Location = new System.Drawing.Point(199, 83);
            this.TbxChangeNewUrl.Name = "TbxChangeNewUrl";
            this.TbxChangeNewUrl.Size = new System.Drawing.Size(100, 20);
            this.TbxChangeNewUrl.TabIndex = 6;
            this.TbxChangeNewUrl.TextChanged += new System.EventHandler(this.TbxChangeNewUrl_TextChanged);
            // 
            // CmbChangeCategory
            // 
            this.CmbChangeCategory.FormattingEnabled = true;
            this.CmbChangeCategory.Location = new System.Drawing.Point(199, 152);
            this.CmbChangeCategory.Name = "CmbChangeCategory";
            this.CmbChangeCategory.Size = new System.Drawing.Size(121, 21);
            this.CmbChangeCategory.TabIndex = 7;
            this.CmbChangeCategory.SelectedIndexChanged += new System.EventHandler(this.CmbChangeCategory_SelectedIndexChanged);
            // 
            // CmbChangeIntervals
            // 
            this.CmbChangeIntervals.FormattingEnabled = true;
            this.CmbChangeIntervals.Location = new System.Drawing.Point(199, 198);
            this.CmbChangeIntervals.Name = "CmbChangeIntervals";
            this.CmbChangeIntervals.Size = new System.Drawing.Size(121, 21);
            this.CmbChangeIntervals.TabIndex = 8;
            this.CmbChangeIntervals.SelectedIndexChanged += new System.EventHandler(this.CmbChangeIntervals_SelectedIndexChanged);
            // 
            // LbxRemoveFeed
            // 
            this.LbxRemoveFeed.FormattingEnabled = true;
            this.LbxRemoveFeed.Location = new System.Drawing.Point(12, 16);
            this.LbxRemoveFeed.Name = "LbxRemoveFeed";
            this.LbxRemoveFeed.Size = new System.Drawing.Size(127, 134);
            this.LbxRemoveFeed.TabIndex = 9;
            this.LbxRemoveFeed.SelectedIndexChanged += new System.EventHandler(this.LbxRemoveFeed_SelectedIndexChanged);
            // 
            // BtnRemoveFeed
            // 
            this.BtnRemoveFeed.Location = new System.Drawing.Point(48, 253);
            this.BtnRemoveFeed.Name = "BtnRemoveFeed";
            this.BtnRemoveFeed.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFeed.TabIndex = 10;
            this.BtnRemoveFeed.Text = "Radera";
            this.BtnRemoveFeed.UseVisualStyleBackColor = true;
            this.BtnRemoveFeed.Click += new System.EventHandler(this.BtnRemoveFeed_Click);
            // 
            // ChangeRemoveFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 320);
            this.Controls.Add(this.BtnRemoveFeed);
            this.Controls.Add(this.LbxRemoveFeed);
            this.Controls.Add(this.CmbChangeIntervals);
            this.Controls.Add(this.CmbChangeCategory);
            this.Controls.Add(this.TbxChangeNewUrl);
            this.Controls.Add(this.tbxChangeNewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeRemoveFeed";
            this.Text = "ChangeRemoveFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxChangeNewName;
        private System.Windows.Forms.TextBox TbxChangeNewUrl;
        private System.Windows.Forms.ComboBox CmbChangeCategory;
        private System.Windows.Forms.ComboBox CmbChangeIntervals;
        private System.Windows.Forms.ListBox LbxRemoveFeed;
        private System.Windows.Forms.Button BtnRemoveFeed;
    }
}