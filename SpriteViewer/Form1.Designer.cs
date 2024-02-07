namespace SpriteViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spritesBox = new System.Windows.Forms.ListView();
            this.pnlButtonsDock = new System.Windows.Forms.Panel();
            this.btnSaveListClear = new System.Windows.Forms.Button();
            this.btnSaveListRemove = new System.Windows.Forms.Button();
            this.btnSaveListAdd = new System.Windows.Forms.Button();
            this.btnDumpSaveList = new System.Windows.Forms.Button();
            this.paletteBox = new System.Windows.Forms.ComboBox();
            this.btnExtractSelectedSprite = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.TextBox();
            this.btnExtractSelected = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.pnlSaveListHeader = new System.Windows.Forms.Panel();
            this.lblSaveList = new System.Windows.Forms.Label();
            this.listBoxSave = new System.Windows.Forms.ListBox();
            this.pnlMFBMainHeader = new System.Windows.Forms.Panel();
            this.lblSelectList = new System.Windows.Forms.Label();
            this.filesBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlButtonsDock.SuspendLayout();
            this.pnlSaveListHeader.SuspendLayout();
            this.pnlMFBMainHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spritesBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlButtonsDock);
            this.splitContainer1.Panel2.Controls.Add(this.pnlSaveListHeader);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxSave);
            this.splitContainer1.Panel2.Controls.Add(this.pnlMFBMainHeader);
            this.splitContainer1.Panel2.Controls.Add(this.filesBox);
            this.splitContainer1.Size = new System.Drawing.Size(1690, 897);
            this.splitContainer1.SplitterDistance = 1150;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // spritesBox
            // 
            this.spritesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spritesBox.HideSelection = false;
            this.spritesBox.Location = new System.Drawing.Point(4, 5);
            this.spritesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spritesBox.Name = "spritesBox";
            this.spritesBox.Size = new System.Drawing.Size(1142, 887);
            this.spritesBox.TabIndex = 0;
            this.spritesBox.UseCompatibleStateImageBehavior = false;
            // 
            // pnlButtonsDock
            // 
            this.pnlButtonsDock.Controls.Add(this.btnSaveListClear);
            this.pnlButtonsDock.Controls.Add(this.btnSaveListRemove);
            this.pnlButtonsDock.Controls.Add(this.btnSaveListAdd);
            this.pnlButtonsDock.Controls.Add(this.btnDumpSaveList);
            this.pnlButtonsDock.Controls.Add(this.paletteBox);
            this.pnlButtonsDock.Controls.Add(this.btnExtractSelectedSprite);
            this.pnlButtonsDock.Controls.Add(this.filter);
            this.pnlButtonsDock.Controls.Add(this.btnExtractSelected);
            this.pnlButtonsDock.Controls.Add(this.btnExtract);
            this.pnlButtonsDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonsDock.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonsDock.Name = "pnlButtonsDock";
            this.pnlButtonsDock.Size = new System.Drawing.Size(538, 289);
            this.pnlButtonsDock.TabIndex = 7;
            // 
            // btnSaveListClear
            // 
            this.btnSaveListClear.Location = new System.Drawing.Point(372, 237);
            this.btnSaveListClear.Name = "btnSaveListClear";
            this.btnSaveListClear.Size = new System.Drawing.Size(162, 32);
            this.btnSaveListClear.TabIndex = 4;
            this.btnSaveListClear.Text = "Clear List";
            this.btnSaveListClear.UseVisualStyleBackColor = true;
            this.btnSaveListClear.Click += new System.EventHandler(this.btnSaveListClear_Click);
            // 
            // btnSaveListRemove
            // 
            this.btnSaveListRemove.Location = new System.Drawing.Point(187, 237);
            this.btnSaveListRemove.Name = "btnSaveListRemove";
            this.btnSaveListRemove.Size = new System.Drawing.Size(162, 32);
            this.btnSaveListRemove.TabIndex = 5;
            this.btnSaveListRemove.Text = "Remove";
            this.btnSaveListRemove.UseVisualStyleBackColor = true;
            this.btnSaveListRemove.Click += new System.EventHandler(this.btnSaveListRemove_Click);
            // 
            // btnSaveListAdd
            // 
            this.btnSaveListAdd.Location = new System.Drawing.Point(2, 237);
            this.btnSaveListAdd.Name = "btnSaveListAdd";
            this.btnSaveListAdd.Size = new System.Drawing.Size(162, 32);
            this.btnSaveListAdd.TabIndex = 6;
            this.btnSaveListAdd.Text = "Add to List";
            this.btnSaveListAdd.UseVisualStyleBackColor = true;
            this.btnSaveListAdd.Click += new System.EventHandler(this.btnSaveListAdd_Click);
            // 
            // btnDumpSaveList
            // 
            this.btnDumpSaveList.Location = new System.Drawing.Point(2, 199);
            this.btnDumpSaveList.Name = "btnDumpSaveList";
            this.btnDumpSaveList.Size = new System.Drawing.Size(532, 32);
            this.btnDumpSaveList.TabIndex = 7;
            this.btnDumpSaveList.Text = "Extract Sprites From MFBs in Extract List";
            this.btnDumpSaveList.UseVisualStyleBackColor = true;
            this.btnDumpSaveList.Click += new System.EventHandler(this.btnDumpSaveList_Click);
            // 
            // paletteBox
            // 
            this.paletteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paletteBox.FormattingEnabled = true;
            this.paletteBox.Items.AddRange(new object[] {
            "PALETTE",
            "AUTUMN_PALETTE",
            "WINTER_PALETTE",
            "SUMMER_PALETTE",
            "SPRING_PALETTE",
            "MISSIONPALETTE",
            "LOADINGPALETTE",
            "TITLEPALETTE"});
            this.paletteBox.Location = new System.Drawing.Point(4, 13);
            this.paletteBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paletteBox.Name = "paletteBox";
            this.paletteBox.Size = new System.Drawing.Size(530, 28);
            this.paletteBox.TabIndex = 2;
            this.paletteBox.SelectedIndexChanged += new System.EventHandler(this.paletteBox_SelectedIndexChanged);
            // 
            // btnExtractSelectedSprite
            // 
            this.btnExtractSelectedSprite.Location = new System.Drawing.Point(2, 161);
            this.btnExtractSelectedSprite.Name = "btnExtractSelectedSprite";
            this.btnExtractSelectedSprite.Size = new System.Drawing.Size(532, 32);
            this.btnExtractSelectedSprite.TabIndex = 8;
            this.btnExtractSelectedSprite.Text = "Extract Selected Sprite/s";
            this.btnExtractSelectedSprite.UseVisualStyleBackColor = true;
            this.btnExtractSelectedSprite.Click += new System.EventHandler(this.btnExtractSelectedSprite_Click);
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.Enabled = false;
            this.filter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filter.Location = new System.Drawing.Point(4, 51);
            this.filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(530, 26);
            this.filter.TabIndex = 1;
            this.filter.TextChanged += new System.EventHandler(this.filter_TextChanged);
            // 
            // btnExtractSelected
            // 
            this.btnExtractSelected.Location = new System.Drawing.Point(2, 123);
            this.btnExtractSelected.Name = "btnExtractSelected";
            this.btnExtractSelected.Size = new System.Drawing.Size(532, 32);
            this.btnExtractSelected.TabIndex = 9;
            this.btnExtractSelected.Text = "Extract All Sprites From Selected MFB";
            this.btnExtractSelected.UseVisualStyleBackColor = true;
            this.btnExtractSelected.Click += new System.EventHandler(this.btnExtractSelected_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(2, 85);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(532, 32);
            this.btnExtract.TabIndex = 10;
            this.btnExtract.Text = "Extract Sprites From All MFBs";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // pnlSaveListHeader
            // 
            this.pnlSaveListHeader.Controls.Add(this.lblSaveList);
            this.pnlSaveListHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSaveListHeader.Location = new System.Drawing.Point(0, 289);
            this.pnlSaveListHeader.Name = "pnlSaveListHeader";
            this.pnlSaveListHeader.Size = new System.Drawing.Size(538, 40);
            this.pnlSaveListHeader.TabIndex = 6;
            // 
            // lblSaveList
            // 
            this.lblSaveList.AutoSize = true;
            this.lblSaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSaveList.Location = new System.Drawing.Point(3, 14);
            this.lblSaveList.Name = "lblSaveList";
            this.lblSaveList.Size = new System.Drawing.Size(187, 20);
            this.lblSaveList.TabIndex = 0;
            this.lblSaveList.Text = "MFB Bulk Extract List:";
            // 
            // listBoxSave
            // 
            this.listBoxSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxSave.FormattingEnabled = true;
            this.listBoxSave.ItemHeight = 20;
            this.listBoxSave.Location = new System.Drawing.Point(0, 329);
            this.listBoxSave.Name = "listBoxSave";
            this.listBoxSave.Size = new System.Drawing.Size(538, 224);
            this.listBoxSave.TabIndex = 5;
            // 
            // pnlMFBMainHeader
            // 
            this.pnlMFBMainHeader.Controls.Add(this.lblSelectList);
            this.pnlMFBMainHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMFBMainHeader.Location = new System.Drawing.Point(0, 553);
            this.pnlMFBMainHeader.Name = "pnlMFBMainHeader";
            this.pnlMFBMainHeader.Size = new System.Drawing.Size(538, 40);
            this.pnlMFBMainHeader.TabIndex = 4;
            // 
            // lblSelectList
            // 
            this.lblSelectList.AutoSize = true;
            this.lblSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Location = new System.Drawing.Point(3, 15);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(208, 20);
            this.lblSelectList.TabIndex = 0;
            this.lblSelectList.Text = "Main MFB Selection List:";
            // 
            // filesBox
            // 
            this.filesBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filesBox.FormattingEnabled = true;
            this.filesBox.ItemHeight = 20;
            this.filesBox.Location = new System.Drawing.Point(0, 593);
            this.filesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(538, 304);
            this.filesBox.TabIndex = 0;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.filesBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 955);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1690, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1690, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::SpriteViewer.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SpriteViewer.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Image = global::SpriteViewer.Properties.Resources.info;
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.Click += new System.EventHandler(this.readmeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 977);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SpriteViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlButtonsDock.ResumeLayout(false);
            this.pnlButtonsDock.PerformLayout();
            this.pnlSaveListHeader.ResumeLayout(false);
            this.pnlSaveListHeader.PerformLayout();
            this.pnlMFBMainHeader.ResumeLayout(false);
            this.pnlMFBMainHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView spritesBox;
        private System.Windows.Forms.ListBox filesBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.ComboBox paletteBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSave;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSaveListHeader;
        private System.Windows.Forms.Panel pnlMFBMainHeader;
        private System.Windows.Forms.Label lblSaveList;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.Panel pnlButtonsDock;
        private System.Windows.Forms.Button btnSaveListClear;
        private System.Windows.Forms.Button btnSaveListRemove;
        private System.Windows.Forms.Button btnSaveListAdd;
        private System.Windows.Forms.Button btnDumpSaveList;
        private System.Windows.Forms.Button btnExtractSelectedSprite;
        private System.Windows.Forms.Button btnExtractSelected;
        private System.Windows.Forms.Button btnExtract;
    }
}

