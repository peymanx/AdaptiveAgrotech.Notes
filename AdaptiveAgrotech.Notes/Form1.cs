﻿using System;
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
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var note = new NotePanel();
            Color randomColor = Color.FromArgb(rnd.Next(100,256), rnd.Next(256), rnd.Next(256));
            note.AccentColor = randomColor;
            MainPanel.Controls.Add(note);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }
    }
}
