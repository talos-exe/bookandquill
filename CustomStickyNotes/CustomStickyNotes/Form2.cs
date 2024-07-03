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

namespace CustomStickyNotes { 

    public partial class Form2 : Form
    {

        private SoundPlayer flipPageOne;
        private SoundPlayer flipPageTwo;
        private SoundPlayer flipPageThree;
        private CustomRTB _customRTB = new CustomRTB();
        private bool _customRTBTextChanged = false;

        
        public Form2()
        {
            InitializeComponent();
            this.Controls.Add(_customRTB);
            DoubleBuffered = true;
            KeyPreview = true;
            nextPageBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.nextpagebtn);
            backPageBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.nextpagebtn2);
            backPageBtn.Visible = false;
            flipPageOne = new SoundPlayer("flip1.wav");
            flipPageTwo = new SoundPlayer("flip2.wav");
            flipPageThree = new SoundPlayer("flip3.wav");
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
        }

        private void customRTBTextChanged(object sender, EventArgs e)
        {
            _customRTBTextChanged = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcustomRTB();
        }

        private void nextPageBtn_mouseLeave(object sender, EventArgs e)
        {
            nextPageBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.nextpagebtn));
        }

        private void nextPageBtn_mouseEnter(object sender, EventArgs e)
        {
            nextPageBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.nextpagebtnmouseovert));
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            flipPageOne.Play();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            if (_customRTBTextChanged)
            {
                DialogResult dialog = MessageBox.Show("You have unsaved changes. Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
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
    }

    
}
