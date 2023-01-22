using System;
using System.Windows.Forms;

namespace FourDScheduling
{
    public class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            //The Program
            Application.EnableVisualStyles();
            Application.Run(new MainMenu());
        }
    }
}
