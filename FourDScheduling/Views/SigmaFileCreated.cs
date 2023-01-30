using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourDScheduling
{
    public partial class SigmaFileCreated : Form
    {
        public Form Parent { get; }

        public static Form sigmaFileCreated;

        public SigmaFileCreated(Form parent)
        {
            InitializeComponent();

            BtnX.Click += BtnX_Click;
            BtnExit.Click += BtnExit_Click;
            BtnGoToMainMenu.Click += BtnGoToMainMenu_Click;
            BtnOpenDirectory.Click += BtnOpenDirectory_Click;

            sigmaFileCreated = this;
            Parent = parent;
        }

        private void BtnOpenDirectory_Click(object sender, EventArgs e)
        {
            
            string filePath = Globals.SigmaSavePath;
            if (!File.Exists(filePath))
            {
                return;
            }

            string argument = "/select, \"" + filePath + "\"";
            
            Process.Start("explorer.exe", argument);
        }

        private void BtnGoToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.mainM.Show();

        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
