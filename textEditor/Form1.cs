using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace textEditor
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        int u = 0;
        int i = 0;
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
        }


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtbUpis.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbUpis.Clear();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    rtbUpis.Text = sr.ReadToEnd();
                    sr.Close();
                }
                
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(saveFile.FileName);
                txtoutput.Write(rtbUpis.Text);
                txtoutput.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtbUpis.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtbUpis.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtbUpis.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtbUpis.Undo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rtbUpis.Redo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllToolStripMenuItem.PerformClick();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Bold);
            n++;
            if (n == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                n = 0;
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Italic);
            i++;
            if (i == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                i = 0;
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Underline);
            u++;
            if (u == 2)
            {
                rtbUpis.SelectionFont = new Font(rtbUpis.Font, FontStyle.Regular);
                u = 0;
            }
        }
    }
}
