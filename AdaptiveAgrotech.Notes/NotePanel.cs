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
    }
}
