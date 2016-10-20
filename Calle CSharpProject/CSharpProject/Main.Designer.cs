namespace CSharpProject
{
    partial class Main
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
            this.BtnPLay = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddFeed = new System.Windows.Forms.Button();
            this.BtnChangeRemoveFeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPLay
            // 
            this.BtnPLay.Location = new System.Drawing.Point(143, 89);
            this.BtnPLay.Name = "BtnPLay";
            this.BtnPLay.Size = new System.Drawing.Size(162, 60);
            this.BtnPLay.TabIndex = 0;
            this.BtnPLay.Text = "Spela";
            this.BtnPLay.UseVisualStyleBackColor = true;
            this.BtnPLay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnCategory
            // 
            this.BtnCategory.Location = new System.Drawing.Point(311, 166);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(122, 71);
            this.BtnCategory.TabIndex = 1;
            this.BtnCategory.Text = "Kategori";
            this.BtnCategory.UseVisualStyleBackColor = true;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnAddFeed
            // 
            this.BtnAddFeed.Location = new System.Drawing.Point(12, 166);
            this.BtnAddFeed.Name = "BtnAddFeed";
            this.BtnAddFeed.Size = new System.Drawing.Size(122, 71);
            this.BtnAddFeed.TabIndex = 2;
            this.BtnAddFeed.Text = "Lägg till Feed";
            this.BtnAddFeed.UseVisualStyleBackColor = true;
            this.BtnAddFeed.Click += new System.EventHandler(this.BtnAddFeed_Click);
            // 
            // BtnChangeRemoveFeed
            // 
            this.BtnChangeRemoveFeed.Location = new System.Drawing.Point(165, 253);
            this.BtnChangeRemoveFeed.Name = "BtnChangeRemoveFeed";
            this.BtnChangeRemoveFeed.Size = new System.Drawing.Size(127, 79);
            this.BtnChangeRemoveFeed.TabIndex = 3;
            this.BtnChangeRemoveFeed.Text = "Ändra/ Ta Bort Feed";
            this.BtnChangeRemoveFeed.UseVisualStyleBackColor = true;
            this.BtnChangeRemoveFeed.Click += new System.EventHandler(this.BtnChangeRemoveFeed_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(199, 29);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podcast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uppdatera.. var god vänta";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChangeRemoveFeed);
            this.Controls.Add(this.BtnAddFeed);
            this.Controls.Add(this.BtnCategory);
            this.Controls.Add(this.BtnPLay);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPLay;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnAddFeed;
        private System.Windows.Forms.Button BtnChangeRemoveFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}