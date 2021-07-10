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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.richBody = new System.Windows.Forms.RichTextBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHalf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Gold;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.richBody);
            this.panel.Controls.Add(this.btnMore);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Location = new System.Drawing.Point(11, 11);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(338, 388);
            this.panel.TabIndex = 17;
            // 
            // richBody
            // 
            this.richBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richBody.BackColor = System.Drawing.Color.Gold;
            this.richBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richBody.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.richBody.Location = new System.Drawing.Point(13, 49);
            this.richBody.Name = "richBody";
            this.richBody.Size = new System.Drawing.Size(309, 321);
            this.richBody.TabIndex = 2;
            this.richBody.Text = "Project 01: xxxxxxxxxxxxxxxxxxx\nProject 02: xxxxxxxxxxxxxxxxxxx\nProject 03: xxxxx" +
    "xxxxxxxxxxxxxx\n";
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMore.Location = new System.Drawing.Point(279, 8);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(45, 30);
            this.btnMore.TabIndex = 1;
            this.btnMore.Text = "...";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.Gold;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(12, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 30);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Label01";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.sizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem5,
            this.toolStripSeparator3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 218);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem1.Text = "Open in new window";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem6.Text = "Set Color";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHalf,
            this.toolNormal,
            this.toolDouble,
            this.toolTall});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // toolHalf
            // 
            this.toolHalf.Name = "toolHalf";
            this.toolHalf.Size = new System.Drawing.Size(216, 26);
            this.toolHalf.Text = "Half";
            this.toolHalf.Click += new System.EventHandler(this.toolHalf_Click);
            // 
            // toolNormal
            // 
            this.toolNormal.Checked = true;
            this.toolNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolNormal.Name = "toolNormal";
            this.toolNormal.Size = new System.Drawing.Size(216, 26);
            this.toolNormal.Text = "Normal";
            this.toolNormal.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // toolDouble
            // 
            this.toolDouble.Name = "toolDouble";
            this.toolDouble.Size = new System.Drawing.Size(216, 26);
            this.toolDouble.Text = "Double";
            this.toolDouble.Click += new System.EventHandler(this.toolDouble_Click);
            // 
            // toolTall
            // 
            this.toolTall.Name = "toolTall";
            this.toolTall.Size = new System.Drawing.Size(216, 26);
            this.toolTall.Text = "Tall";
            this.toolTall.Visible = false;
            this.toolTall.Click += new System.EventHandler(this.toolTall_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem2.Text = "Export as text...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem3.Text = "Export as Word...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem5.Text = "Copy to Cipboard";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem4.Text = "Delete";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // NotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "NotePanel";
            this.Size = new System.Drawing.Size(350, 400);
            this.Load += new System.EventHandler(this.NotePanel_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox richBody;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolHalf;
        private System.Windows.Forms.ToolStripMenuItem toolNormal;
        private System.Windows.Forms.ToolStripMenuItem toolDouble;
        private System.Windows.Forms.ToolStripMenuItem toolTall;
    }
}
