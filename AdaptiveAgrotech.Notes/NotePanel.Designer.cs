namespace AdaptiveAgrotech.Notes
{
    partial class NotePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.richBody = new System.Windows.Forms.RichTextBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Gold;
            this.panel.Controls.Add(this.richBody);
            this.panel.Controls.Add(this.btnMore);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Location = new System.Drawing.Point(14, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(376, 453);
            this.panel.TabIndex = 17;
            // 
            // richBody
            // 
            this.richBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richBody.BackColor = System.Drawing.Color.Gold;
            this.richBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richBody.Location = new System.Drawing.Point(14, 51);
            this.richBody.Name = "richBody";
            this.richBody.Size = new System.Drawing.Size(350, 389);
            this.richBody.TabIndex = 2;
            this.richBody.Text = "Project 01: xxxxxxxxxxxxxxxxxxx\nProject 02: xxxxxxxxxxxxxxxxxxx\nProject 03: xxxxx" +
    "xxxxxxxxxxxxxx\n";
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Location = new System.Drawing.Point(319, 11);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(45, 34);
            this.btnMore.TabIndex = 1;
            this.btnMore.Text = "...";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.Gold;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(14, 11);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(299, 34);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Label01";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel);
            this.Name = "NotePanel";
            this.Size = new System.Drawing.Size(404, 466);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox richBody;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
