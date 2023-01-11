using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourDScheduling
{
    public partial class MainMenu : Form
    {
        CreateSigmaFile createSigmaFile;

        public MainMenu()
        {
            InitializeComponent();

            createSigmaFile = new CreateSigmaFile(this);
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
    }
}
