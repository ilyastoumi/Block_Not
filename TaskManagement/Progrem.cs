using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    internal class Progrem
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // هنا يتم تشغيل النافذة الرئيسية التي صممتها
            Application.Run(new Form1());
        }
    }
}
