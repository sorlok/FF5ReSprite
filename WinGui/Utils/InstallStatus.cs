using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WinGui.FileTypes;

namespace WinGui.Utils
{
    // This class contains static methods that help to set the check boxes and "TODO" label based on the installed state.
    internal class InstallStatus
    {
        // Guesses the FF5 steam dir; retuns that or "" if it can't be determined
        public static string GuessSteamDir()
        {
            // Possible locations
            string[] CommonSteamDirs = {
                Assets.ConvertPath("C:/Program Files (x86)/Steam/steamapps/common/FINAL FANTASY V PR"),
                Assets.ConvertPath("C:/Program Files/Steam/steamapps/common/FINAL FANTASY V PR"),
                Assets.ConvertPath("D:/Programs/Steam/steamapps/common/FINAL FANTASY V PR"),
            };

            // Check each one
            foreach (string candidateDir in CommonSteamDirs)
            {
                if (IsFf5Dir(candidateDir))
                {
                    Console.WriteLine("Found candidate FF5 Steam directory: " + candidateDir);
                    return candidateDir;
                }
            }

            Console.WriteLine("Could not guess FF5 Steam directory.");
            return "";
        }

        // Returns "true" if the given directory is likely the FF5 install location (looks for the .exe file)
        private static bool IsFf5Dir(string path)
        {
            if (File.Exists(Path.Join(path, "FINAL FANTASY V.exe")))
            {
                return true;
            }
            return false;
        }

        // Returns "true" if the BepIn directory is present
        private static bool IsBepInPresent(string path)
        {
            return Directory.Exists(Path.Join(path, "BepInEx")) && File.Exists(Path.Join(path, "winhttp.dll"));
        }

        // Returns "true" if BepIn has created its config file
        private static bool IsBepInConfigured(string path)
        {
            return File.Exists(Path.Join(path, "BepInEx\\config\\BepInEx.cfg"));
        }

        // Returns "true" if the Magicite mod has been installed.
        private static bool IsMagiciteInstalled(string path)
        {
            return File.Exists(Path.Join(path, "BepInEx", "plugins", "Magicite.dll")) && File.Exists(Path.Join(path, "BepInEx", "plugins", "Magicite.bundle"));
        }

        // Returns "true" if Magicite has exported FF5 resources.
        private static bool IsResExported(string path)
        {
            return Directory.Exists(Path.Join(path, "FINAL FANTASY V_Data", "StreamingAssets", "MagiciteExport"));
        }


        // Returns "true" if we're good to go; "false" if we've still got tasks to perform.
        public static bool UpdateStatus(CheckBox chkValidDir, CheckBox chkBepIn, CheckBox chkConfig, CheckBox chkMagicite, CheckBox chkExport, Label lblDirLbl, Label lblDirections, Button btnChooseDir, Button btnDoStuff)
        {
            // Start by setting everything to "off"
            chkValidDir.Checked = false;
            chkBepIn.Checked = false;
            chkConfig.Checked = false;
            chkMagicite.Checked = false;
            chkExport.Checked = false;
            btnDoStuff.Visible = false; // Our "do something" button
            btnDoStuff.Enabled = true;
            btnChooseDir.Text = "Choose...";
            btnChooseDir.Enabled = true;
            btnChooseDir.ForeColor = SystemColors.ControlText;
            btnChooseDir.BackColor = SystemColors.Control;

            // Each of these cascades into the other; the first that fails sets the error mesage
            string errorMsg = "";
            if (IsFf5Dir(Config.SteamGameDir()))
            {
                chkValidDir.Checked = true;

                if (IsBepInPresent(Config.SteamGameDir()))
                {
                    chkBepIn.Checked = true;

                    if (IsBepInConfigured(Config.SteamGameDir()))
                    {
                        chkConfig.Checked = true;

                        if (IsMagiciteInstalled(Config.SteamGameDir()))
                        {
                            chkMagicite.Checked = true;

                            if (IsResExported(Config.SteamGameDir()))
                            {
                                chkExport.Checked = true;
                                btnChooseDir.Text = "Un-Install";
                            }
                            else
                            {
                                errorMsg = "Export requird. Press \"Start FF5\" to run the game, then exit it at the title screen. THIS IS SLOW!";
                                btnDoStuff.Text = "Start FF5";
                                btnDoStuff.BackColor = Color.Thistle;
                                //btnDoStuff.Location = new Point(950, 57);
                                btnDoStuff.Visible = true;
                            }
                        }
                        else
                        {
                            errorMsg = "The Magicite mod must be installed. Press \"Install Magicite\" to install it.";
                            btnDoStuff.Text = "Install Magicite";
                            btnDoStuff.BackColor = Color.Yellow;
                            btnDoStuff.Visible = true;
                        }
                    }
                    else
                    {
                        errorMsg = "Config needs to be generated. Press \"Start FF5\" to run the game, then exit it at the title screen.";
                        btnDoStuff.Text = "Start FF5";
                        btnDoStuff.BackColor = Color.Cyan;
                        btnDoStuff.Visible = true;
                    }
                }
                else
                {
                    errorMsg = "The BepInEx mod must be installed. Press \"Install BepInEx\" to install it.";
                    btnDoStuff.Text = "Install BepInEx";
                    btnDoStuff.BackColor = Color.Yellow;
                    btnDoStuff.Visible = true;
                }
            }
            else
            {
                errorMsg = "Invalid FF5 (Steam) Folder. Please press \"Choose\" and select the folder \"FINAL FANTASY V PR\".";
                btnChooseDir.ForeColor = Color.Red;
                btnChooseDir.BackColor = Color.Yellow;
            }

            // Update colors
            chkValidDir.ForeColor = chkValidDir.Checked ? Color.Black : Color.Red;
            chkBepIn.ForeColor = chkBepIn.Checked ? Color.Black : Color.Red;
            chkConfig.ForeColor = chkConfig.Checked ? Color.Black : Color.Red;
            chkMagicite.ForeColor = chkMagicite.Checked ? Color.Black : Color.Red;
            chkExport.ForeColor = chkExport.Checked ? Color.Black : Color.Red;

            // Update the label
            if (errorMsg.Length > 0)
            {
                lblDirLbl.ForeColor = Color.Red;
                lblDirLbl.Text = "ACTION NEEDED:";
                lblDirLbl.Visible = true;

                lblDirections.Text = errorMsg;
                lblDirections.ForeColor = Color.Black;
            }
            else
            {
                lblDirLbl.ForeColor = Color.Black;
                lblDirLbl.Text = "";
                lblDirLbl.Visible = false;

                lblDirections.Text = "Everying you need is installed correctly. You can now modify the game using the controls below.";
                lblDirections.ForeColor = Color.Black;
            }

            return errorMsg.Length == 0;
        }

