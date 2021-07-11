using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdaptiveAgrotech.Notes
{
    public enum NoteSizes
    {
        HALF, NORMAL, DOUBLE, TALL
    }

    public partial class NotePanel : UserControl
    {
        Color accentColor = Color.Gold;


        public int NormalWidth { get; set; } = 300;
        public int NormalHeight { get; set; } = 350;
        public NoteSizes NoteSize
        {
            get; set;
        }
        public Color AccentColor
        {
            get
            {
                return accentColor;
            }
            set
            {
                panel.BackColor = richBody.BackColor = txtTitle.BackColor = value;

                if (!Utility.IsLight(value))
                {
                    panel.ForeColor = richBody.ForeColor = txtTitle.ForeColor = Color.Black;

                }
                else
                    panel.ForeColor = richBody.ForeColor = txtTitle.ForeColor = Color.White;


                accentColor = value;
            }
        }
        public NotePanel()
        {
            InitializeComponent();

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMore, new Point(0, btnMore.Height));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                AccentColor = color.Color;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action can't be undone,\nDo you want to remove the note?", "Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Parent.Controls.Remove(this);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = NormalWidth;
            this.Height = NormalHeight;
            toolNormal.Checked = toolDouble.Checked = toolHalf.Checked = toolTall.Checked = false;

            toolNormal.Checked = true;
        }

        private void NotePanel_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            txtTitle.SelectAll();
        }

        private void toolHalf_Click(object sender, EventArgs e)
        {
            this.Width = NormalWidth;
            this.Height = NormalHeight / 2;
            toolNormal.Checked = toolDouble.Checked = toolHalf.Checked = toolTall.Checked = false;
            toolHalf.Checked = true;
        }

        private void toolDouble_Click(object sender, EventArgs e)
        {
            this.Width = NormalWidth * 2;
            this.Height = NormalHeight;
            toolNormal.Checked = toolDouble.Checked = toolHalf.Checked = toolTall.Checked = false;
            toolDouble.Checked = true;
        }

        private void toolTall_Click(object sender, EventArgs e)
        {
            this.Width = NormalWidth;
            this.Height = NormalHeight * 2;
            toolNormal.Checked = toolDouble.Checked = toolHalf.Checked = toolTall.Checked = false;
            toolTall.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog()
            {
                Filter = "Text File|*.txt",
                FileName = txtTitle.Text
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                var content = txtTitle.Text + Environment.NewLine + "------------------------------" + Environment.NewLine +
                richBody.Text;

                File.WriteAllText(save.FileName, content);
                System.Diagnostics.Process.Start("notepad.exe", save.FileName);


            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var content = txtTitle.Text + Environment.NewLine + "------------------------------" + Environment.NewLine +
               richBody.Text;
            Clipboard.SetText(content);


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EditorFRM(richBody).Show();
        }
    }
}
