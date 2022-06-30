using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string st;
        private void Open(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(fd.FileName))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void Seiv(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(svf.FileName, false, Encoding.Default))
                {
                    writer.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Copi(object sender, EventArgs e)
        {
            st = richTextBox1.SelectedText;
        }

        private void Vstav(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = st;
        }

        private void Cat(object sender, EventArgs e)
        {
            st = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        private void SelectAll(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void stil1(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }

        private void stil2(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }

        private void stil3(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.DarkGreen;
            richTextBox1.ForeColor = Color.LightSkyBlue;
        }

        private void stilsh1(object sender, EventArgs e)
        {
            richTextBox1.Font = стиль1ToolStripMenuItem3.Font;
        }

        private void stilsh2(object sender, EventArgs e)
        {
            richTextBox1.Font = стиль2ToolStripMenuItem.Font;
        }

        private void stilsh3(object sender, EventArgs e)
        {
            richTextBox1.Font = стиль3ToolStripMenuItem.Font;
        }

        private void стильШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void стильToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
    }
}
