namespace CustomStickyNotes
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.backPageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newJournalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._customRTB = new CustomStickyNotes.CustomRTB();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.BackgroundImage = global::CustomStickyNotes.Properties.Resources.nextpagebtn;
            this.nextPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nextPageBtn.FlatAppearance.BorderSize = 0;
            this.nextPageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextPageBtn.Location = new System.Drawing.Point(291, 463);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(58, 40);
            this.nextPageBtn.TabIndex = 0;
            this.nextPageBtn.UseVisualStyleBackColor = false;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            this.nextPageBtn.MouseEnter += new System.EventHandler(this.nextPageBtn_mouseEnter);
            this.nextPageBtn.MouseLeave += new System.EventHandler(this.nextPageBtn_mouseLeave);
            // 
            // backPageBtn
            // 
            this.backPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.backPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backPageBtn.FlatAppearance.BorderSize = 0;
            this.backPageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backPageBtn.Image = global::CustomStickyNotes.Properties.Resources.nextpagebtn2;
            this.backPageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backPageBtn.Location = new System.Drawing.Point(67, 463);
            this.backPageBtn.Name = "backPageBtn";
            this.backPageBtn.Size = new System.Drawing.Size(58, 40);
            this.backPageBtn.TabIndex = 1;
            this.backPageBtn.UseVisualStyleBackColor = false;
            this.backPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monocraft", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Page X of X";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.BackgroundImage = global::CustomStickyNotes.Properties.Resources.redbookmark;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(128, 128);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(20, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bookMenuToolStripMenuItem
            // 
            this.bookMenuToolStripMenuItem.BackgroundImage = global::CustomStickyNotes.Properties.Resources.redbookmark;
            this.bookMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.backToMenuToolStripMenuItem});
            this.bookMenuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookMenuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookMenuToolStripMenuItem.Name = "bookMenuToolStripMenuItem";
            this.bookMenuToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJournalToolStripMenuItem1});
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // newJournalToolStripMenuItem1
            // 
            this.newJournalToolStripMenuItem1.Name = "newJournalToolStripMenuItem1";
            this.newJournalToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.newJournalToolStripMenuItem1.Text = "New Journal";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.backToMenuToolStripMenuItem.Text = "Back to Menu";
            // 
            // _customRTB
            // 
            this._customRTB.Location = new System.Drawing.Point(0, 0);
            this._customRTB.MaxLength = 280;
            this._customRTB.Name = "_customRTB";
            this._customRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this._customRTB.Size = new System.Drawing.Size(340, 378);
            this._customRTB.TabIndex = 0;
            this._customRTB.Text = "";
            this._customRTB.TextChanged += new System.EventHandler(this.customRTBTextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::CustomStickyNotes.Properties.Resources.backgroundjournal3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(434, 531);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Book and Quill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button backPageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newJournalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}

