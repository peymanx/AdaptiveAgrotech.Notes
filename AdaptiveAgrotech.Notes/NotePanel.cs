using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
