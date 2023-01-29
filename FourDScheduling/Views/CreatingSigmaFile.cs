﻿using FourDScheduling.Models;
using FourDScheduling.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Xbim.Ifc;
using Xbim.Ifc.Extensions;
using Xbim.Ifc4.Interfaces;
using Xbim.IO.Xml.BsConf;
using Xbim.ModelGeometry.Scene;

namespace FourDScheduling
{
    public partial class CreateSigmaFile : Form
    {

        public List<IfcObjects> AllInstances { get; set; }

        public Form Parent { get; }

        SigmaFileCreated sigmaFileCreated;

        public CreateSigmaFile(Form parent)
        {
            InitializeComponent();
            sigmaFileCreated = new SigmaFileCreated(this);


            listOfElements.CheckBoxes = true;

            quantities.CheckBoxes = true;
            quantities.MultiSelect = false;
            quantities.ItemCheck += quantities_ItemCheck;

            quantities.MouseDown += quantities_MouseDown;
            listOfElements.ItemSelectionChanged += listOfElements_ItemSelectionChanged;

            ifcViewer.MouseDown += IfcViewer_MouseDown;
            ifcViewer.MouseUp += IfcViewer_MouseUp;
            ifcViewer.SelectedEntityChanged += ifcViewer_SelectedEntityChanged;

            FormClosed += OnFormClosed;
            Parent = parent;
        }

        bool tick = false;
        private void IfcViewer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            listOfElements.Focus();
            tick = true;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnIFCfile.Text = "C:\\Users\\eev_9\\OneDrive\\01 - Skúli\\05 - BLBI_Feb 2021 -\\Sem. 4\\99 - Andet\\Gantt Test\\Revit.ifc";
            btnIFCfile.Text = Helper.shortenString(Globals.IfcFilePath, 40);
            Globals.SigmaSavePath = Globals.IfcFilePath.IsEmpty() ? "" : Path.GetDirectoryName(Globals.IfcFilePath);
            btnDirectory.Text = Helper.shortenString(Globals.SigmaSavePath, 40);

            try
            {
                LoadingIFCGeometry(Globals.IfcFilePath);
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

        private void IfcViewer_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            listOfElements.Focus();
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
                Globals.IfcFilePath = openFileDialog.FileName;
                btnIFCfile.Text = Helper.shortenString(Globals.IfcFilePath, 40);

                LoadingIFCGeometry(Globals.IfcFilePath);
            }
        }

