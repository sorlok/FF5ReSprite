using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using WinGui.FileTypes;
using WinGui.Utils;

namespace WinGui
{
    public partial class Form1 : Form
    {
        // Helper!
        private Font? myFont;

        // Track all the CombBoxes, PictBoxes, and Text fields with this buggy single-ish-ton
        // We also put the order of the names associated with them.
        public static List<string> AllCharas;
        public static List<ComboBox> AllCombos;
        public static List<TextBox> AllTxts;
        public static List<bool> AllIsCharaType; // If true, use 'chara' rules; else, use 'npc' rules

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Save for later reference
            AllCharas = new List<string>
            {
                "Bartz", "Lenna", "Galuf", "Faris", "Krile", "King Tycoon", "Gilgamesh", "Exdeath"
            };
            AllCombos = new List<ComboBox>
            {
                cbBartz, cbLenna, cbGaluf, cbFaris, cbKrile, cbTycoon, cbGilgamesh, cbExdeath
            };
            AllTxts = new List<TextBox>
            {
                txtBartz, txtLenna, txtGaluf, txtFaris, txtKrile, txtTycoon, txtGilgamesh,  txtExdeath
            };
            AllIsCharaType = new List<bool>
            {
                true, true, true, true, true, false, false, false
            };

            // Update our SteamGameDir text box with the saved config value.
            if (Config.SteamGameDir() == "")
            {
                Config.SetSteamGameDir(InstallStatus.GuessSteamDir());
            }
            txtSteamDir.Text = Config.SteamGameDir();

            SetCharaNames();

            UpdateStatus();
        }


