namespace DB_people
{
    partial class Form1
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
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.sur_TB = new System.Windows.Forms.TextBox();
            this.nam_TB = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.listPeople = new System.Windows.Forms.ListBox();
            this.buttonRM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(56, 127);
            this.ID_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(76, 20);
            this.ID_TB.TabIndex = 3;
            // 
            // sur_TB
            // 
            this.sur_TB.Location = new System.Drawing.Point(168, 127);
            this.sur_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sur_TB.Name = "sur_TB";
            this.sur_TB.Size = new System.Drawing.Size(76, 20);
            this.sur_TB.TabIndex = 4;
            // 
            // nam_TB
            // 
            this.nam_TB.Location = new System.Drawing.Point(289, 127);
            this.nam_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nam_TB.Name = "nam_TB";
            this.nam_TB.Size = new System.Drawing.Size(76, 20);
            this.nam_TB.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(428, 192);
            this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 50);
            this.add.TabIndex = 6;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(428, 264);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 50);
            this.search.TabIndex = 7;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.Location = new System.Drawing.Point(56, 192);
            this.listPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(308, 134);
            this.listPeople.TabIndex = 8;
            // 
            // buttonRM
            // 
            this.buttonRM.Location = new System.Drawing.Point(428, 127);
            this.buttonRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRM.Name = "buttonRM";
            this.buttonRM.Size = new System.Drawing.Size(120, 50);
            this.buttonRM.TabIndex = 9;
            this.buttonRM.Text = "Remove";
            this.buttonRM.UseVisualStyleBackColor = true;
            this.buttonRM.Click += new System.EventHandler(this.buttonRM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonRM);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.search);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nam_TB);
            this.Controls.Add(this.sur_TB);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.TextBox sur_TB;
        private System.Windows.Forms.TextBox nam_TB;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.Button buttonRM;
    }
}

