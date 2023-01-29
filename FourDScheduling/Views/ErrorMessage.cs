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
    public partial class ErrorMessage : Form
    {
        public static Form instance;


        public ErrorMessage(string Text)
        {
            InitializeComponent();

            LblText.Text = Text;
            


            instance = this;

            BtnClose.Click += BtnClose_Click;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