        // Borrowed from:
        // https://stackoverflow.com/questions/329355/cannot-delete-directory-with-directory-deletepath-true
        public static void DeleteDirectory(string target_dir)
        {
            // Keep them from deleting "C:"
            if (target_dir.Length < 20)
            {
                throw new Exception("Refusing to delete too-short path: " + target_dir);
            }

            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        // Borrowed from:
        // https://stackoverflow.com/questions/58744/copy-the-entire-contents-of-a-directory-in-c-sharp
        public static void CopyDirRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                CopyDirRecursively(dir, target.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in source.GetFiles())
            {
                file.CopyTo(Path.Join(target.FullName, file.Name));
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            // Special case: Uninstall
            if (btnChoose.Text == "Un-Install")
            {
                btnChoose.Text = "Uninstalling...";
                btnChoose.Enabled = false;

                string[] dirs = { "BepInEx", "mono", Constants.MagiciteExportDir, Constants.MagiciteImportDir };
                string[] files = { "doorstop_config.ini", "winhttp.dll", "changelog.txt" };

                foreach (string file in files)
                {
                    string filePath = Path.Join(Config.SteamGameDir(), file);
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("Deleting: " + filePath);
                        File.Delete(filePath);
                    }
                    else
                    {
                        Console.WriteLine("WARNING: Could not delete: " + filePath);
                    }
                }
                foreach (string dir in dirs)
                {
                    string dirPath = Path.Join(Config.SteamGameDir(), dir);
                    if (Directory.Exists(dirPath))
                    {
                        Console.WriteLine("Deleting: " + dirPath);
                        DeleteDirectory(dirPath);
                    }
                    else
                    {
                        Console.WriteLine("WARNING: Could not delete: " + dirPath);
                    }
                }

                UpdateStatus();
                return;
            }

            // Popup dialog
            var ff5exePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "|FINAL FANTASY V.exe";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of our EXE file
                    ff5exePath = openFileDialog.FileName;
                }
            }

            // Now save the parent directory.
            if (ff5exePath != "")
            {
                string? parentDir = Path.GetDirectoryName(ff5exePath);
                if (parentDir != null && parentDir != "")
                {
                    Config.SetSteamGameDir(parentDir);
                    txtSteamDir.Text = Config.SteamGameDir();
                    UpdateStatus();
                }
            }
        }



        private void SetCharaNames()
        {
            for (int i = 0; i < AllCharas.Count; i++)
            {
                string name = Config.CharaName(AllCharas[i]);
                if (name != "")
                {
                    AllTxts[i].Text = name;
                }
            }
        }


        private void UpdateStatus()
        {
            // Update check boxes and the TODO label
            bool readyToGo = InstallStatus.UpdateStatus(chkValidDir, chkBepIn, chkConfig, chkMagicite, chkExport, lblDirLbl, lblDirections, btnChoose, btnDoStuff);

            // Enable remaining components
            lblCharaNames.Visible = readyToGo;
            tblCharaNames.Visible = readyToGo;
            lblNpcs.Visible = readyToGo;
            tblNpcNames.Visible = readyToGo;
            btnApply.Enabled = readyToGo;
            btnCleanse.Enabled = readyToGo;

            // Remove focus from "uninstall"
            if (readyToGo)
            {
                btnChoose.TabStop = false;
                btnApply.Focus();
            }

            // Update character pictures
            //if (readyToGo && AllPicts[0].Image == null)
            //{
            //    Assets.LoadCharaFrames();
            //    PictBoxes.UpdatePictBoxes();
            //}

            // Set up our combo boxes
            if (readyToGo && AllCombos[0].DataSource == null)
            {
                Assets.LoadCharaFrames();
                PictBoxes.UpdatePictBoxes();

                // Set data source; the rest should "just work" (tm)
                for (int i = 0; i < AllCharas.Count; i++)
                {
                    // Retrieve our override sprite, and revert it if a file is not present (for Custom sprites)
                    string sprName = GetSpriteName(AllCharas[i]);
                    if (!Assets.sprite_names_ordered.Contains(sprName))
                    {
                        Console.WriteLine("ERROR: Sprite '" + sprName + "' does not exist; resetting to: '" + AllCharas[i] + "'");
                        Config.SetSpriteName(AllCharas[i], AllCharas[i]);
                        sprName = GetSpriteName(AllCharas[i]);
                    }

                    // Allowed matches
                    List<string> allowed = new List<string> { "Chara" };

                    // Produce a List that only includes valid entries. 
                    // Note: Make sure this array is not shared, or else your ComboBoxes will update weirdly (can fix by cloning the array).
                    var ds = new List<TextAndValue>();
                    foreach (var name in Assets.sprite_names_ordered)
                    {
                        // NPCs have lots of custom animations, and it's hard to provide a good override (since we can only provide one)
                        // without sacrificing a good override for our custom sprites. So, we restrict each NPC to its own graphic (or Chara graphis).
                        bool overrideFlag = false;
                        if ((!AllIsCharaType[i]) && AllCharas[i].Equals(name))
                        {
                            overrideFlag = true;
                        }

                        // Normal check
                        if (allowed.Contains(Assets.chara_sprites[name].spriteType) || overrideFlag)
                        {
                            ds.Add(new TextAndValue(name));
                        }
                    }
                    AllCombos[i].DataSource = ds;

                    // Well, we also need to do this...
                    SetComboSprite(AllCombos[i], /*AllPicts[i],*/ sprName);
                }
            }

            // Dynamic: Chara names
            for (int i = 0; i < AllCharas.Count; i++)
            {
                AllTxts[i].Text = GetCharaName(AllCharas[i]);
            }

            // Clear status
            lblStatus.Text = "";
        }

        // Helper: Get the 'default' character name, or the override if it exists
        private string GetCharaName(string name)
        {
            // Retrieve override
            string res = Config.CharaName(name);
            if (res != "")
            {
                return res;
            }

            // Init
            Config.SetCharaName(name, name);
            return name;
        }

        // Helper: Get the 'default' sprite name, or the override if it exists
        private string GetSpriteName(string name)
        {
            // Retrieve override
            string res = Config.SpriteName(name);
            if (res != "")
            {
                return res;
            }

            // Init
            Config.SetSpriteName(name, name);
            return name;
        }

        // Helper: Set a combo box and pic box correctly
        private void SetComboSprite(ComboBox cbox, /*PictureBox pic,*/ string spriteName)
        {
            //  TODO: re-write to use "SelectedItem" or something similar.
            cbox.SelectedItem = new TextAndValue(spriteName);

            // Update the pictbox
            //pic.Image = PictBoxes.CharaPicSprites[spriteName];
        }

        private void btnDoStuff_Click(object sender, EventArgs e)
        {
            // Disable and wait for feedback
            btnDoStuff.ForeColor = SystemColors.ControlText;
            btnDoStuff.BackColor = SystemColors.Control;
            btnDoStuff.Enabled = false;

            int rc = InstallStatus.DoInstall(btnDoStuff);
            if (rc == 1)
            {
                UpdateStatus();
            }
            else if (rc == 2)
            {
                Task.Run((Action)FF5Scanner);
            }
        }


        private void FF5Scanner()
        {
            Console.WriteLine("Waiting for FF5 to close...");
            bool ff5Started = false;
            bool ff5Running = true;
            while ((!ff5Started) || ff5Running)
            {
                Thread.Sleep(1000);
                ff5Running = false;
                foreach (Process proc in Process.GetProcesses())
                {
                    if (proc.ProcessName == "FINAL FANTASY V")
                    {
                        ff5Started = true;
                        ff5Running = true;
                        break;
                    }
                }
            }
            Console.WriteLine("Thread exiting.");
            this.BeginInvoke(new MethodInvoker(UpdateStatus));
        }

        private void txtBartz_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Bartz", txtBartz.Text);
        }

        private void txtLenna_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Lenna", txtLenna.Text);
        }

        private void txtGaluf_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Galuf", txtGaluf.Text);
        }

        private void txtFaris_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Faris", txtFaris.Text);
        }

        private void txtKrile_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Krile", txtKrile.Text);
        }

        private void txtTycoon_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("King Tycoon", txtTycoon.Text);
        }

        private void txtGilgamesh_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Gilgamesh", txtGilgamesh.Text);
        }

        private void txtExdeath_TextChanged(object sender, EventArgs e)
        {
            Config.SetCharaName("Exdeath", txtExdeath.Text);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Clear status
            lblStatus.Text = "";

            Assets.MakeWGRPGDir();
            Assets.CloneSrcDirs();
            Assets.LoadAll();
            string error = NameChange.DoRename();
            error += SpriteChange.DoChange();
            Assets.SaveAll();

            // Set status
            if (error == "")
            {
                lblStatus.Text = "Changes applied successfully! You can now launch FF5.";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "ERROR: " + error;
                lblStatus.ForeColor = Color.Red;
            }
        }


        // Measure a custom combo box's size
        private void cbMeasureCustomItem(object sender, MeasureItemEventArgs e)
        {
            // This should be the same regardless
            e.ItemWidth = 100;
            e.ItemHeight = 38;  // NOTE: Maybe only affects the list?
        }

        // Draw a custom combo box
        private void cbDrawCustomItem(object sender, DrawItemEventArgs e)
        {
            // Who are we drawing?
            string charaName = ((TextAndValue)((ComboBox)sender).Items[e.Index]).Value;

            // Draw the background of the item.
            e.DrawBackground();

            // Draw our sprite
            Bitmap spr = PictBoxes.CharaPicSprites[charaName];
            e.Graphics.DrawImage(spr, e.Bounds.Left, e.Bounds.Top);

            // Draw our text
            if (myFont == null)
            {
                myFont = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Italic);
            }
            e.Graphics.DrawString("(" + charaName + ")", myFont, System.Drawing.Brushes.Black, e.Bounds.Left + 32, e.Bounds.Top);

            // Draw the mouse hover
            e.DrawFocusRectangle();
        }

        private void cbSelItemChanged(object sender, EventArgs e)
        {
            // Figure out which box changed
            ComboBox cb = (ComboBox)sender;
            //PictureBox? pbox = null;
            string charaName = "";

            // Probably our best bet
            for (int i = 0; i < AllCharas.Count; i++)
            {
                if (cb == AllCombos[i])
                {
                    charaName = AllCharas[i];
                    //pbox = AllPicts[i];
                    break;
                }
            }

            // Grr...
            //if (pbox == null)
            //{
            //    throw new Exception("Unknown combo box.");
            //}

            // What are we changing to?
            string newCharName = ((TextAndValue)cb.SelectedItem).Value;

            // Save it.
            Config.SetSpriteName(charaName, newCharName);

            // And update the PictBox
            //pbox.Image = PictBoxes.CharaPicSprites[newCharName];
        }

        private void btnCleanse_Click(object sender, EventArgs e)
        {
            // Clear status
            lblStatus.Text = "";

            // Only need to delete one directory.
            string dirPath = Path.Join(Config.SteamGameDir(), Constants.MagiciteImportDir);
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("Deleting: " + dirPath);
                DeleteDirectory(dirPath);
            }

            // Set status
            lblStatus.Text = "All changes removed; game is back to normal! (Don't worry, the mod is still installed)";
            lblStatus.ForeColor = Color.Green;
        }


    }
}
