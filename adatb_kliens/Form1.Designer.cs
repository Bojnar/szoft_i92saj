namespace adatb_kliens
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
            buttonUserControl1 = new Button();
            buttonUserControl2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // buttonUserControl1
            // 
            buttonUserControl1.Location = new Point(12, 12);
            buttonUserControl1.Name = "buttonUserControl1";
            buttonUserControl1.Size = new Size(114, 102);
            buttonUserControl1.TabIndex = 0;
            buttonUserControl1.Text = "UserControl1";
            buttonUserControl1.UseVisualStyleBackColor = true;
            buttonUserControl1.Click += buttonUserControl1_Click;
            // 
            // buttonUserControl2
            // 
            buttonUserControl2.Location = new Point(12, 120);
            buttonUserControl2.Name = "buttonUserControl2";
            buttonUserControl2.Size = new Size(114, 109);
            buttonUserControl2.TabIndex = 1;
            buttonUserControl2.Text = "UserControl2";
            buttonUserControl2.UseVisualStyleBackColor = true;
            buttonUserControl2.Click += buttonUserControl2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(141, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 456);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 482);
            Controls.Add(panel1);
            Controls.Add(buttonUserControl2);
            Controls.Add(buttonUserControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUserControl1;
        private Button buttonUserControl2;
        private Panel panel1;
    }
}