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

namespace FourDScheduling
{
    public partial class Test : Form
    {
        public Test()
        {
            
            InitializeComponent();
            this.listView1.CheckBoxes = true;
            listView1.Items.Add("Somethgin");
            listView1.Items[0].SubItems.Add("YOYO");

            listView2.Items.Add("Type ID");
            listView2.Items[0].SubItems.Add("Yo");


            //string ifcPath = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";

            //using (var model = IfcStore.Open(ifcPath))
            //{

            //    drawingControl3D1.LoadGeometry(model);
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            
            listView1.Clear();
            //listView2.Items.AddlistView1.SelectedItems[0].Text();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

            listView2.Items.Add("Type ID");
            listView2.Items[0].SubItems[1].Text = "yobro";

            //listView2.Items[0].Remove();

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
