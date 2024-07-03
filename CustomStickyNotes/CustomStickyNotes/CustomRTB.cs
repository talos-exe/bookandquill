using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomStickyNotes
{
    public partial class CustomRTB : RichTextBox
    {
        public CustomRTB()
        {
            InitializeComponent();
            this.Rtf = @"{\rtf1\sl500\";

        }

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }

        }

        public void clearRTBText()
        {
            this.SelectAll();
            this.Focus();
        }
    }

}
