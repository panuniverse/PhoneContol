using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace phoneControl
{
    public partial class Form1 : Form
    {
        private static string COMMOND_OPEN_WX = "adb.exe shell am start com.tencent.mm/com.tencent.mm.ui.LauncherUI ";
        //private static string COMMOND_OPEN_WX = "C:\adb\adb.exe";
        Process processOpenWX = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        public Form1()
        {
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "shell am start com.tencent.mm/com.tencent.mm.ui.LauncherUI";
            processOpenWX.StartInfo = startInfo;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            processOpenWX.Start();
        }
    }
}
