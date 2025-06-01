using System;
using System.Drawing;
using System.Windows.Forms;

namespace VocalEditor_CStest
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openoToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private SplitContainer MainSplitContainer;
        private GroupBox trackgroup;
        private VScrollBar trackgroupHScrollBar;
        private GroupBox trackinfogroup;
        private GroupBox tracknotegroup;
        private PictureBox trackinfoimage;
        private TextBox trackname;
        private Label tracksingerlabel;
        private TabPage tabPageEditor;
        private TabPage tabPageSinger;
        private TabControl EditorTabControl;
        private ListBox SingerList;
        private Button newtrackbutton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openoToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            singerToolStripMenuItem = new ToolStripMenuItem();
            loadSingerToolStripMenuItem = new ToolStripMenuItem();
            singerOtoToolStripMenuItem = new ToolStripMenuItem();
            modifySingerOtoiniToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            中文ToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            日本語ToolStripMenuItem = new ToolStripMenuItem();
            MainSplitContainer = new SplitContainer();
            trackgroup = new GroupBox();
            trackgroupHScrollBar = new VScrollBar();
            newtrackbutton = new Button();
            trackinfogroup = new GroupBox();
            trackname = new TextBox();
            trackinfoimage = new PictureBox();
            tracksingerlabel = new Label();
            tracknotegroup = new GroupBox();
            EditorTabControl = new TabControl();
            tabPageEditor = new TabPage();
            tabPageSinger = new TabPage();
            SingerList = new ListBox();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            howToUseToolStripMenuItem = new ToolStripMenuItem();
            moreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            trackgroup.SuspendLayout();
            trackinfogroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackinfoimage).BeginInit();
            EditorTabControl.SuspendLayout();
            tabPageSinger.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, singerToolStripMenuItem, helpToolStripMenuItem, languageToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 25);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openoToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // openoToolStripMenuItem
            // 
            openoToolStripMenuItem.Name = "openoToolStripMenuItem";
            openoToolStripMenuItem.Size = new Size(121, 22);
            openoToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(121, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(121, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(121, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(42, 21);
            editToolStripMenuItem.Text = "Edit";
            // 
            // singerToolStripMenuItem
            // 
            singerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadSingerToolStripMenuItem, singerOtoToolStripMenuItem, modifySingerOtoiniToolStripMenuItem });
            singerToolStripMenuItem.Name = "singerToolStripMenuItem";
            singerToolStripMenuItem.Size = new Size(57, 21);
            singerToolStripMenuItem.Text = "Singer";
            // 
            // loadSingerToolStripMenuItem
            // 
            loadSingerToolStripMenuItem.Name = "loadSingerToolStripMenuItem";
            loadSingerToolStripMenuItem.Size = new Size(198, 22);
            loadSingerToolStripMenuItem.Text = "Load Singer";
            // 
            // singerOtoToolStripMenuItem
            // 
            singerOtoToolStripMenuItem.Name = "singerOtoToolStripMenuItem";
            singerOtoToolStripMenuItem.Size = new Size(198, 22);
            singerOtoToolStripMenuItem.Text = "Singer oto";
            singerOtoToolStripMenuItem.Click += singerOtoToolStripMenuItem_Click;
            // 
            // modifySingerOtoiniToolStripMenuItem
            // 
            modifySingerOtoiniToolStripMenuItem.Name = "modifySingerOtoiniToolStripMenuItem";
            modifySingerOtoiniToolStripMenuItem.Size = new Size(198, 22);
            modifySingerOtoiniToolStripMenuItem.Text = "Modify Singer oto.ini";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 21);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "about us";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 中文ToolStripMenuItem, englishToolStripMenuItem, 日本語ToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(74, 21);
            languageToolStripMenuItem.Text = "language";
            // 
            // 中文ToolStripMenuItem
            // 
            中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            中文ToolStripMenuItem.Size = new Size(117, 22);
            中文ToolStripMenuItem.Text = "中文";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(117, 22);
            englishToolStripMenuItem.Text = "English";
            // 
            // 日本語ToolStripMenuItem
            // 
            日本語ToolStripMenuItem.Name = "日本語ToolStripMenuItem";
            日本語ToolStripMenuItem.Size = new Size(117, 22);
            日本語ToolStripMenuItem.Text = "日本語";
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainSplitContainer.Location = new Point(0, 28);
            MainSplitContainer.Name = "MainSplitContainer";
            MainSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(trackgroup);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(EditorTabControl);
            MainSplitContainer.Size = new Size(784, 462);
            MainSplitContainer.SplitterDistance = 229;
            MainSplitContainer.TabIndex = 0;
            // 
            // trackgroup
            // 
            trackgroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackgroup.Controls.Add(trackgroupHScrollBar);
            trackgroup.Controls.Add(newtrackbutton);
            trackgroup.Controls.Add(trackinfogroup);
            trackgroup.Controls.Add(tracknotegroup);
            trackgroup.ImeMode = ImeMode.Disable;
            trackgroup.Location = new Point(7, 12);
            trackgroup.Name = "trackgroup";
            trackgroup.Size = new Size(774, 214);
            trackgroup.TabIndex = 0;
            trackgroup.TabStop = false;
            trackgroup.Text = "Track Group";
            // 
            // trackgroupHScrollBar
            // 
            trackgroupHScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            trackgroupHScrollBar.LargeChange = 15;
            trackgroupHScrollBar.Location = new Point(751, 22);
            trackgroupHScrollBar.Maximum = 50;
            trackgroupHScrollBar.Name = "trackgroupHScrollBar";
            trackgroupHScrollBar.Size = new Size(17, 189);
            trackgroupHScrollBar.TabIndex = 2;
            trackgroupHScrollBar.Scroll += trackgroupHScrollBar_Scroll;
            // 
            // newtrackbutton
            // 
            newtrackbutton.Font = new Font("Microsoft YaHei UI", 10F);
            newtrackbutton.Location = new Point(94, 176);
            newtrackbutton.Name = "newtrackbutton";
            newtrackbutton.Size = new Size(84, 32);
            newtrackbutton.TabIndex = 3;
            newtrackbutton.Text = "New track";
            newtrackbutton.Click += newtrackbutton_Click;
            // 
            // trackinfogroup
            // 
            trackinfogroup.Controls.Add(trackname);
            trackinfogroup.Controls.Add(trackinfoimage);
            trackinfogroup.Controls.Add(tracksingerlabel);
            trackinfogroup.Location = new Point(10, 22);
            trackinfogroup.Name = "trackinfogroup";
            trackinfogroup.Size = new Size(239, 148);
            trackinfogroup.TabIndex = 0;
            trackinfogroup.TabStop = false;
            trackinfogroup.Text = "Track Info";
            // 
            // trackname
            // 
            trackname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackname.Location = new Point(132, 56);
            trackname.MaxLength = 100;
            trackname.Name = "trackname";
            trackname.Size = new Size(100, 23);
            trackname.TabIndex = 0;
            trackname.Text = "Track1";
            trackname.TextAlign = HorizontalAlignment.Center;
            // 
            // trackinfoimage
            // 
            trackinfoimage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackinfoimage.Location = new Point(6, 22);
            trackinfoimage.Name = "trackinfoimage";
            trackinfoimage.Size = new Size(120, 120);
            trackinfoimage.SizeMode = PictureBoxSizeMode.StretchImage;
            trackinfoimage.TabIndex = 0;
            trackinfoimage.TabStop = false;
            // 
            // tracksingerlabel
            // 
            tracksingerlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tracksingerlabel.Location = new Point(144, 91);
            tracksingerlabel.Name = "tracksingerlabel";
            tracksingerlabel.Size = new Size(72, 17);
            tracksingerlabel.TabIndex = 2;
            tracksingerlabel.Text = "No Singer";
            tracksingerlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tracknotegroup
            // 
            tracknotegroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tracknotegroup.Location = new Point(255, 22);
            tracknotegroup.Name = "tracknotegroup";
            tracknotegroup.Size = new Size(493, 148);
            tracknotegroup.TabIndex = 1;
            tracknotegroup.TabStop = false;
            tracknotegroup.Text = "Notes";
            // 
            // EditorTabControl
            // 
            EditorTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditorTabControl.Controls.Add(tabPageEditor);
            EditorTabControl.Controls.Add(tabPageSinger);
            EditorTabControl.Location = new Point(3, 3);
            EditorTabControl.Name = "EditorTabControl";
            EditorTabControl.SelectedIndex = 0;
            EditorTabControl.Size = new Size(778, 224);
            EditorTabControl.TabIndex = 1;
            // 
            // tabPageEditor
            // 
            tabPageEditor.Location = new Point(4, 26);
            tabPageEditor.Name = "tabPageEditor";
            tabPageEditor.Size = new Size(770, 194);
            tabPageEditor.TabIndex = 0;
            tabPageEditor.Text = "Editor";
            // 
            // tabPageSinger
            // 
            tabPageSinger.Controls.Add(SingerList);
            tabPageSinger.Location = new Point(4, 26);
            tabPageSinger.Name = "tabPageSinger";
            tabPageSinger.Size = new Size(770, 194);
            tabPageSinger.TabIndex = 1;
            tabPageSinger.Text = "Singer";
            // 
            // SingerList
            // 
            SingerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SingerList.ItemHeight = 17;
            SingerList.Location = new Point(5, 9);
            SingerList.Name = "SingerList";
            SingerList.Size = new Size(159, 174);
            SingerList.TabIndex = 0;
            SingerList.SelectedIndexChanged += SingerSelected;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { howToUseToolStripMenuItem, moreToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(180, 22);
            helpToolStripMenuItem1.Text = "help";
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(180, 22);
            howToUseToolStripMenuItem.Text = "how to use?";
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(180, 22);
            moreToolStripMenuItem.Text = "more...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 488);
            Controls.Add(MainSplitContainer);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            Text = "VocalEditor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            trackgroup.ResumeLayout(false);
            trackinfogroup.ResumeLayout(false);
            trackinfogroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackinfoimage).EndInit();
            EditorTabControl.ResumeLayout(false);
            tabPageSinger.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem singerToolStripMenuItem;
        private ToolStripMenuItem loadSingerToolStripMenuItem;
        private ToolStripMenuItem singerOtoToolStripMenuItem;
        private ToolStripMenuItem modifySingerOtoiniToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem 中文ToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem 日本語ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem howToUseToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
    }
}