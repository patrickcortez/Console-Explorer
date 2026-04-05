using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class Editior : Form
    {
        private string fpath;
        private bool currEmpty = false,changes = false;
        
        public Editior(string tpath)
        {
            InitializeComponent();
            fpath = tpath;

            if (string.IsNullOrEmpty(fpath))
            {
                currEmpty = true;
            }
            else
            {

                rtb_edit.Text = File.ReadAllText(fpath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currEmpty == true)
            {
                MessageBox.Show("Cannot Save without File Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                File.WriteAllText(fpath, rtb_edit.Text);
            }

            changes = false;
        }

         ~Editior()
        {
            changes = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changes)
            {
               DialogResult res = MessageBox.Show("Are you sure you wont save your changes?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(res == DialogResult.Yes)
                {
                    if (currEmpty)
                    {
                        saveAsToolStripMenuItem.PerformClick();
                    }
                    else
                    {
                        saveToolStripMenuItem.PerformClick();
                    }
                }
                else
                {
                    this.Close();
                }
            }

            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
                using (SaveFileDialog save1 = new SaveFileDialog()) {
                    save1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    save1.Title = "Save File As";

                    if(save1.ShowDialog() == DialogResult.OK)
                    {

                        File.WriteAllText(fpath, rtb_edit.Text);
                  
                    }

                    
                }
            changes = false;
            
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = default;
            this.ForeColor = default;
            rtb_edit.ForeColor = default;
            rtb_edit.BackColor = default;
            mn_editor.BackColor = default;
            mn_editor.ForeColor = default;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.Black;
            rtb_edit.ForeColor = Color.White;
            rtb_edit.BackColor = Color.Black;

        }

        private void aboutConsoleExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A C# Application made by Cortez," + Environment.NewLine + "A 3rd year Computer Engineering Student.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editior_Load(object sender, EventArgs e)
        {

        }

        private void rtb_edit_TextChanged(object sender, EventArgs e)
        {
            changes = true;
        }

        private void Editior_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Q)
            {
                e.Handled = true;
                this.Close();

            }else if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                saveToolStripMenuItem.PerformClick();
            }else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                saveAsToolStripMenuItem.PerformClick();
            }
        }
    }
}