        // Perform an "install" via the "Do Stuff" button.
        // Return value:
        //   0 = do nothing; the install failed
        //   1 = run "UpdateStatus()"; the install succeeded.
        //   2 = run our "UpdateStatusChecker()" thread that waits for FF5 to exit.
        public static int DoInstall(Button btnDoStuff)
        {
            if (btnDoStuff.Text == "Install BepInEx")
            {
                btnDoStuff.Text = "Installing...";

                // Check
                string srcFile = Assets.ConvertPath("%APP_DIR%/in/BepInEx_UnityIL2CPP_x64_ec79ad0_6.0.0-be.577.zip");
                string destDir = Config.SteamGameDir();
                if (!File.Exists(srcFile))
                {
                    Console.WriteLine("ERROR: File does not exist: " + srcFile);
                    return 0;
                }

                // Unzip
                ZipFile.ExtractToDirectory(srcFile, destDir);
                Console.WriteLine("Extracted " + srcFile + " to: " + destDir);
            }
            else if (btnDoStuff.Text == "Install Magicite")
            {
                btnDoStuff.Text = "Installing...";

                // Check
                string srcFile = Assets.ConvertPath("%APP_DIR%/in/Magicite-2-0-0-release.zip");
                string destDir = Config.SteamGameDir();
                if (!File.Exists(srcFile))
                {
                    Console.WriteLine("ERROR: File does not exist: " + srcFile);
                    return 0;
                }

                // Unzip
                ZipFile.ExtractToDirectory(srcFile, destDir);
                Console.WriteLine("Extracted " + srcFile + " to: " + destDir);
            }
            else if (btnDoStuff.Text == "Start FF5")
            {
                btnDoStuff.Text = "Starting...";

                // Re-write the config file to allow export if we need to export
                if (IsMagiciteInstalled(Config.SteamGameDir()) && !IsResExported(Config.SteamGameDir()))
                {
                    Console.WriteLine("Re-writing config for export");
                    String cfgFile = Path.Join(Config.SteamGameDir(), "BepInEx", "config", "silvris.magicite.cfg");
                    if (!File.Exists(cfgFile))
                    {
                        // Just give them something; don't make them run the game just for this config file.
                        StreamWriter outFile = new StreamWriter(cfgFile, false, Encoding.UTF8);
                        outFile.WriteLine("# Bare-bones file; delete it if you want Magicite to generate a proper one.");
                        outFile.WriteLine("[General]");
                        outFile.WriteLine("Export Enabled = true");
                        outFile.WriteLine("[Magicite Paths]");
                        outFile.WriteLine("Import Directory = %StreamingAssets%/Magicite");
                        outFile.WriteLine("Export Directory = %StreamingAssets%/MagiciteExport");
                        outFile.Close();

                    }
                    else
                    {
                        // We handle this as a text file to ensure Microsoft doesn't mess with our INI syntax
                        string[] lines = File.ReadAllLines(cfgFile);
                        StreamWriter outFile = new StreamWriter(cfgFile, false, Encoding.UTF8);
                        foreach (string line in lines)
                        {
                            if (line.StartsWith("Export Enabled"))
                            {
                                outFile.WriteLine("Export Enabled = true");
                            }
                            else
                            {
                                outFile.WriteLine(line);
                            }
                        }
                        outFile.Close();
                    }
                }

                // Running from steam itself is more reliable; if you run the FF5.exe directly, it will "re-launch" with steam, which
                //   messes up our detection script.
                string steamExe = Assets.ConvertPath("%STEAM_GAME_DIR%/../../../steam.exe");
                Process? p = null;
                if (File.Exists(steamExe))
                {
                    p = Process.Start(steamExe, "steam://rungameid/1173810");
                }
                else
                {
                    string ff5exe = Assets.ConvertPath("%STEAM_GAME_DIR%/FINAL FANTASY V.exe");
                    p = Process.Start(ff5exe);
                }
                
                if (p == null)
                {
                    Console.WriteLine("ERROR: Could not start FF5 (may need to start manually)");
                    return 0;
                }

                return 2;
            }
            else
            {
                Console.WriteLine("Don't know how to DoStuff: " + btnDoStuff.Text);
            }

            return 1;
        }
    }


}
