using System;
using System.Windows.Forms;

namespace moonlight
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MOL_Main());
        }
    }
}