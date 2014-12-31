namespace myNotes
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
            this.codeRTB = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.csharpLB = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.noteTitleTB = new System.Windows.Forms.TextBox();
            this.notesRTB = new System.Windows.Forms.RichTextBox();
            this.vbLB = new System.Windows.Forms.ListBox();
            this.genLB = new System.Windows.Forms.ListBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeRTB
            // 
            this.codeRTB.Location = new System.Drawing.Point(684, 13);
            this.codeRTB.Name = "codeRTB";
            this.codeRTB.Size = new System.Drawing.Size(360, 382);
            this.codeRTB.TabIndex = 0;
            this.codeRTB.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 382);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.csharpLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CSharp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // csharpLB
            // 
            this.csharpLB.FormattingEnabled = true;
            this.csharpLB.Location = new System.Drawing.Point(4, 7);
            this.csharpLB.Name = "csharpLB";
            this.csharpLB.Size = new System.Drawing.Size(297, 342);
            this.csharpLB.TabIndex = 0;
            this.csharpLB.SelectedIndexChanged += new System.EventHandler(this.csharpLB_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vbLB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visual Basic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.genLB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(307, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "General";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save the note to the current tab?";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(506, 371);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // noteTitleTB
            // 
            this.noteTitleTB.Location = new System.Drawing.Point(334, 12);
            this.noteTitleTB.Name = "noteTitleTB";
            this.noteTitleTB.Size = new System.Drawing.Size(344, 20);
            this.noteTitleTB.TabIndex = 5;
            // 
            // notesRTB
            // 
            this.notesRTB.Location = new System.Drawing.Point(335, 39);
            this.notesRTB.Name = "notesRTB";
            this.notesRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesRTB.Size = new System.Drawing.Size(343, 326);
            this.notesRTB.TabIndex = 6;
            this.notesRTB.Text = "";
            // 
            // vbLB
            // 
            this.vbLB.FormattingEnabled = true;
            this.vbLB.Location = new System.Drawing.Point(5, 7);
            this.vbLB.Name = "vbLB";
            this.vbLB.Size = new System.Drawing.Size(296, 342);
            this.vbLB.TabIndex = 1;
            this.vbLB.SelectedIndexChanged += new System.EventHandler(this.vbLB_SelectedIndexChanged);
            // 
            // genLB
            // 
            this.genLB.FormattingEnabled = true;
            this.genLB.Location = new System.Drawing.Point(5, 7);
            this.genLB.Name = "genLB";
            this.genLB.Size = new System.Drawing.Size(299, 342);
            this.genLB.TabIndex = 1;
            this.genLB.SelectedIndexChanged += new System.EventHandler(this.genLB_SelectedIndexChanged);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(587, 371);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 1;
            this.clearBTN.Text = "Clear All";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 407);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.notesRTB);
            this.Controls.Add(this.noteTitleTB);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.codeRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Software Notes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox codeRTB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox csharpLB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.TextBox noteTitleTB;
        private System.Windows.Forms.RichTextBox notesRTB;
        private System.Windows.Forms.ListBox vbLB;
        private System.Windows.Forms.ListBox genLB;
        private System.Windows.Forms.Button clearBTN;
    }
}

