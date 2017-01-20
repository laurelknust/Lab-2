namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(322, 24);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(152, 22);
            this.uxOpen.Text = "Open";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(152, 22);
            this.uxSaveAs.Text = "Save As";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(12, 27);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(298, 201);
            this.uxTextBox.TabIndex = 1;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 240);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

