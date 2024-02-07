using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteViewer
{
    public partial class AutoClosingMessageBox : Form
    {
        public AutoClosingMessageBox()
        {
            InitializeComponent();
            buttonOK.Enabled = false;
            buttonOK.Click += (s, e) => this.Close();
        }

        public void AppendMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => richTextBoxOutput.AppendText(message + Environment.NewLine)));
            }
            else
            {
                richTextBoxOutput.AppendText(message + Environment.NewLine);
            }
        }

        public void EnableOkButton()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => buttonOK.Enabled = true));
            }
            else
            {
                buttonOK.Enabled = true;
            }
        }
    }


}
