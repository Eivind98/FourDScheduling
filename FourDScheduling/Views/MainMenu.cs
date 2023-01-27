using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xbim.Ifc.Extensions;
using IWshRuntimeLibrary;

namespace FourDScheduling
{
    public partial class MainMenu : Form
    {
        CreateSigmaFile createSigmaFile;

        private string[] files;
        private string[] ifcFiles;
        private string[] sigFiles;
        private string[] mppFiles;
        private string[] pathToDirectory;

        public MainMenu(string[] args)
        {
            InitializeComponent();

            projectDropDown.SelectedValueChanged += ProjectDropDown_SelectedValueChanged;
            
            btnIfcFilePath.Click += BtnIfcFilePath_Click;
            btnIfcFilePath1.Click += BtnIfcFilePath1_Click;

            btnSigmaFilePath.Click += BtnSigmaFilePath_Click;
            btnSigmaFilePath1.Click += BtnSigmaFilePath1_Click;

            btnMSProjectFilePath.Click += BtnMSProjectFilePath_Click;
            btnMSProjectFilePath1.Click += BtnMSProjectFilePath1_Click;

            btnCreateShortcut.Click += BtnCreateShortcut_Click;

            createSigmaFile = new CreateSigmaFile(this);
            BtnCreateMSProjectFile.Enabled = false;
            BtnUpdateFiles.Enabled = false;
            BtnIfcViewer.Enabled = false;

            pathToDirectory = AppDomain.CurrentDomain.SetupInformation.ActivationArguments?.ActivationData;

            //pathToDirectory = new string[] { "C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\07 - Prototype\\The Folder" };

            List<string> projectFiles = new List<string>();

            if (pathToDirectory != null)
            {
                if (Directory.Exists(pathToDirectory[0]))
                {
                    files = Directory.GetFiles(pathToDirectory[0]);
                    ifcFiles = files.Where(f => f.EndsWith(".ifc")).ToArray();
                    sigFiles = files.Where(f => f.EndsWith(".sig")).ToArray();
                    mppFiles = files.Where(f => f.EndsWith(".mpp")).ToArray();

                    projectFiles = ifcFiles.Select(Path.GetFileNameWithoutExtension).ToList();

                    projectFiles.Add("Custom");
                    projectDropDown.DataSource = projectFiles;
                    projectDropDown.SelectedIndex = 0;

                }
                else
                {
                    projectFiles.Add("Custom");
                    projectDropDown.DataSource = projectFiles;
                    projectDropDown.SelectedIndex = 0;
                }
            }
            else
            {
                projectFiles.Add("Custom");
                projectDropDown.DataSource = projectFiles;
                projectDropDown.SelectedIndex = 0;

            }
        }

        private void BtnCreateShortcut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveShortcutFile = new SaveFileDialog();
            saveShortcutFile.Filter = "Shortcut files (*.lnk)|*.lnk|All files (*.*)|*.*";
            saveShortcutFile.FilterIndex = 1;
            saveShortcutFile.RestoreDirectory = true;

            if (saveShortcutFile.ShowDialog() == DialogResult.OK)
            {
                string shortcutFileName = saveShortcutFile.FileName;

                string cmdPath = @"C:\Windows\System32\cmd.exe";
                string cmdArg = @"/k ""%APPDATA%\Microsoft\Windows\Start^ Menu\Programs\FourDScheduling\FourDScheduling.appref-ms ""%CD%"" & EXIT""";
                string shortcutPath = shortcutFileName;

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = cmdPath;
                shortcut.Arguments = cmdArg;
                shortcut.IconLocation = Directory.GetCurrentDirectory() + "\\Template\\Logo.ico";
                shortcut.Save();
            }
        }

        private void BtnMSProjectFilePath1_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose MS Project file", "Project files|*.mpp|All Files|*.*");

