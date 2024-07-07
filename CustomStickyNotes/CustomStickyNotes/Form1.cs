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
            Application.ExitThread();
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
            Application.ExitThread();
        }

        private void openNewJournal(object sender, EventArgs e)
        {
            menuClick.Play();
            newJournalClicked = true;
            string _newJournalName = "Untitled";
            Form2 journalForm = new Form2(_newJournalName, newJournalClicked);
            journalForm.Show();
            //this.Hide(); // CHANGE TO CLOSE IN COMPILE
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openJournalBtn_Clicked(object sender, EventArgs e)
        {
            menuClick.Play();
            newJournalClicked = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files |*.txt";
            openFileDialog.Title = "Select Journal";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openJournName = System.IO.Path.GetFileName(openFileDialog.FileName);
                string openJournPath = openFileDialog.FileName;
                Form2 openJournalForm = new Form2(openJournName, newJournalClicked, openJournPath);
                openJournalForm.Show();
            }
        }
    }
}
