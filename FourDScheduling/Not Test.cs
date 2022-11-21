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
            this.listView1.CheckBoxes = true;
            listView1.Items.Add("Somethgin");
            listView1.Items[0].SubItems.Add("YOYO");

            listView2.Items.Add("Type ID");
            listView2.Items[0].SubItems.Add("Yo");


            //string ifcPath = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";

            //IfcStore ifcModel = IfcStore.Open(ifcPath);

            

            //var context = new Xbim3DModelContext(ifcModel);
            //context.CreateContext();

            //drawingControl3D1.Model = ifcModel;
            //drawingControl3D1.LoadGeometry(ifcModel);


            //using (var model = IfcStore.Open(ifcPath))
            //{
            //    drawingControl3D1.Model = ifcModel;
            //    drawingControl3D1.LoadGeometry(model);
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ifcPath = "D:\\Gantt Test\\HavL3_K01_N001_ARK.ifc";

            IfcStore ifcModel = IfcStore.Open(ifcPath);



            var context = new Xbim3DModelContext(ifcModel);
            context.CreateContext();

            drawingControl3D1.Model = ifcModel;
            drawingControl3D1.LoadGeometry(ifcModel);
        }

        

        private void listView1_Click(object sender, EventArgs e)
        {

            //var dude = drawingControl3D1.SelectedEntity.ToString();

            string dude = "SupBro";

            listView2.Items.Add("Type ID");
            listView2.Items[0].SubItems[1].Text = dude;

            //listView2.Items[0].Remove();



        }

        

        
    }
}
