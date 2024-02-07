namespace SpriteViewer
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.rtbCredits = new System.Windows.Forms.RichTextBox();
            this.pictureBoxButtonsInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCredits
            // 
            this.rtbCredits.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCredits.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbCredits.Location = new System.Drawing.Point(0, 0);
            this.rtbCredits.Name = "rtbCredits";
            this.rtbCredits.ReadOnly = true;
            this.rtbCredits.Size = new System.Drawing.Size(480, 446);
            this.rtbCredits.TabIndex = 0;
            this.rtbCredits.Text = "Credits:\nJonMagon - Original Creator of BBTools (SpriteViewer/MapViewer)\nMichelan" +
    "geloHimself - Sprite Extraction Implementation\n\nInformation:\nTODO";
            // 
            // pictureBoxButtonsInfo
            // 
            this.pictureBoxButtonsInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxButtonsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxButtonsInfo.Image = global::SpriteViewer.Properties.Resources.buttonsInfo;
            this.pictureBoxButtonsInfo.Location = new System.Drawing.Point(480, 186);
            this.pictureBoxButtonsInfo.Name = "pictureBoxButtonsInfo";
            this.pictureBoxButtonsInfo.Size = new System.Drawing.Size(540, 260);
            this.pictureBoxButtonsInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonsInfo.TabIndex = 1;
            this.pictureBoxButtonsInfo.TabStop = false;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 446);
            this.Controls.Add(this.pictureBoxButtonsInfo);
            this.Controls.Add(this.rtbCredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCredits;
        private System.Windows.Forms.PictureBox pictureBoxButtonsInfo;
    }
}