using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaptiveAgrotech.Notes
{
    public partial class EditorFRM : Form
    {
        public EditorFRM(RichTextBox richTextBox)
        {
            InitializeComponent();

            richBody.Text = richTextBox.Text;
        }

        private void EditorFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
