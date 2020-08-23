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

namespace Windows10sucks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ovlpan_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\control.exe");
        }
     
        private void vlastnosti_Click_1(object sender, EventArgs e)
        {
            Process.Start("vlastnosti.bat");

        }

        private void button3_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\appwiz.cpl");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\sysdm.cpl");
        }

        private void button5_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\mmsys.cpl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\ncpa.cpl");
        }

       
        private void button12_Click(object sender, EventArgs e)
        {
              Process.Start("tiskarny.bat");
        }

        private void button10_Click(object sender, EventArgs e)
        {
              Process.Start("backup.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
              Process.Start("tskmgr.bat");
        }

        private void button11_Click(object sender, EventArgs e)
        {
              Process.Start("hesla.bat");
        }

        private void button7_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\mstsc.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
             Process.Start("ChromeSetup.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\netplwiz.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Process.Start("C:\\Windows\\System32\\regedit.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
             Process.Start("firewall.bat");          
        }
    }
}
