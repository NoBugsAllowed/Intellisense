namespace Intellisense
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerDictionary = new System.Windows.Forms.SplitContainer();
            this.dictionaryBox = new System.Windows.Forms.ListBox();
            this.splitContainerButtons = new System.Windows.Forms.SplitContainer();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolBold = new System.Windows.Forms.ToolStripButton();
            this.btnToolItalic = new System.Windows.Forms.ToolStripButton();
            this.btnToolUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnToolFontColor = new System.Windows.Forms.ToolStripButton();
            this.btnToolBgColor = new System.Windows.Forms.ToolStripButton();
            this.changeFontTool = new System.Windows.Forms.ToolStripComboBox();
            this.addWordMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWordMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDictionary)).BeginInit();
            this.splitContainerDictionary.Panel1.SuspendLayout();
            this.splitContainerDictionary.Panel2.SuspendLayout();
            this.splitContainerDictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerButtons)).BeginInit();
            this.splitContainerButtons.Panel1.SuspendLayout();
            this.splitContainerButtons.Panel2.SuspendLayout();
            this.splitContainerButtons.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.addWordMenu.SuspendLayout();
            this.deleteWordMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(709, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.splitContainer);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 25);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.mainContainer.Size = new System.Drawing.Size(709, 477);
            this.mainContainer.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(3, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer.Panel1.Controls.Add(this.splitContainerDictionary);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer.Size = new System.Drawing.Size(703, 474);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 2;
            this.splitContainer.TabStop = false;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // splitContainerDictionary
            // 
            this.splitContainerDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDictionary.IsSplitterFixed = true;
            this.splitContainerDictionary.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDictionary.Name = "splitContainerDictionary";
            this.splitContainerDictionary.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDictionary.Panel1
            // 
            this.splitContainerDictionary.Panel1.Controls.Add(this.dictionaryBox);
            // 
            // splitContainerDictionary.Panel2
            // 
            this.splitContainerDictionary.Panel2.Controls.Add(this.splitContainerButtons);
            this.splitContainerDictionary.Size = new System.Drawing.Size(190, 474);
            this.splitContainerDictionary.SplitterDistance = 439;
            this.splitContainerDictionary.TabIndex = 6;
            this.splitContainerDictionary.TabStop = false;
            // 
            // dictionaryBox
            // 
            this.dictionaryBox.AllowDrop = true;
            this.dictionaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dictionaryBox.FormattingEnabled = true;
            this.dictionaryBox.Location = new System.Drawing.Point(0, 0);
            this.dictionaryBox.Name = "dictionaryBox";
            this.dictionaryBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.dictionaryBox.Size = new System.Drawing.Size(190, 439);
            this.dictionaryBox.TabIndex = 7;
            this.dictionaryBox.TabStop = false;
            this.dictionaryBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dictionaryBox_DragDrop);
            this.dictionaryBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dictionaryBox_DragEnter);
            this.dictionaryBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dictionaryBox_PreviewKeyDown);
            // 
            // splitContainerButtons
            // 
            this.splitContainerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerButtons.IsSplitterFixed = true;
            this.splitContainerButtons.Location = new System.Drawing.Point(0, -69);
            this.splitContainerButtons.Name = "splitContainerButtons";
            // 
            // splitContainerButtons.Panel1
            // 
            this.splitContainerButtons.Panel1.Controls.Add(this.btnNewWord);
            // 
            // splitContainerButtons.Panel2
            // 
            this.splitContainerButtons.Panel2.Controls.Add(this.btnSort);
            this.splitContainerButtons.Size = new System.Drawing.Size(190, 100);
            this.splitContainerButtons.SplitterDistance = 63;
            this.splitContainerButtons.TabIndex = 6;
            this.splitContainerButtons.TabStop = false;
            // 
            // btnNewWord
            // 
            this.btnNewWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewWord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewWord.Location = new System.Drawing.Point(-3, 73);
            this.btnNewWord.MaximumSize = new System.Drawing.Size(100, 23);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(100, 23);
            this.btnNewWord.TabIndex = 6;
            this.btnNewWord.TabStop = false;
            this.btnNewWord.Text = "Add new word";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSort.Location = new System.Drawing.Point(20, 74);
            this.btnSort.MaximumSize = new System.Drawing.Size(100, 23);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.TabStop = false;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(503, 449);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(503, 474);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(177, 91);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(132, 108);
            this.listBox.TabIndex = 8;
            this.listBox.TabStop = false;
            this.listBox.Visible = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(503, 449);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.TabStop = false;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            this.richTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseDown);
            this.richTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox_PreviewKeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolBold,
            this.btnToolItalic,
            this.btnToolUnderline,
            this.btnToolFontColor,
            this.btnToolBgColor,
            this.changeFontTool});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(250, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnToolBold
            // 
            this.btnToolBold.CheckOnClick = true;
            this.btnToolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolBold.Image = ((System.Drawing.Image)(resources.GetObject("btnToolBold.Image")));
            this.btnToolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolBold.Name = "btnToolBold";
            this.btnToolBold.Size = new System.Drawing.Size(23, 22);
            this.btnToolBold.Text = "toolStripButton1";
            this.btnToolBold.ToolTipText = "Bold";
            this.btnToolBold.Click += new System.EventHandler(this.btnToolBold_Click);
            // 
            // btnToolItalic
            // 
            this.btnToolItalic.CheckOnClick = true;
            this.btnToolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnToolItalic.Image")));
            this.btnToolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolItalic.Name = "btnToolItalic";
            this.btnToolItalic.Size = new System.Drawing.Size(23, 22);
            this.btnToolItalic.Text = "toolStripButton2";
            this.btnToolItalic.ToolTipText = "Italic";
            this.btnToolItalic.Click += new System.EventHandler(this.btnToolItalic_Click);
            // 
            // btnToolUnderline
            // 
            this.btnToolUnderline.CheckOnClick = true;
            this.btnToolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnToolUnderline.Image")));
            this.btnToolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolUnderline.Name = "btnToolUnderline";
            this.btnToolUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnToolUnderline.Text = "toolStripButton3";
            this.btnToolUnderline.ToolTipText = "Underline";
            this.btnToolUnderline.Click += new System.EventHandler(this.btnToolUnderline_Click);
            // 
            // btnToolFontColor
            // 
            this.btnToolFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolFontColor.Image = ((System.Drawing.Image)(resources.GetObject("btnToolFontColor.Image")));
            this.btnToolFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolFontColor.Name = "btnToolFontColor";
            this.btnToolFontColor.Size = new System.Drawing.Size(23, 22);
            this.btnToolFontColor.Text = "toolStripButton4";
            this.btnToolFontColor.ToolTipText = "Font color";
            this.btnToolFontColor.Click += new System.EventHandler(this.btnToolFontColor_Click);
            // 
            // btnToolBgColor
            // 
            this.btnToolBgColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolBgColor.Image = ((System.Drawing.Image)(resources.GetObject("btnToolBgColor.Image")));
            this.btnToolBgColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolBgColor.Name = "btnToolBgColor";
            this.btnToolBgColor.Size = new System.Drawing.Size(23, 22);
            this.btnToolBgColor.Text = "toolStripButton5";
            this.btnToolBgColor.ToolTipText = "Background color";
            this.btnToolBgColor.Click += new System.EventHandler(this.btnToolBgColor_Click);
            // 
            // changeFontTool
            // 
            this.changeFontTool.Name = "changeFontTool";
            this.changeFontTool.Size = new System.Drawing.Size(121, 25);
            this.changeFontTool.SelectedIndexChanged += new System.EventHandler(this.changeFontTool_SelectedIndexChanged);
            // 
            // addWordMenu
            // 
            this.addWordMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordToolStripMenuItem});
            this.addWordMenu.Name = "wordMenu";
            this.addWordMenu.Size = new System.Drawing.Size(127, 26);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addWordToolStripMenuItem.Text = "Add word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // deleteWordMenu
            // 
            this.deleteWordMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWordToolStripMenuItem});
            this.deleteWordMenu.Name = "deleteWordMenu";
            this.deleteWordMenu.Size = new System.Drawing.Size(138, 26);
            // 
            // deleteWordToolStripMenuItem
            // 
            this.deleteWordToolStripMenuItem.Name = "deleteWordToolStripMenuItem";
            this.deleteWordToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteWordToolStripMenuItem.Text = "Delete word";
            this.deleteWordToolStripMenuItem.Click += new System.EventHandler(this.deleteWordToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 502);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intellisense";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dictionaryBox_DragDrop);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerDictionary.Panel1.ResumeLayout(false);
            this.splitContainerDictionary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDictionary)).EndInit();
            this.splitContainerDictionary.ResumeLayout(false);
            this.splitContainerButtons.Panel1.ResumeLayout(false);
            this.splitContainerButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerButtons)).EndInit();
            this.splitContainerButtons.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.addWordMenu.ResumeLayout(false);
            this.deleteWordMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitContainerDictionary;
        private System.Windows.Forms.ListBox dictionaryBox;
        private System.Windows.Forms.SplitContainer splitContainerButtons;
        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ContextMenuStrip addWordMenu;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip deleteWordMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToolBold;
        private System.Windows.Forms.ToolStripButton btnToolItalic;
        private System.Windows.Forms.ToolStripButton btnToolUnderline;
        private System.Windows.Forms.ToolStripButton btnToolFontColor;
        private System.Windows.Forms.ToolStripButton btnToolBgColor;
        private System.Windows.Forms.ToolStripComboBox changeFontTool;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