            if (filePath != null)
            {
                Globals.MSProjectFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.MSProjectFilePath) != Path.GetDirectoryName(Globals.IfcFilePath)
                    || Path.GetDirectoryName(Globals.MSProjectFilePath) != Path.GetDirectoryName(Globals.SigmaFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private void BtnMSProjectFilePath_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose MS Project file", "Project files|*.mpp|All Files|*.*");

            if (filePath != null)
            {
                Globals.MSProjectFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.MSProjectFilePath) != Path.GetDirectoryName(Globals.IfcFilePath)
                    || Path.GetDirectoryName(Globals.MSProjectFilePath) != Path.GetDirectoryName(Globals.SigmaFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private void BtnSigmaFilePath1_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose Sigma file", "Sigma files|*.sig|All Files|*.*");

            if (filePath != null)
            {
                Globals.SigmaFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.SigmaFilePath) != Path.GetDirectoryName(Globals.IfcFilePath)
                    || Path.GetDirectoryName(Globals.SigmaFilePath) != Path.GetDirectoryName(Globals.MSProjectFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private void BtnSigmaFilePath_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose Sigma file", "Sigma files|*.sig|All Files|*.*");

            if (filePath != null)
            {
                Globals.SigmaFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.SigmaFilePath) != Path.GetDirectoryName(Globals.IfcFilePath)
                    || Path.GetDirectoryName(Globals.SigmaFilePath) != Path.GetDirectoryName(Globals.MSProjectFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private void BtnIfcFilePath1_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose IFC file", "IFC files|*.ifc|All Files|*.*");

            if (filePath != null)
            {
                Globals.IfcFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.IfcFilePath) != Path.GetDirectoryName(Globals.SigmaFilePath)
                    || Path.GetDirectoryName(Globals.IfcFilePath) != Path.GetDirectoryName(Globals.MSProjectFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private void BtnIfcFilePath_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog("Choose IFC file", "IFC files|*.ifc|All Files|*.*");

            if (filePath != null)
            {
                Globals.IfcFilePath = filePath;
                updateAllBtnText();
                if (Path.GetDirectoryName(Globals.IfcFilePath) != Path.GetDirectoryName(Globals.SigmaFilePath) 
                    || Path.GetDirectoryName(Globals.IfcFilePath) != Path.GetDirectoryName(Globals.MSProjectFilePath))
                {
                    projectDropDown.SelectedIndex = projectDropDown.Items.Count - 1;
                }
            }
        }

        private bool stupid = false;
        private void ProjectDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!stupid)
            {
                string selectedValue = projectDropDown.SelectedItem.ToString();

                if (!selectedValue.IsEmpty() && selectedValue != "Custom")
                {
                    bool stupidBool = false;
                    foreach(string file in ifcFiles)
                    {
                        if (Path.GetFileNameWithoutExtension(file) == selectedValue)
                        {
                            Globals.IfcFilePath = file;
                            stupidBool = true;
                            break;
                        }
                    }
                    if (!stupidBool && Globals.IfcFilePath.IsEmpty())
                    {
                        Globals.IfcFilePath = ifcFiles[0];
                    }
                    stupidBool = false;

                    foreach (string file in sigFiles)
                    {
                        if (Path.GetFileNameWithoutExtension(file) == selectedValue)
                        {
                            Globals.SigmaFilePath = file;
                            stupidBool = true;
                            break;
                        }
                    }
                    if (!stupidBool && Globals.SigmaFilePath.IsEmpty())
                    {
                        Globals.SigmaFilePath = sigFiles[0];
                    }
                    stupidBool = false;

                    foreach (string file in mppFiles)
                    {
                        if (Path.GetFileNameWithoutExtension(file) == selectedValue)
                        {
                            Globals.MSProjectFilePath = file;
                            stupidBool = true;
                            break;
                        }
                    }
                    if (!stupidBool && Globals.MSProjectFilePath.IsEmpty())
                    {
                        Globals.MSProjectFilePath = mppFiles[0];
                    }
                    stupidBool = false;

                    updateAllBtnText();
                }
                else
                {
                    updateAllBtnText();
                }
            }
        }

        private string shortenString(string orginalString, int maxLength)
        {
            StringBuilder sb = new StringBuilder(orginalString);
            int stringLength = orginalString.Length;
            
            if (stringLength > maxLength)
            {
                int removeLength = stringLength - maxLength;
                int removeStart = maxLength / 4;
                sb.Remove(removeStart, removeLength);
                sb.Insert(removeStart, "...");
            }

            return sb.ToString();
        }

        private string openFileDialog(string title, string filter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                
                Multiselect = false,
                Filter = filter,
                Title = title
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        private void updateAllBtnText()
        {
            btnIfcFilePath.Text = shortenString(Globals.IfcFilePath, 38).IsEmpty()
                ? "Choose IFC" 
                : "IFC: " + shortenString(Globals.IfcFilePath, 38);

            btnSigmaFilePath.Text = shortenString(Globals.SigmaFilePath, 38).IsEmpty() 
                ? "Choose Sigma" 
                : "Sigma: " + shortenString(Globals.SigmaFilePath, 35);
            
            btnMSProjectFilePath.Text = shortenString(Globals.MSProjectFilePath, 38).IsEmpty() 
                ? "Choose MS Project" 
                : "MS Project: " + shortenString(Globals.MSProjectFilePath, 30);

        }

        private void CreateSigmaFile_Click(object sender, EventArgs e)
        {
            Hide();
            createSigmaFile.Show();
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
