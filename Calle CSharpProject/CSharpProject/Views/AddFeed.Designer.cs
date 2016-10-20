namespace CSharpProject.Views
{
    partial class AddFeed
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddNewFeed = new System.Windows.Forms.Button();
            this.TbxAddNewName = new System.Windows.Forms.TextBox();
            this.TbxAddNewUrl = new System.Windows.Forms.TextBox();
            this.CmbAddNewCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbUppdateIntervals = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Välj Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skriv in URL här!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ny Feed";
            // 
            // BtnAddNewFeed
            // 
            this.BtnAddNewFeed.Location = new System.Drawing.Point(228, 114);
            this.BtnAddNewFeed.Name = "BtnAddNewFeed";
            this.BtnAddNewFeed.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNewFeed.TabIndex = 5;
            this.BtnAddNewFeed.Text = "Add";
            this.BtnAddNewFeed.UseVisualStyleBackColor = true;
            this.BtnAddNewFeed.Click += new System.EventHandler(this.BtnAddNewFeed_Click);
            // 
            // TbxAddNewName
            // 
            this.TbxAddNewName.Location = new System.Drawing.Point(25, 36);
            this.TbxAddNewName.Name = "TbxAddNewName";
            this.TbxAddNewName.Size = new System.Drawing.Size(100, 20);
            this.TbxAddNewName.TabIndex = 6;
            this.TbxAddNewName.TextChanged += new System.EventHandler(this.TbxAddNewName_TextChanged);
            // 
            // TbxAddNewUrl
            // 
            this.TbxAddNewUrl.Location = new System.Drawing.Point(25, 114);
            this.TbxAddNewUrl.Name = "TbxAddNewUrl";
            this.TbxAddNewUrl.Size = new System.Drawing.Size(100, 20);
            this.TbxAddNewUrl.TabIndex = 7;
            this.TbxAddNewUrl.TextChanged += new System.EventHandler(this.TbxAddNewUrl_TextChanged);
            // 
            // CmbAddNewCategory
            // 
            this.CmbAddNewCategory.FormattingEnabled = true;
            this.CmbAddNewCategory.Location = new System.Drawing.Point(25, 177);
            this.CmbAddNewCategory.Name = "CmbAddNewCategory";
            this.CmbAddNewCategory.Size = new System.Drawing.Size(85, 21);
            this.CmbAddNewCategory.TabIndex = 8;
            this.CmbAddNewCategory.SelectedIndexChanged += new System.EventHandler(this.CmbAddNewCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Klicka här för att skapa ny Feed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uppdateringsintervall";
            
            // 
            // CmbUppdateIntervals
            // 
            this.CmbUppdateIntervals.FormattingEnabled = true;
            this.CmbUppdateIntervals.Location = new System.Drawing.Point(255, 25);
            this.CmbUppdateIntervals.Name = "CmbUppdateIntervals";
            this.CmbUppdateIntervals.Size = new System.Drawing.Size(48, 21);
            this.CmbUppdateIntervals.TabIndex = 11;
            this.CmbUppdateIntervals.SelectedIndexChanged += new System.EventHandler(this.CmbUppdateIntervals_SelectedIndexChanged);
            // 
            // AddFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 326);
            this.Controls.Add(this.CmbUppdateIntervals);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAddNewCategory);
            this.Controls.Add(this.TbxAddNewUrl);
            this.Controls.Add(this.TbxAddNewName);
            this.Controls.Add(this.BtnAddNewFeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddFeed";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddNewFeed;
        private System.Windows.Forms.TextBox TbxAddNewName;
        private System.Windows.Forms.TextBox TbxAddNewUrl;
        private System.Windows.Forms.ComboBox CmbAddNewCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbUppdateIntervals;
    }
}