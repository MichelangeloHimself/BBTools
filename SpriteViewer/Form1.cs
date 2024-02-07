using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BBData;

namespace SpriteViewer
{
    public partial class Form1 : Form
    {
        private Palettes.TypePalette palette = Palettes.TypePalette.SUMMER_PALETTE;

        private BOXFile video;

        public Form1()
        {
            InitializeComponent();
            SendMessage(filter.Handle, 0x1501, 1, "Search"); // EM_SETCUEBANNER
            paletteBox.Text = "SUMMER_PALETTE";
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam,
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resource archive (*.box) | *.box";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        video = new BOXFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    filter.Enabled = true;

                    spritesBox.Clear();
                    status.Text = null;

                    filesBox.BeginUpdate();

                    filesBox.Items.Clear();

                    foreach (var item in video.Entries)
                        filesBox.Items.Add(item.Filename);

                    filesBox.EndUpdate();
                }
            }
        }

        private void filesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMFB();
        }

        private void LoadMFB()
        {
            if (filesBox.SelectedIndex == -1) return;

            try
            {
                var mfb = new MFBFile(video.Entries.Find(
                    item => item.Filename == filesBox.SelectedItem.ToString()).Data, palette);

                status.Text = $"Size: {mfb.Width} x {mfb.Height} | Offset: ({mfb.Offset.X}, {mfb.Offset.Y})";
                if (mfb.IsTransparent) status.Text += " | Transparent";
                if (mfb.IsCompressed) status.Text += " | Compressed";
                if (mfb.IsUnknown) status.Text += " | IsUnknown";

                var imglist = new ImageList();
                spritesBox.LargeImageList = imglist;

                // Scaling
                imglist.ImageSize = new Size(
                    mfb.Width <= 256 ? mfb.Width : 256,
                    mfb.Height <= 256 ? mfb.Height : 256);

                imglist.Images.AddRange(mfb.Entries.ToArray());

                spritesBox.BeginUpdate();
                spritesBox.Items.Clear();
                for (var i = 0; i < mfb.Entries.Count; i++)
                    spritesBox.Items.Add(new ListViewItem(i.ToString(), i));
                spritesBox.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            filesBox.BeginUpdate();
            filesBox.Items.Clear();
            foreach (var item in video.Entries)
                if (item.Filename.Contains(filter.Text))
                    filesBox.Items.Add(item.Filename);
            filesBox.EndUpdate();
        }

        private void paletteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (paletteBox.Text)
            {
                case "PALETTE":
                    palette = Palettes.TypePalette.PALETTE;
                    break;
                case "AUTUMN_PALETTE":
                    palette = Palettes.TypePalette.AUTUMN_PALETTE;
                    break;
                case "WINTER_PALETTE":
                    palette = Palettes.TypePalette.WINTER_PALETTE;
                    break;
                case "SUMMER_PALETTE":
                    palette = Palettes.TypePalette.SUMMER_PALETTE;
                    break;
                case "SPRING_PALETTE":
                    palette = Palettes.TypePalette.SPRING_PALETTE;
                    break;
                case "MISSIONPALETTE":
                    palette = Palettes.TypePalette.MISSIONPALETTE;
                    break;
                case "LOADINGPALETTE":
                    palette = Palettes.TypePalette.LOADINGPALETTE;
                    break;
                case "TITLEPALETTE":
                    palette = Palettes.TypePalette.TITLEPALETTE;
                    break;
            }
            LoadMFB();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DumpAllMFBToPNG()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string rootSaveDirectory = folderBrowserDialog.SelectedPath;

                var msgBox = new AutoClosingMessageBox();
                msgBox.Show();

                foreach (var entry in video.Entries)
                {
                    if (Path.GetExtension(entry.Filename) == ".mfb")
                    {
                        try
                        {
                            var mfb = new MFBFile(entry.Data, palette);
                            string baseFilename = Path.GetFileNameWithoutExtension(entry.Filename);
                            string saveDirectory = Path.Combine(rootSaveDirectory, $"{baseFilename}_sprites");

                            if (!Directory.Exists(saveDirectory))
                                Directory.CreateDirectory(saveDirectory);

                            for (var i = 0; i < mfb.Entries.Count; i++)
                            {
                                string pngFilePath = Path.Combine(saveDirectory, $"{baseFilename}{i}.png");
                                mfb.Entries[i].Save(pngFilePath, ImageFormat.Png);
                            }

                            msgBox.AppendMessage($"Dumped {mfb.Entries.Count} sprites to {saveDirectory}.");
                        }
                        catch (Exception ex)
                        {
                            msgBox.AppendMessage($"An error occurred while processing {entry.Filename}: {ex.Message}");
                        }
                    }
                }

                msgBox.EnableOkButton();
            }
        }


        private void DumpMFBToPNG()
        {
            if (filesBox.SelectedIndex == -1)
            {
                MessageBox.Show("No MFB file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveDirectory = folderBrowserDialog.SelectedPath;
                    try
                    {
                        string selectedFileName = filesBox.SelectedItem.ToString();
                        var mfb = new MFBFile(video.Entries.Find(
                            item => item.Filename == selectedFileName).Data, palette);

                        string baseFilename = Path.GetFileNameWithoutExtension(selectedFileName);

                        for (var i = 0; i < mfb.Entries.Count; i++)
                        {
                            string pngFilePath = Path.Combine(saveDirectory, $"{baseFilename}_{i}.png");
                            mfb.Entries[i].Save(pngFilePath, ImageFormat.Png);
                        }

                        MessageBox.Show($"Dumped {mfb.Entries.Count} sprites to {saveDirectory}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DumpSpriteToPNG()
        {
            if (filesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("No MFB file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (spritesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("No sprite selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveDirectory = folderBrowserDialog.SelectedPath;
                    try
                    {
                        string selectedFileName = filesBox.SelectedItems[0].ToString();
                        var mfb = new MFBFile(video.Entries.Find(
                            item => item.Filename == selectedFileName).Data, palette);

                        string baseFilename = Path.GetFileNameWithoutExtension(selectedFileName);

                        // Loop through all selected sprites
                        foreach (ListViewItem selectedItem in spritesBox.SelectedItems)
                        {
                            int selectedSpriteIndex = selectedItem.Index;
                            string pngFilePath = Path.Combine(saveDirectory, $"{baseFilename}_{selectedSpriteIndex}.png");
                            mfb.Entries[selectedSpriteIndex].Save(pngFilePath, ImageFormat.Png);
                        }

                        MessageBox.Show($"Dumped {spritesBox.SelectedItems.Count} sprite(s) to {saveDirectory}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnExtract_Click(object sender, EventArgs e)
        {
            DumpAllMFBToPNG();
        }

        private void btnExtractSelected_Click(object sender, EventArgs e)
        {
            DumpMFBToPNG();
        }

        private void btnExtractSelectedSprite_Click(object sender, EventArgs e)
        {
            DumpSpriteToPNG();
        }

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void btnDumpSaveList_Click(object sender, EventArgs e)
        {
            DumpAllSaveList();
        }

        private void btnSaveListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (filesBox.SelectedIndex != -1)
                {
                    listBoxSave.Items.Add(filesBox.SelectedItem);
                }
                else
                {
                    MessageBox.Show("No MFB file selected in the files box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveListRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxSave.SelectedIndex != -1)
                {
                    listBoxSave.Items.RemoveAt(listBoxSave.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("No MFB file selected in the save list box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveListClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the save list box?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBoxSave.Items.Clear();
            }
        }

        private void DumpAllSaveList()
        {
            if (listBoxSave.Items.Count == 0)
            {
                MessageBox.Show("No MFB file selected in the save list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveDirectory = folderBrowserDialog.SelectedPath;
                    try
                    {
                        foreach (string selectedFileName in listBoxSave.Items)
                        {
                            var mfb = new MFBFile(video.Entries.Find(
                                item => item.Filename == selectedFileName).Data, palette);

                            string baseFilename = Path.GetFileNameWithoutExtension(selectedFileName);

                            for (var i = 0; i < mfb.Entries.Count; i++)
                            {
                                string pngFilePath = Path.Combine(saveDirectory, $"{baseFilename}_{i}.png");
                                mfb.Entries[i].Save(pngFilePath, ImageFormat.Png);
                            }
                        }

                        MessageBox.Show($"Dumped all sprites from selected MFB files to {saveDirectory}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}