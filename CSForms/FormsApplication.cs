using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSForms.Internal.Programs;

namespace CSForms
{
    static class FormsApplication
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program program = ProgramBuilder.CreateProgram("CSConsole");
            program.SetFullPath(Launcher.FindTargetExecutable("CSConsoleApp.exe"));
            Launcher.AddProgram(program);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
