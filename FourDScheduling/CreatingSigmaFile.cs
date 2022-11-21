using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;

namespace FourDScheduling
{
    public partial class Test : Form
    {
        public Test()
        {
            
            InitializeComponent();
            this.listOfElements.CheckBoxes = true;
            listOfElements.Items.Add("Somethgin");
            listOfElements.Items[0].SubItems.Add("YOYO");

            identification.Items.Add("Type ID");
            identification.Items[0].SubItems.Add("Yo");




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIFCfile.Text = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";



            IfcStore ifcModel = IfcStore.Open(btnIFCfile.Text);



            var context = new Xbim3DModelContext(ifcModel);
            context.CreateContext();

            ifcViewer.Model = ifcModel;
            ifcViewer.LoadGeometry(ifcModel);
        }

        

        private void listView1_Click(object sender, EventArgs e)
        {

            //var dude = drawingControl3D1.SelectedEntity.ToString();

            string dude = "SupBro";

            identification.Items.Add("Type ID");
            identification.Items[0].SubItems[1].Text = dude;

            //listView2.Items[0].Remove();



        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "IFC files|*.ifc|All Files|*.*",
                Title = ""
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnIFCfile.Text = openFileDialog.FileName;

                IfcStore ifcModel = IfcStore.Open(btnIFCfile.Text);

                var context = new Xbim3DModelContext(ifcModel);
                context.CreateContext();

                ifcViewer.Model = ifcModel;
                ifcViewer.LoadGeometry(ifcModel);

            }

        }

        private void OpenDirectoryDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            if (btnDirectory.Text != string.Empty)
            {
                folderBrowserDialog.SelectedPath = btnDirectory.Text;
            }
            else
            {
                folderBrowserDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                btnDirectory.Text = folderBrowserDialog.SelectedPath;
            }


        }




        private void btnDirectory_Click(object sender, EventArgs e)
        {
            OpenDirectoryDialog();
        }

        private void btnDirectory2_Click(object sender, EventArgs e)
        {
            OpenDirectoryDialog();
        }

        private void btnIFCfile_Click(object sender, EventArgs e)
        {
            openFileDialog();
        }

        private void btnIFCfile2_Click(object sender, EventArgs e)
        {
            openFileDialog();
        }
    }
}
