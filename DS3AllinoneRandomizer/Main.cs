using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3AllinoneRandomizer
{
    public partial class Main : Form
    {
        private string FOLDER_PATH_DS3 {get;set;}
        private bool EnemyRandoInstalled { get; set; }
        private bool ItemRandoInstalled { get; set; }
        private bool ModEngineInstalled { get; set; }
        private bool CindersInstalled { get; set; }
        private bool Savebackedup { get; set; }

        public Progress<ZipProgress> _progress;
        public Main()
        {
            InitializeComponent();
            toolStripLabel1.Text = $" Version: {Assembly.GetExecutingAssembly().GetName().Version.Major}.{Assembly.GetExecutingAssembly().GetName().Version.Minor}.{Assembly.GetExecutingAssembly().GetName().Version.Build}";

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

            _progress = new Progress<ZipProgress>();
            _progress.ProgressChanged += Report;
        }

        private void Report(object sender, ZipProgress zipProgress)
        {
            //Use zipProgress here to update the UI on the progress.
            pb_Cinders.Value = zipProgress.Processed;
            pb_Cinders.Maximum = zipProgress.Total;
            pb_Cinders.Refresh();

            if (zipProgress.Processed == zipProgress.Total)
            {
                pb_Cinders.Value = 0;
                pb_Cinders.Hide();
                CheckModInstall();
            }
        }

        private void btn_ModEngineInstall_Click(object sender, EventArgs e)
        {
            try
            {
                string zipPath = @".\Zips\ModEngine.zip";
                string extractPath = this.FOLDER_PATH_DS3;

                var files = Directory.EnumerateFiles(extractPath);
                if (files.Contains(extractPath + "\\" + "dinput8.dll") || files.Contains(extractPath + "\\" + "modengine.ini"))
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
            catch (Exception ex)
            {

            }


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
                    System.IO.File.Copy(@".\pooremma\pooremma.exe", extractPath+ @"\pooremma.exe", true);
                    System.IO.File.Copy(@".\pooremma\SoulsFormats.dll", extractPath+ @"\SoulsFormats.dll", true);
                }
                CheckModInstall();
            }
            catch (Exception ex)
            {

            }

        }


        private void btn_ItemRandoStart_Click(object sender, EventArgs e)
        {
            // For the example
            string extractPath = this.FOLDER_PATH_DS3 + @"\randomizer";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = extractPath + @"\DS3Randomizer.exe";
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
            catch (Exception ex)
            {

            }
        }


        private void CheckModInstall()
        {

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

                if (IsDirectoryEmpty(this.FOLDER_PATH_DS3 + "\\" + "mod") == true)
                {
                    lbl_ItemRandoWarning.Text = "Please reinstall Item randomizer to remove Enemy randomizer files";
                    lbl_ItemRandoWarning.ForeColor = Color.Red;
                    lbl_ItemRandoWarning.Show();
                }
                else
                {
                    lbl_ItemRandoWarning.Hide();
                }
            }
            else
            {
                lbl_ItemRandoInstallStatus.Text = "Not Installed";
                lbl_ItemRandoInstallStatus.ForeColor = Color.Red;
                btn_ItemRandoInstall.Text = "Install";
                lbl_ItemRandoWarning.Hide();
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

            this.CindersInstalled = !IsDirectoryEmpty(this.FOLDER_PATH_DS3 + "\\" + "Cinders");
            //Check if mods are installed
            if (CindersInstalled)
            {

                lbl_CindersInstalled.Text = "Installed";
                lbl_CindersInstalled.ForeColor = Color.Green;
                btn_InstallCinders.Text = "Uninstall";
            }
            else
            {
                lbl_CindersInstalled.Text = "Not Installed";
                lbl_CindersInstalled.ForeColor = Color.Red;
                btn_InstallCinders.Text = "Install";
            }

            string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + @"DarkSoulsIII";
            var Directories = System.IO.Directory.GetDirectories(SaveFilePath);

            var SaveDir = Directories[0];
            if (System.IO.Directory.Exists(SaveDir + "\\" + "backup"))
            {
                if (System.IO.Directory.GetFiles(SaveDir + "\\" + "backup").Length > 0)
                {
                    this.Savebackedup = true;
                    btn_backupSaves.Text = "Restore old save files";
                }
                else
                {
                    this.Savebackedup = false;
                    btn_InstallSave.Text = "Install fresh save";
                    btn_backupSaves.Text = "Backup save files";
                }
            }
            else
            {
                this.Savebackedup = false;
                //btn_backupSaves.Text = "Backup save files";
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
            CheckModInstall();
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
            catch (Exception ex)
            {
                return true;
            }
            return IsEmpty;
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {

            }
        }

        private void tsmi_Save_Click(object sender, EventArgs e)
        {
           

            if (!ClosingCheck())
            {
                Environment.Exit(0);
            }
        }

        private void tsmi_ChangeDir_Click(object sender, EventArgs e)
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

        private void tsb_Credits_Click(object sender, EventArgs e)
        {
            Credits Credits = new Credits();
            Credits.Show();
        }

        private bool ClosingCheck()
        {
            if (this.ModEngineInstalled && (this.EnemyRandoInstalled || this.ItemRandoInstalled || this.CindersInstalled))
            {
                return false;
            }
            else
            {
                if (this.ModEngineInstalled == false && (this.EnemyRandoInstalled || this.ItemRandoInstalled || this.CindersInstalled) == false)
                {
                    return false;
                }

                if (!this.ModEngineInstalled)
                {
                    MessageBox.Show("Please make sure ModEngine is installed");
                    return true;
                }

                if (!(this.EnemyRandoInstalled || this.ItemRandoInstalled || this.CindersInstalled))
                {
                    MessageBox.Show("Please make sure there is atleast one mod installed");
                    return true;
                }

                return true;
            }
        }

        private void btn_OpenItemTracker_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@".\DS3_Tracker\DS3Tracker.html");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = ClosingCheck();
        }

        private void tsmi_OpenGameDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(this.FOLDER_PATH_DS3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant find game directory please set location using \"Change DS3 Location\"");
            }
        }

        private void btn_InstallCinders_Click(object sender, EventArgs e)
        {
            try
            {

                if (!this.Savebackedup)
                {
                    MessageBox.Show("Please backup save files before installing cinders");
                    return;
                }
                if (!this.ModEngineInstalled)
                {
                    MessageBox.Show("Please make sure ModEngine is installed before installing Cinders");
                    return;
                }
                var Files = System.IO.Directory.GetFiles(@".\Zips");
                var CindersFileFound = Files.Any(s => s.ToLower().Contains("cinders"));

                string stringToCheck = "cinders";
                var CindersFileName = "";
                foreach (string x in Files)
                {
                    if (x.ToLower().Contains(stringToCheck))
                    {
                        CindersFileName = x;
                        break;
                    }
                }
                
                if (!CindersFileFound)
                {
                    MessageBox.Show("Please Copy Cinders zip file to the Zips folder");
                    return;
                }
                if (this.EnemyRandoInstalled)
                {
                    string EnemyRandoInstalledPath = this.FOLDER_PATH_DS3 + @"\mod";
                    if (System.IO.Directory.Exists(EnemyRandoInstalledPath))
                    {
                        System.IO.Directory.Delete(EnemyRandoInstalledPath, true);
                    }
                }
                if (this.ItemRandoInstalled)
                {
                    string ItemRandoInstalledPath = this.FOLDER_PATH_DS3 + @"\randomizer";
                    if (System.IO.Directory.Exists(ItemRandoInstalledPath))
                    {
                        System.IO.Directory.Delete(ItemRandoInstalledPath, true);
                    }
                }
                string text = File.ReadAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini");
                string zipPath = CindersFileName;//@".\Zips\Cinders.zip";
                string extractPath = this.FOLDER_PATH_DS3;
                if (System.IO.Directory.Exists(extractPath + @"\Cinders"))
                {
                    System.IO.Directory.Delete(extractPath + @"\Cinders", true);
                    text = text.Replace(@"loadLooseParams=1", @"loadLooseParams=0");
                    CheckModInstall();
                }
                else
                {
                    string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/DarkSoulsIII";
                    string SaveFilezipPath = @".\Zips\Save.zip";
                    if (System.IO.Directory.Exists(SaveFilePath))
                    {
                        System.IO.Compression.ZipFile.ExtractToDirectory(SaveFilezipPath, SaveFilePath);
                    }

                    //Stream zipReadingStream = System.IO.File.OpenRead(zipPath);
                    //ZipArchive zip = new ZipArchive(zipReadingStream);
                    pb_Cinders.Show();
                    lbl_CindersExtractText.Show();
                    lbl_CindersExtractText.Text = "Installing Cinders Please wait..";
                    //System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                   
                    Task.Run(() => { BeginDecompression(zipPath, extractPath);  });
                }

               
                text = text.Replace(@"\mod", @"\Cinders");
                text = text.Replace(@"\randomizer", @"\Cinders");

                text = text.Replace(@"loadLooseParams=0", @"loadLooseParams=1");
                File.WriteAllText(this.FOLDER_PATH_DS3 + "\\" + "modengine.ini", text);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not install cinders");
            }
        }

        public static double Percentage { get; set; }

        public static long totalSize { get; set; }

        public static long completed { get; set; }

        public void BeginDecompression(string filePath, string extractPath)
        {
            try
            {

                Directory.CreateDirectory(extractPath);
                IArchive archive = ArchiveFactory.Open(filePath);

                // Calculate the total extraction size.
                totalSize = archive.TotalUncompressSize;
                completed = 0;
                if (filePath.Contains(".7z"))
                {
                    var reader = archive.ExtractAllEntries();
                    while (reader.MoveToNextEntry())
                    {
                        if (!reader.Entry.IsDirectory)
                        {
                            reader.WriteEntryToDirectory(extractPath, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                            completed += reader.Entry.Size;
                            Percentage = ((double)completed / (double)totalSize) * 100;
                            pb_Cinders.Invoke(new MethodInvoker(delegate { pb_Cinders.Value = Convert.ToInt32(Percentage); }));
                            pb_Cinders.Invoke(new MethodInvoker(delegate { pb_Cinders.Refresh(); }));
                        }
                       
                    }
                }
                else
                {
                    //Console.WriteLine(totalSize);
                    foreach (IArchiveEntry entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        //archive.CompressedBytesRead += Archive_CompressedBytesRead;
                        entry.WriteToDirectory(extractPath, new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                        completed += entry.Size;
                        Percentage = ((double)completed / (double)totalSize) * 100;
                        pb_Cinders.Invoke(new MethodInvoker(delegate { pb_Cinders.Value = Convert.ToInt32(Percentage); }));
                        pb_Cinders.Invoke(new MethodInvoker(delegate { pb_Cinders.Refresh(); }));
                    }


                }

                if (Percentage >= 100)
                {
                    pb_Cinders.Invoke(new MethodInvoker(delegate { pb_Cinders.Hide(); }));
                    lbl_CindersExtractText.Invoke(new MethodInvoker(delegate { lbl_CindersExtractText.Hide(); }));
                    Invoke(new MethodInvoker(delegate { CheckModInstall(); }));
                }


            }
            catch (Exception ex)
            {

            }
        }
        public void Archive_CompressedBytesRead(object sender, CompressedBytesReadEventArgs e)
        {
            Percentage = ((double)e.CompressedBytesRead / (double)totalSize) * 100;
        }

        private void btn_PlayDarksouls3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = this.FOLDER_PATH_DS3 + @"\DarkSoulsIII.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = this.FOLDER_PATH_DS3 + "\\";

            try
            {
                Process.Start(startInfo);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not launch Darksouls 3 please run the application as admin");
            }
        }

        private void openSaveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + @"DarkSoulsIII";
            try
            {
               
                Process.Start(SaveFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant find save directory : "+ SaveFilePath);
            }
        }

        private void btn_InstallSave_Click(object sender, EventArgs e)
        {
            try
            {
                string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + @"DarkSoulsIII";
                var Directories = System.IO.Directory.GetDirectories(SaveFilePath);
                var Files = System.IO.Directory.GetFiles(Directories[0]);
                if (!this.Savebackedup)
                {
                    MessageBox.Show("Please backup save files before installing fresh save");
                    return;
                }

                var SaveDir = Directories[0];

                string SaveFilezipPath = @".\Zips\Save.zip";
                System.IO.File.Delete(SaveDir + "\\" + "DS30000.sl2");
                System.IO.Compression.ZipFile.ExtractToDirectory(SaveFilezipPath, SaveDir);
                btn_InstallSave.Text = "Fresh save installed";
                //if (!System.IO.File.Exists(SaveDir + "\\" + "DS30000.sl2"))
                //{

                //    System.IO.Compression.ZipFile.ExtractToDirectory(SaveFilezipPath, SaveDir);
                //    btn_InstallSave.Text = "Fresh save installed";
                //}
                //else
                //{
                //    System.IO.File.Delete(SaveDir + "\\" + "DS30000.sl2");
                //    btn_InstallSave.Text = "Install fresh save file";
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not install or restore save files");
            }

        }

        private void btn_backupSaves_Click(object sender, EventArgs e)
        {
            try
            {
                string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + @"DarkSoulsIII";
                var Directories = System.IO.Directory.GetDirectories(SaveFilePath);
                var Files = System.IO.Directory.GetFiles(Directories[0]);
                var SaveDir = Directories[0];

                if (!System.IO.Directory.Exists(SaveDir + "\\" + "backup"))
                {

                    System.IO.Directory.CreateDirectory(Path.Combine(SaveDir + "\\", "backup"));

                    foreach (var file in Files)
                    {
                        FileInfo fi = new FileInfo(file);
                        System.IO.File.Move(file, Path.Combine(SaveDir + "\\", "backup") + "\\" + fi.Name);
                    }
                    btn_InstallSave.Text = "Install fresh save";
                    btn_backupSaves.Text = "Restore backup saves";
                    this.Savebackedup = true;
                }
                else
                {
                    this.Savebackedup = false;
                    var BackupFiles = System.IO.Directory.GetFiles(SaveDir + "\\" + "backup");
                    System.IO.File.Delete(SaveDir + "\\" + "DS30000.sl2");
                    foreach (var file in BackupFiles)
                    {
                        FileInfo fi = new FileInfo(file);
                        System.IO.File.Move(file, SaveDir + "\\" + fi.Name);
                    }
                    System.IO.Directory.Delete(Path.Combine(SaveDir + "\\", "backup"));
                    btn_backupSaves.Text = "Backup save files";
                    btn_InstallSave.Text = "Install fresh save";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not install or restore save files");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start(@".\Zips");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant find zips directory ");
            }
        }
    }
}
