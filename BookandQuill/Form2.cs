using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using System.Linq.Expressions;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace CustomStickyNotes
{

    public partial class Form2 : Form
    {

        private SoundPlayer flipPageOne;
        private SoundPlayer flipPageTwo;
        private SoundPlayer flipPageThree;
        private CustomRTB _customRTB = new CustomRTB();
        private bool _customRTBTextChanged = false;
        private int pageIndex;
        private int maxPages;
        private int lrAnswer;
        private string[] journalEntries = new string[100];
        private string journalTitle;
        private bool journalNewOrOldSelect;
        private string journalPath;
        private string saveJournalPath;

        public Form2(string journalName, bool _newJournal_, string journalPath)
        {
            InitializeComponent();
            this.Controls.Add(_customRTB);
            this.Text = journalName + " - Book and Quill";
            DoubleBuffered = true;
            KeyPreview = true;
            nextPageBtn.BackgroundImage = (System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn);
            backPageBtn.BackgroundImage = (System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn2);
            backPageBtn.Visible = false;
            flipPageOne = new SoundPlayer("flip1.wav");
            flipPageTwo = new SoundPlayer("flip2.wav");
            flipPageThree = new SoundPlayer("flip3.wav");
            this.journalTitle = journalName;
            this.journalNewOrOldSelect = _newJournal_;
            this.journalPath = journalPath;


        }

        public Form2(string journalName, bool _newJournal_)
        {
            InitializeComponent();
            this.Controls.Add(_customRTB);
            this.Text = journalName + " - Book and Quill";
            DoubleBuffered = true;
            KeyPreview = true;
            nextPageBtn.BackgroundImage = (System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn);
            backPageBtn.BackgroundImage = (System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn2);
            backPageBtn.Visible = false;
            flipPageOne = new SoundPlayer("flip1.wav");
            flipPageTwo = new SoundPlayer("flip2.wav");
            flipPageThree = new SoundPlayer("flip3.wav");
            this.journalTitle = journalName;
            this.journalNewOrOldSelect = _newJournal_;

        }


        private void loadcustomRTB()
        {
            _customRTB.Location = new System.Drawing.Point(45, 79);
            _customRTB.Size = new System.Drawing.Size(340, 378);
            _customRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _customRTB.Font = new System.Drawing.Font("Monocraft", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _customRTB.ForeColor = System.Drawing.SystemColors.ControlText;
            _customRTB.Name = "customRTB";
            _customRTB.Text = "";
            _customRTB.TabIndex = 0;
            _customRTB.MaxLength = 230;
            _customRTB.ScrollBars = RichTextBoxScrollBars.None;
            _customRTB.Multiline = true;
        }

        private void loadPageNumbers()
        {
            pageIndex = 0;
            maxPages = 0;
            label1.Text = "Page " + (pageIndex + 1).ToString() + " of " + (maxPages + 1).ToString();

        }

        private void updatePageNumbers(int lr)
        {

            // Page Counting Logic, Max Page int is 99, Page index cannot go below 0.
            // Checks for left right button use. If lr = 0, its next page. If lr = 1, its going back a page.
            if (lr == 0)
            {
                if (pageIndex == maxPages) // Check if index is equal to the max
                {
                    journalEntries[pageIndex] = _customRTB.Text;
                    pageIndex++;
                    maxPages++;
                    label1.Text = "Page " + (pageIndex + 1).ToString() + " of " + (maxPages + 1).ToString();
                    _customRTB.Text = "";
                }
                else if (pageIndex < maxPages) // Check if index is less than the max
                {
                    journalEntries[pageIndex] = _customRTB.Text;
                    pageIndex++;
                    _customRTB.Text = journalEntries[pageIndex].ToString();
                    label1.Text = "Page " + (pageIndex + 1).ToString() + " of " + (maxPages + 1).ToString();
                }



            }
            else if (lr == 1)
            {
                if (pageIndex > 0 && pageIndex <= maxPages)
                {
                    journalEntries[pageIndex] = _customRTB.Text;
                    pageIndex--;
                    label1.Text = "Page " + (pageIndex + 1).ToString() + " of " + (maxPages + 1).ToString();
                    _customRTB.Text = journalEntries[pageIndex].ToString();
                }
            }

            //Update button visibility if-else statements
            if (pageIndex == 0) { backPageBtn.Visible = false; } else { backPageBtn.Visible = true; }
            if (pageIndex == 99) { nextPageBtn.Visible = false; } else { nextPageBtn.Visible = true; }


            //Update Label Switch Case
            switch (maxPages)
            {
                case 0:
                    label1.Left = 200;
                    break;
                case 9:
                    label1.Left = 180;
                    break;
                case 99:
                    label1.Left = 150;
                    break;
            }

            //Console.WriteLine("Page index: " + pageIndex +"\nMax pages: "+maxPages);

        }

        private void customRTBTextChanged(object sender, EventArgs e)
        {
            // On Journal Text changed, update entries and enable boolean for saving functionality
            _customRTBTextChanged = true;
            journalEntries[pageIndex] = _customRTB.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcustomRTB();
            loadPageNumbers();
            loadPages();
        }

        private void loadPages()
        {
            if (!journalNewOrOldSelect)
            {
                // If journal is old, load old pages from text file.
                try
                {
                    using (StreamReader sr = new StreamReader(journalPath))
                    {
                        for (int i = 0; i < journalEntries.Length; i++)
                        {
                            string line = sr.ReadLine();
                            if (line != null)
                            {
                                journalEntries[i] = line;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be read.");
                }


            }
            else
            {
                // If journal is new, do nothing.
            }
        }

        private void nextPageBtn_mouseLeave(object sender, EventArgs e)
        {
            nextPageBtn.BackgroundImage = ((System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn));
        }

        private void nextPageBtn_mouseEnter(object sender, EventArgs e)
        {
            nextPageBtn.BackgroundImage = ((System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtnmouseovert));
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            lrAnswer = 0;
            flipPageOne.Play();
            updatePageNumbers(lrAnswer);
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            lrAnswer = 1;
            flipPageTwo.Play();
            updatePageNumbers(lrAnswer);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_customRTBTextChanged)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo) == DialogResult.No) { e.Cancel = true; } else { e.Cancel = false; }
            }
        }

        private void backPageBtn_mouseEnter(object sender, EventArgs e)
        {
            backPageBtn.BackgroundImage = ((System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn2mouseover));
        }

        private void backPageBtn_mouseLeave(object sender, EventArgs e)
        {
            backPageBtn.BackgroundImage = ((System.Drawing.Image)(BookandQuill.Properties.Resources.nextpagebtn2));
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (journalTitle == "Untitled")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save As";
                save.Filter = "Text Files |*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.Text = System.IO.Path.GetFileName(save.FileName) + " - Book and Quill";
                    journalTitle = this.Text;
                    StreamWriter writer = new StreamWriter(File.Create(save.FileName));
                    saveJournalPath = save.FileName;
                    using (writer)
                    {
                        for (int i = 0; i < journalEntries.Length; i++)
                        {
                            if (journalEntries[i] != null)
                            {
                                writer.WriteLine(journalEntries[i].ToString());
                            }
                        }
                    }
                    writer.Close();
                }
                else
                {
                    Console.WriteLine("Saved");
                }
            }

            else
            {
                if (saveJournalPath != null)
                {
                    StreamWriter writer = new StreamWriter(saveJournalPath);
                    using (writer)
                    {
                        for (int i = 0; i < journalEntries.Length; i++)
                        {
                            if (journalEntries[i] != null)
                            {
                                writer.WriteLine(journalEntries[i].ToString());
                            }
                        }
                    }
                    writer.Close();
                }
            }


        }

        private void newJournalClicked(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save As";
            save.Filter = "Text Files |*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                this.Text = System.IO.Path.GetFileName(save.FileName) + " - Book and Quill";
                journalTitle = this.Text;
                StreamWriter writer = new StreamWriter(File.Create(save.FileName));
                saveJournalPath = save.FileName;
                using (writer)
                {
                    for (int i = 0; i < journalEntries.Length; i++)
                    {
                        if (journalEntries[i] != null)
                        {
                            writer.WriteLine(journalEntries[i].ToString());
                        }
                    }
                }
                writer.Close();
            }
        }
    }
}
