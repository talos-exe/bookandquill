using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomStickyNotes
{
    public partial class Form1 : Form
    {
        private SoundPlayer menuClick = new SoundPlayer("uiclick.wav");
        bool newJournalClicked = false;

        public Form1()
        {
            InitializeComponent();
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)

        {
            if (!newJournalClicked)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void expandButtons(object sender, MouseEventArgs e)
        {

        }

        private void mouseEnterToolStripLabel(object sender, EventArgs e)
        {
            Label getLabel = (Label)sender;
            getLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void mouseLeaveToolStripLabel(object sender, EventArgs e)
        {
            Label getLabel = (Label)sender;
            getLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void promptForQuit(object sender, EventArgs e)
        {
            menuClick.Play();
            if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void openNewJournal(object sender, EventArgs e)
        {
            menuClick.Play();
            newJournalClicked = true;
            Form2 journalForm = new Form2();
            journalForm.Show();
            //this.Hide(); // CHANGE TO CLOSE IN COMPILE
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
