namespace AdaptiveAgrotech.Notes
{
    partial class EditorFRM
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
            this.richBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richBody
            // 
            this.richBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBody.Location = new System.Drawing.Point(0, 0);
            this.richBody.Name = "richBody";
            this.richBody.Size = new System.Drawing.Size(685, 644);
            this.richBody.TabIndex = 0;
            this.richBody.Text = "";
            // 
            // EditorFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 644);
            this.Controls.Add(this.richBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditorFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditorFRM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBody;
    }
}