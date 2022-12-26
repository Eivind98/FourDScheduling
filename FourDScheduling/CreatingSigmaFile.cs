using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;

namespace FourDScheduling
{
    public partial class CreateSigmaFile : Form
    {

        public static List<IfcObjects> AllInstances { get; set; }



        public CreateSigmaFile()
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


            try
            {
                
                LoadingIFCGeometry(btnIFCfile.Text);

            }
            catch { }
            

        }

        

        private void listView1_Click(object sender, EventArgs e)
        {
            identification.Items.Clear();
            quantities.Items.Clear();
            try
            {

                List<ListViewItem> listIdentification = new List<ListViewItem>();
                List<ListViewItem> listQuantities = new List<ListViewItem>();

                if (listOfElements.SelectedItems.Count <= 1)
                {
                    IfcObjects element = null;

                    foreach (var ele in AllInstances)
                    {

                        if (listOfElements.SelectedItems[0].Name == ele.Id)
                        {
                            element = ele;
                        }
                    }

                    listIdentification.Add(AddItemWithSubItem("Unique ID", element.Id));
                    listIdentification.Add(AddItemWithSubItem("Type ID", element.TypeId));
                    listIdentification.Add(AddItemWithSubItem("Family", element.FamilyName));
                    listIdentification.Add(AddItemWithSubItem("Name", element.Name));
                    listIdentification.Add(AddItemWithSubItem("IFC Type", element.Name));
                    listIdentification.Add(AddItemWithSubItem("Material", element.Name));


                    listQuantities.Add(AddItemWithSubItem("Net Area", element.NetArea.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Gross Area", element.GrossArea.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Area of Openings", element.NetArea.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Length", element.Length.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Thickness", element.Length.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Volume", element.Volume.ToString()));
                    listQuantities.Add(AddItemWithSubItem("Count", element.Count.ToString()));


                }
                else
                {

                }


                identification.Items.AddRange(listIdentification.ToArray());
                quantities.Items.AddRange(listQuantities.ToArray());


                var selectedElement = listOfElements.SelectedItems[0];
                var selectedElements = listOfElements.SelectedItems;



            }
            catch
            {
                
            }
            
        }

        private ListViewItem AddItemWithSubItem(string name, string value)
        {

            ListViewItem item = new ListViewItem()
            {
                Text = name
            };

            item.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = value
            });

            return item;
        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadingIFCGeometry(string ifcPath)
        {
            IfcStore ifcModel = IfcStore.Open(ifcPath);

            var context = new Xbim3DModelContext(ifcModel);
            context.CreateContext();

            ifcViewer.Model = ifcModel;
            ifcViewer.LoadGeometry(ifcModel);

            listOfElements.Groups.Clear();
            listOfElements.Items.Clear();

            AllInstances = IfcAPI.LoadIfcObjects(ifcPath);
            List<IfcObjects> allInstances = AllInstances;

            int groupIndexer = 0;

            var groupedByName = allInstances
                .GroupBy(x => x.Name)
                .Select(g => new IfcObjects(g.ToList()));

            foreach (var group in groupedByName)
            {

                listOfElements.Groups.Add(new ListViewGroup(group.Name, HorizontalAlignment.Left));

                foreach (IfcObjects ifcObject in allInstances)
                {

                    if (ifcObject.Name == group.Name)
                    {
                        listOfElements.Items.Add(new ListViewItem()
                        {
                            Text = ifcObject.Name + "+" + ifcObject.FamilyName,
                            Name = ifcObject.Id,
                            Group = listOfElements.Groups[groupIndexer]

                        });

                    }
                }

                groupIndexer = groupIndexer + 1;
            }

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

                LoadingIFCGeometry(btnIFCfile.Text);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();

            


        }
    }
}
