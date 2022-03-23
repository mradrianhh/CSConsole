using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void LaunchConsoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Launcher.LaunchProgram("CSConsole");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Unknown program identifier.");
            }
        }

        private void Title_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/mradrianhh/presto");
        }
    }
}
