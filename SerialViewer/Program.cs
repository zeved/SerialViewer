using System;
using System.Threading;
using System.Windows.Forms;

namespace SerialViewer
{
    static class Program
    {
        public static MainForm mainForm;
        public static Serial serial;
        

        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            serial = new Serial();
            Application.Run(mainForm);
        }
    }
}
