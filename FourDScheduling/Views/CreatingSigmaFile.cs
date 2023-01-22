using FourDScheduling.Models;
using FourDScheduling.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Xbim.Common;
using Xbim.Ifc;
using Xbim.Ifc4.Interfaces;
using Xbim.ModelGeometry.Scene;
using Xbim.Presentation;

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

            quantities.MouseUp += quantities_MouseUp;
            quantities.CheckBoxes = true;
            //quantities.ItemChecked;
            quantities.MultiSelect = false;
            //quantities.ItemCheck += quantities_ItemCheck;
            //quantities.ItemChecked += Quantities_ItemChecked;

            quantities.MouseDown += quantities_MouseDown;
            listOfElements.ItemSelectionChanged += listOfElements_ItemSelectionChanged;

            ifcViewer.MouseUp += IfcViewer_MouseUp;
            ifcViewer.SelectedEntityChanged += ifcViewer_SelectedEntityChanged;


            FormClosed += OnFormClosed;
            Parent = parent;
        }

        private void ListOfElements_MouseDown(object sender, MouseEventArgs e)
        {

            ifcViewer.SelectedEntity = null;
        }

        private void Quantities_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

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

                    foreach (var o in requiredProducts)
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

            string variable = "";

            bool netAreaCheck = false;
            bool grossAreaCheck = false;
            bool areaOfOpeningsCheck = false;
            bool lengthCheck = false;
            bool thicknessCheck = false;
            bool volumeCheck = false;
            bool countCheck = false;

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

            IfcObjects valid = new IfcObjects("valid");

            switch (variable)
            {
                case "Length":
                    lengthCheck = true;
                    break;
                case "Thickness":
                    thicknessCheck = true;
                    break;
                case "AreaOfOpenings":
                    areaOfOpeningsCheck = true;
                    break;
                case "NetArea":
                    netAreaCheck = true;
                    break;
                case "GrossArea":
                    grossAreaCheck = true;
                    break;
                case "Volume":
                    volumeCheck = true;
                    break;
                case "Count":
                    countCheck = true;
                    break;
                default: break;
            }




            listIdentification.Add(AddItemWithSubItem("Unique ID", uniqueID));
            listIdentification.Add(AddItemWithSubItem("Type ID", typeID));
            listIdentification.Add(AddItemWithSubItem("Family", family));
            listIdentification.Add(AddItemWithSubItem("Name", name));
            listIdentification.Add(AddItemWithSubItem("IFC Type", IFCType));
            listIdentification.Add(AddItemWithSubItem("Material", material));

            listQuantities.Add(AddItemWithSubItem("Net Area", netArea, netAreaCheck));
            listQuantities.Add(AddItemWithSubItem("Gross Area", grossArea, grossAreaCheck));
            listQuantities.Add(AddItemWithSubItem("Area of Openings", areaOfOpenings, areaOfOpeningsCheck));
            listQuantities.Add(AddItemWithSubItem("Length", length, lengthCheck));
            listQuantities.Add(AddItemWithSubItem("Thickness", thickness, thicknessCheck));
            listQuantities.Add(AddItemWithSubItem("Volume", volume, volumeCheck));
            listQuantities.Add(AddItemWithSubItem("Count", count, countCheck));


            identification.Items.AddRange(listIdentification.ToArray());
            quantities.Items.AddRange(listQuantities.ToArray());


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

        private void quantities_MouseUp(object sender, MouseEventArgs e)
        {

            //if (e.Button == MouseButtons.Left)
            //{
            //    var item = quantities.GetItemAt(e.X, e.Y);

            //    if (item != null)
            //    {
            //        if (!item.Checked)
            //        {
            //            item.Checked = true;
            //            for (int i = 0; i < quantities.Items.Count; i++)
            //            {
            //                if (i != item.Index)
            //                {
            //                    quantities.Items[i].Checked = false;
            //                }
            //            }
            //        }

            //        foreach (ListViewItem selectedItem in listOfElements.SelectedItems)
            //        {
            //            foreach (IfcObjects obj in AllInstances)
            //            {
            //                if (selectedItem.Name == obj.Id)
            //                {
            //                    switch (item.Text)
            //                    {
            //                        case "Net Area":
            //                            obj.variable = obj.validVariables[3];
            //                            break;
            //                        case "Gross Area":
            //                            obj.variable = obj.validVariables[4];
            //                            break;
            //                        case "Area of Openings":
            //                            obj.variable = obj.validVariables[2];
            //                            break;
            //                        case "Length":
            //                            obj.variable = obj.validVariables[0];
            //                            break;
            //                        case "Thickness":
            //                            obj.variable = obj.validVariables[1];
            //                            break;
            //                        case "Volume":
            //                            obj.variable = obj.validVariables[5];
            //                            break;
            //                        case "Count":
            //                            obj.variable = obj.validVariables[6];
            //                            break;
            //                        default: break;
            //                    }
            //                }


            //            }
            //        }

            //    }
            //}






            //int stuff = 0;
            //bool checking = false;

            //List<ListViewItem> some = new List<ListViewItem>();

            //foreach (ListViewItem item in quantities.Items)
            //{
            //    if(item.Checked == true)
            //    {
            //        some.Add(item);
            //        if (stuff == 1)
            //        {
            //            checking = true;
            //            break;
            //        }
            //        else
            //        {
            //            stuff++;
            //        }
            //    }
            //}

            //if (checking)
            //{
            //    List<IfcObjects> obj = new List<IfcObjects>();



            //    foreach (var id in some)
            //    {

            //        foreach (var ele in AllInstances)
            //        {

            //            if (id.Name == ele.Id)
            //            {
            //                ele.variable = id.Text;

            //                break;
            //            }
            //        }
            //    }



            //}



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

            //e.NewValue = CheckState.Unchecked;

            //if(e.NewValue != CheckState.Checked)
            //{
            //    e.NewValue = CheckState.Checked;
            //    quantities.Items[e.Index].Checked = true;
            //    //quantities.RedrawItems(e.Index, e.Index, false);
            //}
            //else if(e.NewValue == CheckState.Checked)
            //{
            //    foreach (ListViewItem item in quantities.CheckedItems)
            //    {
            //        if (item.Index != e.Index)
            //        {
            //            item.Checked = false;
            //            quantities.RedrawItems(item.Index, item.Index, true);
            //        }
            //    }
            //}

            //try
            //{
            //    foreach (ListViewItem item in quantities.Items)
            //    {
            //        item.Checked = false;
            //    }
            //}catch{ }



        }

        private void quantities_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    var item = quantities.GetItemAt(e.X, e.Y);
            //    if (item != null)
            //    {
            //        if (!item.Checked)
            //        {
            //            item.Checked = true;
            //            for (int i = 0; i < quantities.Items.Count; i++)
            //            {
            //                if (i != item.Index)
            //                {
            //                    quantities.Items[i].Checked = false;
            //                }
            //            }
            //        }

            //        foreach (ListViewItem selectedItem in listOfElements.SelectedItems)
            //        {
            //            foreach (IfcObjects obj in AllInstances)
            //            {
            //                if (selectedItem.Name == obj.Id)
            //                {
            //                    switch (item.Text)
            //                    {
            //                        case "Net Area":
            //                            obj.variable = obj.validVariables[3];
            //                            break;
            //                        case "Gross Area":
            //                            obj.variable = obj.validVariables[4];
            //                            break;
            //                        case "Area of Openings":
            //                            obj.variable = obj.validVariables[2];
            //                            break;
            //                        case "Length":
            //                            obj.variable = obj.validVariables[0];
            //                            break;
            //                        case "Thickness":
            //                            obj.variable = obj.validVariables[1];
            //                            break;
            //                        case "Volume":
            //                            obj.variable = obj.validVariables[5];
            //                            break;
            //                        case "Count":
            //                            obj.variable = obj.validVariables[6];
            //                            break;
            //                        default: break;
            //                    }
            //                }


            //            }
            //        }

            //    }
            //}
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
                        for (int i = 0; i < quantities.Items.Count; i++)
                        {
                            if (i != item.Index)
                            {
                                quantities.Items[i].Checked = false;
                            }
                        }

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
                    item.Checked = true;

                    


                }
            }
        }

        private void listOfElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listOfElements_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var allProducts = ifcViewer.Model.Instances.OfType<IIfcProduct>();
            var selection = ifcViewer.SelectedEntity;
            ListViewItem selectedItem = e.Item;

            if (selection == null)
            {
                foreach (var ifcItem in allProducts)
                {
                    
                    if (ifcItem.GlobalId == selectedItem.Name)
                    {
                        ifcViewer.SelectedEntity = ifcItem;

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
                        

                        ifcViewer.SelectedEntity = ifcItem;

                        break;
                    }
                }



            }


        }

        private void ifcViewer_SelectedEntityChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var test = e.AddedItems;


        }


    }
}
