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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CreateSigmaFile_Click(object sender, EventArgs e)
        {
            Hide();
            CreateSigmaFile createSigmaFile = new CreateSigmaFile();
            
            createSigmaFile.ShowDialog();
            
            

        }
    }
}
