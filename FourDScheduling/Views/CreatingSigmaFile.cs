using FourDScheduling.Models;
using FourDScheduling.Services;
using PropertyTools.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml;
using Xbim.Common;
using Xbim.Ifc;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.ModelGeometry.Scene;
using Xbim.Presentation;
using Xbim.Presentation.LayerStyling;
using static System.Windows.Forms.MonthCalendar;
using static Xbim.Presentation.DrawingControl3D;

namespace FourDScheduling
{
    public partial class CreateSigmaFile : Form
    {

        public List<IfcObjects> AllInstances { get; set; }
        public Form Parent { get; }

        public CreateSigmaFile(Form parent)
        {

            InitializeComponent();
            listOfElements.CheckBoxes = true;
            listOfElements.MouseUp += ListOfElements_MouseUp;
            listOfElements.MouseDown += ListOfElements_MouseDown;

            //quantities.MouseUp += quantities_MouseUp;
            quantities.CheckBoxes = true;
            //quantities.ItemChecked;
            quantities.MultiSelect = false;
            quantities.ItemCheck += quantities_ItemCheck;
            //quantities.ItemChecked += Quantities_ItemChecked;

            quantities.MouseDown += quantities_MouseDown;
            listOfElements.ItemSelectionChanged += listOfElements_ItemSelectionChanged;

            ifcViewer.MouseDown += IfcViewer_MouseDown;
            ifcViewer.MouseUp += IfcViewer_MouseUp;
            ifcViewer.SelectedEntityChanged += ifcViewer_SelectedEntityChanged;

            identification.ItemSelectionChanged += Identification_ItemSelectionChanged;

            FormClosed += OnFormClosed;
            Parent = parent;
        }

        private void Identification_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void IfcViewer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            listOfElements.Focus();
        }

        private void ListOfElements_MouseDown(object sender, MouseEventArgs e)
        {

            ifcViewer.SelectedEntity = null;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnIFCfile.Text = "C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\99 - Andet\\Gantt Test\\Revit.ifc";
            btnIFCfile.Text = "Choose File Path";
            btnDirectory.Text = "C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\07 - Prototype\\Gantt Test\\Testing";

            try
            {

                LoadingIFCGeometry(btnIFCfile.Text);

            }
            catch { }

            ifcViewer.ShowFps = true;
            

            listOfElements.HideSelection = false;

            List<ListViewItem> listIdentification = new List<ListViewItem>();
            List<ListViewItem> listQuantities = new List<ListViewItem>();

            listIdentification.Add(AddItemWithSubItem("Unique ID", ""));
            listIdentification.Add(AddItemWithSubItem("Type ID", ""));
            listIdentification.Add(AddItemWithSubItem("Family", ""));
            listIdentification.Add(AddItemWithSubItem("Name", ""));
            listIdentification.Add(AddItemWithSubItem("IFC Type", ""));
            listIdentification.Add(AddItemWithSubItem("Material", ""));

            listQuantities.Add(AddItemWithSubItem("Net Area", ""));
            listQuantities.Add(AddItemWithSubItem("Gross Area", ""));
            listQuantities.Add(AddItemWithSubItem("Area of Openings", ""));
            listQuantities.Add(AddItemWithSubItem("Length", ""));
            listQuantities.Add(AddItemWithSubItem("Thickness", ""));
            listQuantities.Add(AddItemWithSubItem("Volume", ""));
            listQuantities.Add(AddItemWithSubItem("Count", ""));

            identification.Items.AddRange(listIdentification.ToArray());
            quantities.Items.AddRange(listQuantities.ToArray());
        }

        private void ListOfElements_MouseUp(object sender, MouseEventArgs e)
        {
            
            
        }

