namespace Persone_file
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxID = new TextBox();
            textBoxN = new TextBox();
            textBoxS = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(73, 100);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 0;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(285, 100);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(125, 27);
            textBoxN.TabIndex = 1;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(487, 100);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(125, 27);
            textBoxS.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(588, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxS);
            Controls.Add(textBoxN);
            Controls.Add(textBoxID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private TextBox textBoxN;
        private TextBox textBoxS;
        private Button button1;
    }
}
