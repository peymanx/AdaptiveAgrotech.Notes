using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaptiveAgrotech.Notes
{
    public partial class MainFRM : Form
    {
        private Random rnd = new Random();

        public MainFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewNote();
        }

        private void NewNote(string title = "", string body = "")
        {
            var note = new NotePanel();
            note.Width = note.NormalWidth;
            note.Height = note.NormalHeight;
            if (title.Length > 0)
                note.txtTitle.Text = title;
            if (body.Length > 0)
                note.richBody.Text = body;
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            note.AccentColor = randomColor;
            MainPanel.Controls.Add(note);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog()
            {
                Filter = "Text File|*.txt"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                var title = "";
                var content = "";

                try
                {
                    title = open.FileName.Split('\\').LastOrDefault();
                }
                catch
                {

                    title = open.FileName;
                }

                try
                {
                    content = File.ReadAllText(open.FileName);
                }
                catch (Exception exx)
                {
                    content = exx.Message;

                }

                NewNote(title, content);



            }
        }
    }
}
