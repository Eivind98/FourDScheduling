using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Xbim.Ifc;
using Xbim.Ifc4.Interfaces;
using Xbim.ModelGeometry.Scene;

namespace FourDScheduling
{
    public partial class CreateSigmaFile : Form
    {

        public static List<IfcObjects> AllInstances { get; set; }
        public Form Parent { get; }

        public CreateSigmaFile(Form parent)
        {
            
            InitializeComponent();
            this.listOfElements.CheckBoxes = true;
            this.ifcViewer.MouseUp += IfcViewer_MouseUp;
            this.listOfElements.MouseUp += ListOfElements_MouseUp;
            this.FormClosed += OnFormClosed;
            Parent = parent;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnIFCfile.Text = "C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\99 - Andet\\Gantt Test\\Revit.ifc";
            btnIFCfile.Text = "Choose File Path";

            try
            {
                
                LoadingIFCGeometry(btnIFCfile.Text);

            }
            catch { }
            
        }

        private void ListOfElements_MouseUp(object sender, MouseEventArgs e)
        {
            identification.Items.Clear();
            quantities.Items.Clear();
            try
            {

                List<string> ids = new List<string>();

                foreach (ListViewItem item in listOfElements.SelectedItems)
                {
                    ids.Add(item.Name);
                }

                UpdateQuantitiesAndIdentification(ids);

            }
            catch
            {

            }
        }

        


        private void IfcViewer_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            quantities.Items.Clear();
            identification.Items.Clear();

            try
            {
                if (ifcViewer.SelectedEntity != null)
                {


                    var requiredProducts = IfcAPI.LoadProducts(ifcViewer.Selection);
                    

                    List<string> ids = new List<string>();
                    
                    foreach(var o in requiredProducts)
                    {
                        ids.Add(o.GlobalId);
                        
                    }

                    UpdateQuantitiesAndIdentification(ids);

                }

            }
            catch { }
        }




        private void UpdateQuantitiesAndIdentification(List<string> strings)
        {

            List<ListViewItem> listIdentification = new List<ListViewItem>();
            List<ListViewItem> listQuantities = new List<ListViewItem>();

            string uniqueID = "";
            string typeID = "";
            string family = "";
            string name = "";
            string IFCType = "";
            string material = "";

            string netArea = " m2";
            string grossArea = " m2";
            string areaOfOpenings = " m2";
            string length = " m";
            string thickness = " mm";
            string volume = " m3";
            string count = "";


            if (strings.Count <= 1)
            {
                IfcObjects element = AllInstances.FirstOrDefault(x => x.Id == strings[0]);


                uniqueID = element.Id;
                typeID = element.TypeId;
                family = element.FamilyName;
                name = element.Name;
                IFCType = "";
                material = "";

                netArea = netArea.Insert(0, Math.Round(element.NetArea, 3).ToString());
                grossArea = grossArea.Insert(0, Math.Round(element.GrossArea, 3).ToString());
                areaOfOpenings = areaOfOpenings.Insert(0, Math.Round(element.AreaOfOpenings, 3).ToString());
                length = length.Insert(0, Math.Round(element.Length, 3).ToString());
                thickness = thickness.Insert(0, Math.Round(element.Thickness, 3).ToString());
                volume = volume.Insert(0, Math.Round(element.Volume, 3).ToString());
                count = count.Insert(0, element.Count.ToString());

            }
            else
            {
                List<string> uniqueIDList = new List<string>();
                List<string> typeIDList = new List<string>();
                List<string> familyList = new List<string>();
                List<string> nameList = new List<string>();
                List<string> IFCTypeList = new List<string>();
                List<string> materialList = new List<string>();

                List<decimal> netAreaList = new List<decimal>();
                List<decimal> grossAreaList = new List<decimal>();
                List<decimal> areaOfOpeningsList = new List<decimal>();
                List<decimal> lengthList = new List<decimal>();
                List<decimal> thicknessList = new List<decimal>();
                List<decimal> volumeList = new List<decimal>();
                List<decimal> countList = new List<decimal>();


                foreach (var id in strings)
                {

                    foreach (var ele in AllInstances)
                    {

                        if (id == ele.Id)
                        {

                            uniqueIDList.Add(ele.Id);
                            typeIDList.Add(ele.TypeId);
                            familyList.Add(ele.FamilyName);
                            nameList.Add(ele.Name);

                            netAreaList.Add(ele.NetArea);
                            grossAreaList.Add(ele.GrossArea);
                            areaOfOpeningsList.Add(ele.AreaOfOpenings);
                            lengthList.Add(ele.Length);
                            thicknessList.Add(ele.Thickness);
                            volumeList.Add(ele.Volume);
                            countList.Add(ele.Count);

                            break;
                        }
                    }
                }

                uniqueID = string.Join(", ", uniqueIDList.ToArray());
                typeID = string.Join(", ", typeIDList.ToArray());
                family = string.Join(", ", familyList.ToArray());
                name = string.Join(", ", nameList.ToArray());
                IFCType = string.Join(", ", IFCTypeList.ToArray());
                material = string.Join(", ", materialList.ToArray());

                netArea = netArea.Insert(0, Math.Round(netAreaList.Sum(), 3).ToString());
                grossArea = grossArea.Insert(0, Math.Round(grossAreaList.Sum(), 3).ToString());
                areaOfOpenings = areaOfOpenings.Insert(0, Math.Round(areaOfOpeningsList.Sum(), 3).ToString());
                length = length.Insert(0, Math.Round(lengthList.Sum(), 3).ToString());
                thickness = thickness.Insert(0, Math.Round(thicknessList.Sum(), 3).ToString());
                volume = volume.Insert(0, Math.Round(volumeList.Sum(), 3).ToString());
                count = count.Insert(0, countList.Sum().ToString());

            }


            listIdentification.Add(AddItemWithSubItem("Unique ID", uniqueID));
            listIdentification.Add(AddItemWithSubItem("Type ID", typeID));
            listIdentification.Add(AddItemWithSubItem("Family", family));
            listIdentification.Add(AddItemWithSubItem("Name", name));
            listIdentification.Add(AddItemWithSubItem("IFC Type", IFCType));
            listIdentification.Add(AddItemWithSubItem("Material", material));

            listQuantities.Add(AddItemWithSubItem("Net Area", netArea));
            listQuantities.Add(AddItemWithSubItem("Gross Area", grossArea));
            listQuantities.Add(AddItemWithSubItem("Area of Openings", areaOfOpenings));
            listQuantities.Add(AddItemWithSubItem("Length", length));
            listQuantities.Add(AddItemWithSubItem("Thickness", thickness));
            listQuantities.Add(AddItemWithSubItem("Volume", volume));
            listQuantities.Add(AddItemWithSubItem("Count", count));


            identification.Items.AddRange(listIdentification.ToArray());
            quantities.Items.AddRange(listQuantities.ToArray());


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
                            Group = listOfElements.Groups[groupIndexer],
                            Checked = ifcObject.Chosen

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
            Parent.Show();


        }

        

        



    }
}
