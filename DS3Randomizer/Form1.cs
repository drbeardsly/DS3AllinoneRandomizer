using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3Randomizer
{
    public partial class Form1 : Form
    {
        private string FOLDER_PATH_DS3 {get;set;}
        private bool EnemyRandoInstalled { get; set; }
        private bool ItemRandoInstalled { get; set; }
        private bool ModEngineInstalled { get; set; }

        public Form1()
        {
            InitializeComponent();
            lbl_Version.Text =$"Version: {Assembly.GetExecutingAssembly().GetName().Version}";

            //Find and check DS3 Dir
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSelectedFolder))
            {
                this.FOLDER_PATH_DS3 = Properties.Settings.Default.LastSelectedFolder;
            }
            else
            {
                this.FOLDER_PATH_DS3 = GamePath.TryGetSteamGameRegistryPath();
            }
            CheckInstallDir();
            CheckModInstall();
            chkb_OnlyEnemyRando.Checked = Properties.Settings.Default.OnlyEnemyRando;
            chkb_OnlyItemRando.Checked = Properties.Settings.Default.OnlyItemRando;
        }

        private void btn_ModEngineInstall_Click(object sender, EventArgs e)
        {
            string zipPath = @".\Zips\ModEngine.zip";
            string extractPath = this.FOLDER_PATH_DS3;

            var files = Directory.EnumerateFiles(extractPath);
            if (files.Contains(extractPath + "\\" + "dinput8.dll") && files.Contains(extractPath + "\\" + "modengine.ini"))
            {
                System.IO.File.Delete(this.FOLDER_PATH_DS3 + "\\" + "dinput8.dll");
                System.IO.File.Delete(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini");
            }
            else
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            CheckModInstall();

        }

        private void btn_EnemyRandoStart_Click(object sender, EventArgs e)
        {
            // For the example
            string extractPath = this.FOLDER_PATH_DS3 + @"\mod";


            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = extractPath + @"\pooremma.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = extractPath;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void btn_EnemyRandoInstall_Click(object sender, EventArgs e)
        {
            try
            {
                string zipPath = @".\Zips\Enemy.zip";
                string extractPath = this.FOLDER_PATH_DS3 + @"\mod";
                if (System.IO.Directory.Exists(extractPath))
                {
                    System.IO.Directory.Delete(extractPath, true);
                }
                else
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                CheckModInstall();
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void btn_ItemRandoStart_Click(object sender, EventArgs e)
        {
            // For the example
            string extractPath = this.FOLDER_PATH_DS3 + @"\randomizer";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = extractPath + @".\DS3Randomizer.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = extractPath;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void btn_ItemRandoInstall_Click(object sender, EventArgs e)
        {
            try
            {
                string zipPath = @".\Zips\Item.zip";
                string extractPath = this.FOLDER_PATH_DS3 + @"\randomizer";
                if (System.IO.Directory.Exists(extractPath))
                {
                    System.IO.Directory.Delete(extractPath, true);
                }
                else
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                CheckModInstall();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btn_SetInstallDir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            openFolderDialog.SelectedPath = Properties.Settings.Default.LastSelectedFolder;

            if (openFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var DS3Path = "";
                DS3Path = openFolderDialog.SelectedPath.ToString();

                if (!DS3Path.Contains("Game"))
                {
                    DS3Path = DS3Path + "\\" + "Game";
                }
                Properties.Settings.Default.LastSelectedFolder = DS3Path;
                Properties.Settings.Default.Save();

                this.FOLDER_PATH_DS3 = Properties.Settings.Default.LastSelectedFolder;
                CheckInstallDir();
            }
        }

        private void CheckModInstall()
        {
            if (this.EnemyRandoInstalled && IsDirectoryEmpty(this.FOLDER_PATH_DS3 + "\\" + "mod") == true)
            {
                lbl_ItemRandoWarning.Text = "Please reinstall Item randomizer to remove Enemy randomizer files";
                lbl_ItemRandoWarning.ForeColor = Color.Red;
                lbl_ItemRandoWarning.Show();
            }
            else
            {
                lbl_ItemRandoWarning.Hide();
            }
            this.EnemyRandoInstalled = !IsDirectoryEmpty(this.FOLDER_PATH_DS3 + "\\" + "mod");
            //Check if mods are installed
            if (EnemyRandoInstalled)
            {

                lbl_EnemyRandoInstallStatus.Text = "Installed";
                lbl_EnemyRandoInstallStatus.ForeColor = Color.Green;
                btn_EnemyRandoInstall.Text = "Uninstall";
            }
            else
            {
                lbl_EnemyRandoInstallStatus.Text = "Not Installed";
                lbl_EnemyRandoInstallStatus.ForeColor = Color.Red;
                btn_EnemyRandoInstall.Text = "Install";
            }

            this.ItemRandoInstalled = !IsDirectoryEmpty(this.FOLDER_PATH_DS3 + "\\" + "randomizer");
            //Check if mods are installed
            if (ItemRandoInstalled)
            {
                lbl_ItemRandoInstallStatus.Text = "Installed";
                lbl_ItemRandoInstallStatus.ForeColor = Color.Green;
                btn_ItemRandoInstall.Text = "Uninstall";
            }
            else
            {
                lbl_ItemRandoInstallStatus.Text = "Not Installed";
                lbl_ItemRandoInstallStatus.ForeColor = Color.Red;
                btn_ItemRandoInstall.Text = "Install";
            }

            this.ModEngineInstalled = (System.IO.File.Exists(this.FOLDER_PATH_DS3 + "\\" + "dinput8.dll") && System.IO.File.Exists(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini"));
            //Check if mods are installed
            if (ModEngineInstalled)
            {

                lbl_ModEngineInstallStatus.Text = "Installed";
                lbl_ModEngineInstallStatus.ForeColor = Color.Green;
                btn_ModEngineInstall.Text = "Uninstall";
            }
            else
            {
                lbl_ModEngineInstallStatus.Text = "Not Installed";
                lbl_ModEngineInstallStatus.ForeColor = Color.Red;
                btn_ModEngineInstall.Text = "Install";
            }


        }

        private void CheckInstallDir(string path = "")
        {
            bool exists = false;
            if (!string.IsNullOrEmpty(path))
            {
                exists = System.IO.Directory.Exists(path);
            }
            else
            {
                exists = System.IO.Directory.Exists(this.FOLDER_PATH_DS3);
            }
            
            if (!exists)
            {
                UpdateStatusBarText("Can't find DARK SOULS III directory please find it manually");
                statusStrip1.BackColor = Color.LightCoral;
                //btn_SetInstallDir.Visible = true;
            }
            else
            {
                UpdateStatusBarText("DARK SOULS III found!");
                statusStrip1.BackColor = Color.LightGreen;
                //btn_SetInstallDir.Visible = false;
            }

            //Set Game dir incase wrong dir was selected
            if (!this.FOLDER_PATH_DS3.Contains("Game"))
            {
                Properties.Settings.Default.LastSelectedFolder = this.FOLDER_PATH_DS3 + "\\" + "Game";
                Properties.Settings.Default.Save();
            }

        }

        private void UpdateStatusBarText(string text)
        {
            toolStripStatusLabel1.Text = text;
            statusStrip1.Invalidate();
            statusStrip1.Refresh();
        }

        public bool IsDirectoryEmpty(string path)
        {
            bool IsEmpty = false;
            try
            {
                IsEmpty = !Directory.EnumerateFileSystemEntries(path).Any();
            }
            catch (Exception)
            {
                return true;
            }
            return IsEmpty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.ModEngineInstalled && (this.EnemyRandoInstalled || this.ItemRandoInstalled))
            {
                Environment.Exit(0);
            }
            else
            {
                if (this.ModEngineInstalled == false && (this.EnemyRandoInstalled || this.ItemRandoInstalled) == false)
                {
                    Environment.Exit(0);
                }

                if (!this.ModEngineInstalled)
                {
                    MessageBox.Show("Please make sure ModEngine is installed");
                }

                if (!(this.EnemyRandoInstalled || this.ItemRandoInstalled))
                {
                    MessageBox.Show("Please make sure either Enemy Randomizer or Item Randomizer is installed");
                }


            }
        }

        private void chkb_OnlyEnemyRando_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.OnlyEnemyRando = chkb_OnlyEnemyRando.Checked;
                Properties.Settings.Default.Save();
                if (!this.ModEngineInstalled && chkb_OnlyEnemyRando.Checked != false)
                {
                    MessageBox.Show("Please make sure ModEngine is installed");
                    chkb_OnlyEnemyRando.Checked = false;
                }
                string text = File.ReadAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini");
                if (chkb_OnlyEnemyRando.Checked)
                {
                    if (chkb_OnlyItemRando.Checked)
                    {
                        chkb_OnlyItemRando.Checked = false;
                    }
                    
                    text = text.Replace(@"\randomizer", @"\mod");
                    File.WriteAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini", text);
                }
                else
                {
                    text = text.Replace(@"\mod", @"\randomizer");
                    File.WriteAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini", text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void chkb_OnlyItemRando_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.OnlyItemRando = chkb_OnlyItemRando.Checked;
                Properties.Settings.Default.Save();
                if (!this.ModEngineInstalled && chkb_OnlyItemRando.Checked != false)
                {
                    MessageBox.Show("Please make sure ModEngine is installed");
                    chkb_OnlyItemRando.Checked = false;
                }

                string text = File.ReadAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini");
                if (chkb_OnlyItemRando.Checked)
                {
                    if (chkb_OnlyEnemyRando.Checked)
                    {
                        chkb_OnlyEnemyRando.Checked = false;
                    }
                    text = text.Replace(@"\mod", @"\randomizer");
                    File.WriteAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini", text);
                }
                else
                {
                    text = text.Replace(@"\mod", @"\randomizer");
                    File.WriteAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini", text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_DisableSound_Click(object sender, EventArgs e)
        {
            try
            {
                string OldPath = this.FOLDER_PATH_DS3 + @"\sound";
                string NewPath = this.FOLDER_PATH_DS3 + @"\sound_bak";
                if (System.IO.Directory.Exists(OldPath))
                {
                    System.IO.Directory.Move(OldPath, NewPath);
                    btn_DisableSound.Text = "Enable Sound";
                }
                else
                {
                    System.IO.Directory.Move(NewPath, OldPath);
                    btn_DisableSound.Text = "Disable Sound";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
