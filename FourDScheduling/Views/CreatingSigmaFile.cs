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

        public static List<IfcObjects> AllInstances { get; set; }
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
            


            FormClosed += OnFormClosed;
            Parent = parent;
        }

        private void IfcViewer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
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
            ifcViewer.SelectionBehaviour = SelectionBehaviours.MultipleSelection;

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
            try
            {
                if (ifcViewer.SelectedEntity != null)
                {
                    var requiredProducts = IfcAPI.LoadProducts(ifcViewer.Selection);

                    List<string> ids = new List<string>();

                    foreach (var o in requiredProducts)
                    {
                        ids.Add(o.GlobalId);

                    }

                    UpdateQuantitiesAndIdentification(ids);
                }

            }
            catch { }

            listOfElements.Focus();
        }

        private void UpdateQuantitiesAndIdentification(List<string> strings)
        {

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

            string variable = "";


            if (strings.Count <= 1)
            {
                IfcObjects element = AllInstances.FirstOrDefault(x => x.Id == strings[0]);

                uniqueID = element.Id;
                typeID = element.TypeId;
                family = element.FamilyName;
                name = element.Name;
                IFCType = "";
                material = "";

                netArea = Math.Round(element.NetArea, 3).ToString() + " " + Units.NetArea;
                grossArea = Math.Round(element.GrossArea, 3).ToString() + " " + Units.GrossArea;
                areaOfOpenings = Math.Round(element.AreaOfOpenings, 3).ToString() + " " + Units.AreaOfOpenings;
                length = Math.Round(element.Length, 3).ToString() + " " + Units.Length;
                thickness = Math.Round(element.Thickness, 3).ToString() + " " + Units.Thickness;
                volume = Math.Round(element.Volume, 3).ToString() + " " + Units.Volume;
                count = element.Count.ToString() + " " + Units.Count;

                variable = element.variable;
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

                List<string> variableList = new List<string>();

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

                            variableList.Add(ele.variable);

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

                variable = variableList[0];

                foreach (string var in variableList)
                {
                    if (variable != var)
                    {
                        variable = "";
                        break;
                    }
                }
            }

            identification.Items[0].SubItems[1].Text = uniqueID;
            identification.Items[1].SubItems[1].Text = typeID;
            identification.Items[2].SubItems[1].Text = family;
            identification.Items[3].SubItems[1].Text = name;
            identification.Items[4].SubItems[1].Text = IFCType;
            identification.Items[5].SubItems[1].Text = material;

            quantities.Items[0].SubItems[1].Text = netArea;
            quantities.Items[1].SubItems[1].Text = grossArea;
            quantities.Items[2].SubItems[1].Text = areaOfOpenings;
            quantities.Items[3].SubItems[1].Text = length;
            quantities.Items[4].SubItems[1].Text = thickness;
            quantities.Items[5].SubItems[1].Text = volume;
            quantities.Items[6].SubItems[1].Text = count;

            IfcObjects valid = new IfcObjects("valid");

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

        private void changeChecked(ListViewItem item)
        {
            
            if(item != null && item.Checked == false)
            {
                ListView list = item.ListView;
                foreach(ListViewItem i in list.Items)
                {
                    if(i.Checked == true)
                    {
                        i.Checked = false;
                    }


                }
                item.Checked = true;

                foreach (ListViewItem selectedItem in listOfElements.SelectedItems)
                {
                    foreach (IfcObjects obj in AllInstances)
                    {
                        if (selectedItem.Name == obj.Id)
                        {
                            switch (item.Text)
                            {
                                case "Net Area":
                                    obj.variable = obj.validVariables[3];
                                    break;
                                case "Gross Area":
                                    obj.variable = obj.validVariables[4];
                                    break;
                                case "Area of Openings":
                                    obj.variable = obj.validVariables[2];
                                    break;
                                case "Length":
                                    obj.variable = obj.validVariables[0];
                                    break;
                                case "Thickness":
                                    obj.variable = obj.validVariables[1];
                                    break;
                                case "Volume":
                                    obj.variable = obj.validVariables[5];
                                    break;
                                case "Count":
                                    obj.variable = obj.validVariables[6];
                                    break;
                                default: break;
                            }
                        }


                    }
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


        private bool listRunning = false;
        private void listOfElements_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            if (e.IsSelected && !ifcViewerRunning)
            {
                listRunning = true;
                var allProducts = ifcViewer.Model.Instances.OfType<IIfcProduct>();
                var selection = ifcViewer.SelectedEntity;
                ListViewItem selectedItem = e.Item;

                if (selection == null)
                {
                    foreach (var ifcItem in allProducts)
                    {

                        if (ifcItem.GlobalId == selectedItem.Name)
                        {
                            ifcViewer.SelectedEntity =  ifcItem;
                            break;
                        }
                    }
                }
                else
                {
                    var productSelection = selection.Model.Instances.OfType<IIfcProduct>();

                    foreach (var ifcItem in allProducts)
                    {

                        if (ifcItem.GlobalId == selectedItem.Name)
                        {


                            

                            break;
                        }
                    }
                }

                //UpdateItemAdding(e.Item);

                listRunning = false;
            }
            else if(!e.IsSelected && !ifcViewerRunning)
            {
                //UpdateItemSubtracting(e.Item);
            }


        }


        private bool ifcViewerRunning = false;
        private void ifcViewer_SelectedEntityChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            if (!listRunning)
            {
                ifcViewerRunning = true;

                var fullSelection = ifcViewer.Selection.OfType<IIfcProduct>().ToList();

                if (fullSelection.Count != 0)
                {
                    

                    var aItem = e.AddedItems.OfType<IIfcProduct>();

                    var items = listOfElements.Items;

                    listOfElements.SelectedItems.Clear();


                    foreach (IIfcProduct a in fullSelection)
                    {
                        foreach (ListViewItem item in items)
                        {
                            if (a.GlobalId == item.Name)
                            {
                                item.Selected = true;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    listOfElements.SelectedItems.Clear();
                }

                ifcViewerRunning = false;
            }
            
        }

        private List<string> uniqueID = new List<string>();
        private List<string> typeID = new List<string>();
        private List<string> family = new List<string>();
        private List<string> nameObj = new List<string>();
        private List<string> IFCType = new List<string>();
        private List<string> material = new List<string>();

        private decimal netArea = 0;
        private decimal grossArea = 0;
        private decimal areaOfOpenings = 0;
        private decimal length = 0;
        private decimal thickness = 0;
        private decimal volume = 0;
        private decimal count = 0;
        private void UpdateItemAdding(ListViewItem item)
        {
            string variable = "";

            foreach(IfcObjects obj in AllInstances)
            {
                if(obj.Id == item.Name)
                {
                    if(obj.Id.Length != 0)
                    {
                        uniqueID.Add(obj.Id);
                    }

                    if (obj.TypeId.Length != 0)
                    {
                        typeID.Add(obj.TypeId);
                    }

                    if (obj.FamilyName.Length != 0)
                    {
                        family.Add(obj.FamilyName);
                    }

                    if (obj.Name.Length != 0)
                    {
                        nameObj.Add(obj.Name);
                    }

                    netArea += (obj.NetArea == 0 ? 0 : obj.NetArea);
                    grossArea += (obj.GrossArea == 0 ? 0 : obj.GrossArea);
                    areaOfOpenings += (obj.AreaOfOpenings == 0 ? 0 : obj.AreaOfOpenings);
                    length += (obj.Length == 0 ? 0 : obj.Length);
                    thickness += (obj.Thickness == 0 ? 0 : obj.Thickness);
                    volume += (obj.Volume == 0 ? 0 : obj.Volume);
                    count += (obj.Count == 0 ? 0 : obj.Count);

                    identification.Items[0].SubItems[1].Text = string.Join(", ",uniqueID);
                    identification.Items[1].SubItems[1].Text = string.Join(", ", typeID);
                    identification.Items[2].SubItems[1].Text = string.Join(", ", family);
                    identification.Items[3].SubItems[1].Text = string.Join(", ", nameObj);
                    identification.Items[4].SubItems[1].Text = string.Join(", ", IFCType);
                    identification.Items[5].SubItems[1].Text = string.Join(", ", material);

                    quantities.Items[0].SubItems[1].Text = Math.Round(netArea, 3).ToString() + " " + Units.NetArea;
                    quantities.Items[1].SubItems[1].Text = Math.Round(grossArea, 3).ToString() + " " + Units.GrossArea;
                    quantities.Items[2].SubItems[1].Text = Math.Round(areaOfOpenings, 3).ToString() + " " + Units.AreaOfOpenings;
                    quantities.Items[3].SubItems[1].Text = Math.Round(length, 3).ToString() + " " + Units.Length;
                    quantities.Items[4].SubItems[1].Text = Math.Round(thickness, 3).ToString() + " " + Units.Thickness;
                    quantities.Items[5].SubItems[1].Text = Math.Round(volume, 3).ToString() + " " + Units.Volume;
                    quantities.Items[6].SubItems[1].Text = Math.Round(count, 3).ToString() + " " + Units.Count;

                    IfcObjects valid = new IfcObjects("valid");

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
                    break;
                }
            }
        }


        private void UpdateItemSubtracting(ListViewItem item)
        {
            string variable = "";

            foreach (IfcObjects obj in AllInstances)
            {
                if (obj.Id == item.Name)
                {

                    if (obj.Id.Length != 0)
                    {
                        uniqueID.Remove(obj.Id);
                    }

                    if (obj.TypeId.Length != 0)
                    {
                        typeID.Remove(obj.TypeId);
                    }

                    if (obj.FamilyName.Length != 0)
                    {
                        family.Remove(obj.FamilyName);
                    }

                    if (obj.Name.Length != 0)
                    {
                        nameObj.Remove(obj.Name);
                    }


                    netArea -= (obj.NetArea == 0 ? 0 : obj.NetArea);
                    grossArea -= (obj.GrossArea == 0 ? 0 : obj.GrossArea);
                    areaOfOpenings -= (obj.AreaOfOpenings == 0 ? 0 : obj.AreaOfOpenings);
                    length -= (obj.Length == 0 ? 0 : obj.Length);
                    thickness -= (obj.Thickness == 0 ? 0 : obj.Thickness);
                    volume -= (obj.Volume == 0 ? 0 : obj.Volume);
                    count -= (obj.Count == 0 ? 0 : obj.Count);




                    
                    identification.Items[0].SubItems[1].Text = string.Join(", ", uniqueID);
                    identification.Items[1].SubItems[1].Text = string.Join(", ", typeID);
                    identification.Items[2].SubItems[1].Text = string.Join(", ", family);
                    identification.Items[3].SubItems[1].Text = string.Join(", ", nameObj);
                    identification.Items[4].SubItems[1].Text = "";
                    identification.Items[5].SubItems[1].Text = "";

                    quantities.Items[0].SubItems[1].Text = Math.Round(netArea, 3).ToString() + " " + Units.NetArea;
                    quantities.Items[1].SubItems[1].Text = Math.Round(grossArea, 3).ToString() + " " + Units.GrossArea;
                    quantities.Items[2].SubItems[1].Text = Math.Round(areaOfOpenings, 3).ToString() + " " + Units.AreaOfOpenings;
                    quantities.Items[3].SubItems[1].Text = Math.Round(length, 3).ToString() + " " + Units.Length;
                    quantities.Items[4].SubItems[1].Text = Math.Round(thickness, 3).ToString() + " " + Units.Thickness;
                    quantities.Items[5].SubItems[1].Text = Math.Round(volume, 3).ToString() + " " + Units.Volume;
                    quantities.Items[6].SubItems[1].Text = Math.Round(count, 3).ToString() + " " + Units.Count;

                    switch (variable)
                    {
                        case var value when value == obj.validVariables[0]:
                            quantities.Items[0].Checked = true;
                            break;
                        case var value when value == obj.validVariables[1]:
                            quantities.Items[1].Checked = true;
                            break;
                        case var value when value == obj.validVariables[2]:
                            quantities.Items[2].Checked = true;
                            break;
                        case var value when value == obj.validVariables[3]:
                            quantities.Items[3].Checked = true;
                            break;
                        case var value when value == obj.validVariables[4]:
                            quantities.Items[4].Checked = true;
                            break;
                        case var value when value == obj.validVariables[5]:
                            quantities.Items[5].Checked = true;
                            break;
                        case var value when value == obj.validVariables[6]:
                            quantities.Items[6].Checked = true;
                            break;
                        default: break;
                    }
                    break;
                }
            }
        }


        private string RemoveStringWithATwist(string original, string removing)
        {
            int indexer = original.IndexOf(removing);

            if (indexer == 0)
            {
                return original.Remove(indexer, removing.Length + 2);
            }
            else if (original.Length - removing.Length -1 == indexer)
            {
                return original.Remove(indexer - 2);
            }
            else
            {
                return original.Remove(indexer, removing.Length);
            }


        }

    }

}
