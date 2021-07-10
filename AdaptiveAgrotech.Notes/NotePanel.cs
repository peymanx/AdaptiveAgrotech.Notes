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
    public partial class NotePanel : UserControl
    {
        Color accentColor = Color.Gold;
        public Color AccentColor
        {
            get
            {
                return accentColor;
            }
            set
            {
               panel.BackColor =  richBody.BackColor = txtTitle.BackColor = value;

                accentColor = value;
            }
        }
        public NotePanel()
        {
            InitializeComponent();
           
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMore, new Point(0, btnMore.Height)) ;
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
    }
}