        private void IfcViewer_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            //listOfElements.Focus();
        }

        private ListViewItem AddItemWithSubItem(string name, string value, bool check)
        {

            ListViewItem item = new ListViewItem()
            {
                Text = name
            };

            item.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = value
            });
            item.Checked = check;

            return item;
        }

        private ListViewItem AddItemWithSubItem(string name, string value)
        {

            return AddItemWithSubItem(name, value, false);
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

            foreach(IfcObjects obj in allInstances)
            {
                foreach (IIfcProduct p in ifcViewer.Model.Instances.OfType<IIfcProduct>())
                {
                    if (obj.Id == p.GlobalId)
                    {
                        obj.Product = p; 
                        break;
                    }
                }
            }


            int groupIndexer = 0;

            var groupedByName = allInstances
                .GroupBy(x => x.Name)
                .Select(g => new IfcObjects(g.ToList()));

            foreach (var group in groupedByName)
            {
                listOfElements.Groups.Add(new ListViewGroup(group.Name, System.Windows.Forms.HorizontalAlignment.Left));

                foreach (IfcObjects ifcObject in allInstances)
                {

                    if (ifcObject.Name == group.Name)
                    {
                        var newItem = new ListViewItem()
                        {
                            Text = ifcObject.Name + "+" + ifcObject.FamilyName,
                            Name = ifcObject.Id,
                            Group = listOfElements.Groups[groupIndexer],
                            Checked = ifcObject.Chosen

                        };

                        listOfElements.Items.Add(newItem);
                        ifcObject.Item = newItem;
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


        private void btnCreateSigmaFile_Click(object sender, EventArgs e)
        {
            if (btnDirectory.Text != "")
            {
                List<string> strings = new List<string>();
                List<SigTask> sigTask = new List<SigTask>();

                foreach (ListViewItem item in listOfElements.Items)
                {
                    if (item.Checked)
                    {
                        strings.Add(item.Name);
                        foreach (IfcObjects obj in AllInstances)
                        {

                            if (item.Name == obj.Id)
                            {
                                sigTask.Add(new SigTask(obj));

                            }
                        }
                    }
                }
                XmlDocument xmlDoc = new XmlDocument();

                string path = Directory.GetCurrentDirectory() + "\\Template\\Sigma Template.sig";

                xmlDoc.Load(path);

                SigAPI.AddSigmaComponent(xmlDoc, sigTask);


                using (XmlWriter writer = XmlWriter.Create(btnDirectory.Text + "\\IFC Export.sig", new XmlWriterSettings { Indent = true, IndentChars = "\t", NewLineOnAttributes = true }))
                {
                    xmlDoc.Save(writer);
                }

                Hide();
                Parent.Show();
            }

        }

        private bool isChecking;
        private bool canCheck = true;
        private void quantities_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!isChecking && canCheck)
            {
                isChecking = true;
                foreach (ListViewItem item in quantities.Items)
                {
                    if (item.Index != e.Index)
                    {
                        item.Checked = false;
                    }
                }
                e.NewValue = CheckState.Checked;
                canCheck = true;
                isChecking = false;

                foreach (ListViewItem selectedItem in listOfElements.SelectedItems)
                {
                    foreach (IfcObjects obj in AllInstances)
                    {
                        if (selectedItem.Name == obj.Id)
                        {
                            switch (e.Index)
                            {
                                case 0:
                                    obj.variable = obj.validVariables[0];
                                    break;
                                case 1:
                                    obj.variable = obj.validVariables[1];
                                    break;
                                case 2:
                                    obj.variable = obj.validVariables[2];
                                    break;
                                case 3:
                                    obj.variable = obj.validVariables[3];
                                    break;
                                case 4:
                                    obj.variable = obj.validVariables[4];
                                    break;
                                case 5:
                                    obj.variable = obj.validVariables[5];
                                    break;
                                case 6:
                                    obj.variable = obj.validVariables[6];
                                    break;
                                default: break;
                            }
                        }
                    }
                }

            }
            else
            {
                if (isChecking)
                {
                    e.NewValue = CheckState.Unchecked;
                }
                else
                {
                    e.NewValue = e.CurrentValue;
                }
            }

        }

        

        private void quantities_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var item = quantities.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    if (!item.Checked)
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void listOfElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        List<IfcObjects> SelectedObjects = new List<IfcObjects>();

        private bool updateRunning = false;
        private void UpdateItems()
        {
            updateRunning = true;
            if (SelectedObjects.Count != 0)
            {
                List<string> uniqueID = new List<string>();
                List<string> typeID = new List<string>();
                List<string> family = new List<string>();
                List<string> name = new List<string>();
                List<string> IFCType = new List<string>();
                List<string> material = new List<string>();

                List<decimal> netArea = new List<decimal>();
                List<decimal> grossArea = new List<decimal>();
                List<decimal> areaOfOpenings = new List<decimal>();
                List<decimal> length = new List<decimal>();
                List<decimal> thickness = new List<decimal>();
                List<decimal> volume = new List<decimal>();
                List<int> count = new List<int>();

                List<string> variableList = new List<string>();

                List<ListViewItem> itemList = new List<ListViewItem>();
                List<IIfcProduct> productList = new List<IIfcProduct>();

                foreach (IfcObjects obj in SelectedObjects)
                {
                    uniqueID.Add(obj.Id);
                    typeID.Add(obj.TypeId);
                    family.Add(obj.FamilyName);
                    name.Add(obj.Name);

                    netArea.Add(obj.NetArea);
                    grossArea.Add(obj.GrossArea);
                    areaOfOpenings.Add(obj.AreaOfOpenings);
                    length.Add(obj.Length);
                    thickness.Add(obj.Thickness);
                    volume.Add(obj.Volume);
                    count.Add(obj.Count);

                    variableList.Add(obj.variable);

                    itemList.Add(obj.Item);
                    productList.Add(obj.Product);

                }

                string variable = variableList[0];

                foreach (string var in variableList)
                {
                    if (variable != var)
                    {
                        variable = "";
                        break;
                    }
                }

                listOfElements.SelectedItems.Clear();
                ifcViewer.Selection.Clear();

                listRunning = true;
                ifcViewerRunning = true;

                foreach (ListViewItem item in itemList)
                {
                    item.Selected = true;
                }

                foreach (IIfcProduct product in productList)
                {
                    ifcViewer.SelectedEntity = product;
                }

                listRunning = false;
                ifcViewerRunning = false;

                identification.Items[0].SubItems[1].Text = string.Join(", ", uniqueID);
                identification.Items[1].SubItems[1].Text = string.Join(", ", typeID);
                identification.Items[2].SubItems[1].Text = string.Join(", ", family);
                identification.Items[3].SubItems[1].Text = string.Join(", ", name);
                identification.Items[4].SubItems[1].Text = string.Join(", ", IFCType);
                identification.Items[5].SubItems[1].Text = string.Join(", ", material);

                quantities.Items[0].SubItems[1].Text = Math.Round(netArea.Sum(), 3).ToString() + " " + Units.NetArea;
                quantities.Items[1].SubItems[1].Text = Math.Round(grossArea.Sum(), 3).ToString() + " " + Units.GrossArea;
                quantities.Items[2].SubItems[1].Text = Math.Round(areaOfOpenings.Sum(), 3).ToString() + " " + Units.AreaOfOpenings;
                quantities.Items[3].SubItems[1].Text = Math.Round(length.Sum(), 3).ToString() + " " + Units.Length;
                quantities.Items[4].SubItems[1].Text = Math.Round(thickness.Sum(), 3).ToString() + " " + Units.Thickness;
                quantities.Items[5].SubItems[1].Text = Math.Round(volume.Sum(), 3).ToString() + " " + Units.Volume;
                quantities.Items[6].SubItems[1].Text = count.Sum().ToString() + " " + Units.Count;

                IfcObjects valid = AllInstances[0];

                switch (variable)
                {
                    case var value when value == valid.validVariables[0]:
                        quantities.Items[0].Checked = true;
                        break;
                    case var value when value == valid.validVariables[1]:
                        quantities.Items[1].Checked = true;
                        break;
                    case var value when value == valid.validVariables[2]:
                        quantities.Items[2].Checked = true;
                        break;
                    case var value when value == valid.validVariables[3]:
                        quantities.Items[3].Checked = true;
                        break;
                    case var value when value == valid.validVariables[4]:
                        quantities.Items[4].Checked = true;
                        break;
                    case var value when value == valid.validVariables[5]:
                        quantities.Items[5].Checked = true;
                        break;
                    case var value when value == valid.validVariables[6]:
                        quantities.Items[6].Checked = true;
                        break;
                    default: break;
                }
            }
            else
            {
                listOfElements.SelectedItems.Clear();
                ifcViewer.Selection.Clear();

                identification.Items[0].SubItems[1].Text = "";
                identification.Items[1].SubItems[1].Text = "";
                identification.Items[2].SubItems[1].Text = "";
                identification.Items[3].SubItems[1].Text = "";
                identification.Items[4].SubItems[1].Text = "";
                identification.Items[5].SubItems[1].Text = "";

                quantities.Items[0].SubItems[1].Text = "";
                quantities.Items[1].SubItems[1].Text = "";
                quantities.Items[2].SubItems[1].Text = "";
                quantities.Items[3].SubItems[1].Text = "";
                quantities.Items[4].SubItems[1].Text = "";
                quantities.Items[5].SubItems[1].Text = "";
                quantities.Items[6].SubItems[1].Text = "";

            }
            updateRunning = false;
        }


        private bool listRunning = false;
        private void listOfElements_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var i = e.IsSelected;
            var b = e.Item.Text;
            
            if (e.IsSelected && !ifcViewerRunning && !updateRunning)
            {
                listRunning = true;
                var allProducts = ifcViewer.Model.Instances.OfType<IIfcProduct>();
                var selection = ifcViewer.SelectedEntity;
                ListViewItem selectedItem = e.Item;


                foreach (IfcObjects obj in AllInstances)
                {
                    if (e.Item.Name == obj.Id)
                    {
                        SelectedObjects.Add(obj);

                        break;
                    }
                }

                UpdateItems();

                //UpdateItemAdding(e.Item);

                listRunning = false;
            }
            else if(!e.IsSelected && !ifcViewerRunning && !updateRunning)
            {
                listRunning = true;
                //UpdateItemSubtracting(e.Item);
                foreach (IfcObjects obj in AllInstances)
                {
                    if (e.Item.Name == obj.Id)
                    {
                        SelectedObjects.Remove(obj);

                        break;
                    }
                }
                UpdateItems();
                listRunning = false;
            }
        }

        private bool stupidBool = false;
        private bool ifcViewerRunning = false;
        private void ifcViewer_SelectedEntityChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (!listRunning && AllInstances != null && !updateRunning && !stupidBool)
            {
                ifcViewerRunning = true;

                IIfcProduct pAdded = e.AddedItems.OfType<IIfcProduct>().FirstOrDefault();

                if (pAdded != null)
                {
                    foreach (IfcObjects obj in AllInstances)
                    {
                        if (pAdded.GlobalId == obj.Id)
                        {
                            SelectedObjects.Clear();
                            SelectedObjects.Add(obj);
                            break;
                        }
                    }

                    stupidBool = true;
                    ifcViewer.SelectedEntity = pAdded;
                    stupidBool = false;
                    UpdateItems();
                }
                else if (!stupidBool)
                {
                    SelectedObjects.Clear();
                    UpdateItems();
                }

                ifcViewerRunning = false;
            }
        }
    }
}