        private void OpenSaveFileDialog()
        {
            SaveFileDialog saveShortcutFile = new SaveFileDialog();
            saveShortcutFile.Filter = "Sigma files|*.sig|All files|*.*";
            saveShortcutFile.FilterIndex = 1;
            saveShortcutFile.InitialDirectory = Globals.SigmaSavePath.IsEmpty() ? "" : Globals.SigmaSavePath;
            saveShortcutFile.RestoreDirectory = true;

            if (saveShortcutFile.ShowDialog() == DialogResult.OK)
            {
                Globals.SigmaSavePath = saveShortcutFile.FileName;

                btnDirectory.Text = Helper.shortenString(Globals.SigmaSavePath, 40);
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            OpenSaveFileDialog();
        }

        private void btnDirectory2_Click(object sender, EventArgs e)
        {
            OpenSaveFileDialog();
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
            if (Globals.SigmaSavePath != "")
            {
                List<SigTask> sigTask = new List<SigTask>();
                List<IfcObjects> notGrouped = new List<IfcObjects>();

                foreach (ListViewItem item in listOfElements.Items)
                {
                    if (item.Checked)
                    {
                        foreach (IfcObjects obj in AllInstances)
                        {
                            if (item.Name == obj.Id)
                            {
                                notGrouped.Add(obj);
                            }
                        }
                    }
                }

                var grouped = notGrouped
                .GroupBy(x => x.Name)
                .Select(g => new IfcObjects(g.ToList()));

                foreach(IfcObjects obj in grouped)
                {
                    sigTask.Add(new SigTask(obj));
                }

                XmlDocument xmlDoc = new XmlDocument();

                string path = Directory.GetCurrentDirectory() + "\\Template\\Sigma Template.sig";

                xmlDoc.Load(path);

                SigAPI.AddSigmaComponent(xmlDoc, sigTask);

                if (!Path.HasExtension(Globals.SigmaSavePath))
                {
                    Globals.SigmaSavePath += @"\ÍFC Eksport.sig";
                }

                try
                {
                    using (XmlWriter writer = XmlWriter.Create(Globals.SigmaSavePath, new XmlWriterSettings { Indent = true, IndentChars = "\t", NewLineOnAttributes = true }))
                    {
                        xmlDoc.Save(writer);
                    }

                    Hide();
                    sigmaFileCreated.Show();
                }
                catch
                {
                    
                    ErrorMessage error = new ErrorMessage("File is open in another program");
                    error.ShowDialog();

                }
                
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
                                    obj.Variabel = obj.validVariables[0];
                                    break;
                                case 1:
                                    obj.Variabel = obj.validVariables[1];
                                    break;
                                case 2:
                                    obj.Variabel = obj.validVariables[2];
                                    break;
                                case 3:
                                    obj.Variabel = obj.validVariables[3];
                                    break;
                                case 4:
                                    obj.Variabel = obj.validVariables[4];
                                    break;
                                case 5:
                                    obj.Variabel = obj.validVariables[5];
                                    break;
                                case 6:
                                    obj.Variabel = obj.validVariables[6];
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
                List<string> ifcType = new List<string>();
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
                List<ListViewItem> itemInvertedList = new List<ListViewItem>();
                List<IIfcProduct> productList = new List<IIfcProduct>();

                foreach (IfcObjects obj in SelectedObjects)
                {
                    uniqueID.Add(obj.Id);
                    typeID.Add(obj.TypeId);
                    family.Add(obj.FamilyName);
                    name.Add(obj.Name);
                    ifcType.Add(obj.IfcType);
                    material.Add(obj.Material);

                    netArea.Add(obj.NetArea);
                    grossArea.Add(obj.GrossArea);
                    areaOfOpenings.Add(obj.AreaOfOpenings);
                    length.Add(obj.Length);
                    thickness.Add(obj.Thickness);
                    volume.Add(obj.Volume);
                    count.Add(obj.Count);

                    variableList.Add(obj.Variabel);

                    itemList.Add(obj.Item);
                    productList.Add(obj.Product);

                }

                foreach (IfcObjects obj in AllInstances)
                {
                    if (!SelectedObjects.Contains(obj))
                    {
                        itemInvertedList.Add(obj.Item);
                    }
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

                ifcViewerRunning = true;
                listRunning = true;
                
                foreach(ListViewItem item in itemList)
                {
                    if (!item.Selected)
                    {
                        item.Selected = true;
                    }
                }
                foreach (ListViewItem item in itemInvertedList)
                {
                    if (item.Selected)
                    {
                        item.Selected = false;
                    }
                }

                foreach (IIfcProduct product in productList)
                {
                    ifcViewer.SelectedEntity = product;
                }

                listRunning = false;
                ifcViewerRunning = false;

                identification.Items[0].SubItems[1].Text = string.Join(", ", uniqueID.Where(s => !string.IsNullOrEmpty(s)));
                identification.Items[1].SubItems[1].Text = string.Join(", ", typeID.Where(s => !string.IsNullOrEmpty(s)));
                identification.Items[2].SubItems[1].Text = string.Join(", ", family.Where(s => !string.IsNullOrEmpty(s)));
                identification.Items[3].SubItems[1].Text = string.Join(", ", name.Where(s => !string.IsNullOrEmpty(s)));
                identification.Items[4].SubItems[1].Text = string.Join(", ", ifcType.Where(s => !string.IsNullOrEmpty(s)));
                identification.Items[5].SubItems[1].Text = string.Join(", ", material.Where(s => !string.IsNullOrEmpty(s)));

                quantities.Items[0].SubItems[1].Text = Math.Round(netArea.Sum(), 3).ToString() + " " + Units.NetArea;
                quantities.Items[1].SubItems[1].Text = Math.Round(grossArea.Sum(), 3).ToString() + " " + Units.GrossArea;
                quantities.Items[2].SubItems[1].Text = Math.Round(areaOfOpenings.Sum(), 3).ToString() + " " + Units.AreaOfOpenings;
                quantities.Items[3].SubItems[1].Text = Math.Round(length.Sum(), 3).ToString() + " " + Units.Length;
                quantities.Items[4].SubItems[1].Text = Math.Round(thickness[0], 3).ToString() + " " + Units.Thickness;
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
                listRunning = false;
            }
            else if(!e.IsSelected && !ifcViewerRunning && !updateRunning)
            {
                listRunning = true;
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
                List<IIfcProduct> List = ifcViewer.Selection.OfType<IIfcProduct>().ToList();

                if (pAdded != null)
                {
                    foreach (IfcObjects obj in AllInstances)
                    {
                        if (pAdded.GlobalId == obj.Id)
                        {
                            if(List.Count <= 1)
                            {
                                SelectedObjects.Clear();
                            }
                            if (!SelectedObjects.Contains(obj))
                            {
                                SelectedObjects.Add(obj);
                            }
                            
                            break;
                        }
                    }

                    stupidBool = true;
                    ifcViewer.SelectedEntity = pAdded;
                    stupidBool = false;
                    
                    UpdateItems();
                    tick = false;
                }
                else if (tick && List.Count == 0)
                {
                    SelectedObjects.Clear();
                    UpdateItems();
                    tick = false;
                }
                else
                {
                    IfcObjects i = null;
                    foreach (IfcObjects obj in SelectedObjects)
                    {
                        foreach (IIfcProduct pr in List)
                        {
                            if(obj.Id != pr.GlobalId)
                            {
                                i = obj;
                                
                                break;
                            }
                        }
                    }

                    if (i != null)
                    {
                        SelectedObjects.Remove(i);
                        UpdateItems();
                    }
                }
                ifcViewerRunning = false;
            }
        }
    }
}
