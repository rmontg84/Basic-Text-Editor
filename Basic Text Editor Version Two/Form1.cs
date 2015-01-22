using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_Text_Editor_Version_Two
{
    public partial class txtMain : Form
    {
        public txtMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextToDisplay.Clear();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            
            TextToDisplay.Text = OpenFile.ReadToEnd();
            
            OpenFile.Close();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.ShowDialog();
            System.IO.StreamWriter saveFile = new System.IO.StreamWriter(saveDialog.FileName);
            
            saveFile.WriteLine(TextToDisplay.Text);
            
            saveFile.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
