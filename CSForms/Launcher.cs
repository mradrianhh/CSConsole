using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSForms.Internal.Programs;

namespace CSForms
{
    internal static class Launcher
    {
        public static Dictionary<string, Program> Programs { get; set; } = new Dictionary<string, Program>();

        public static void LaunchProgram(string identifier)
        {
            Programs[identifier].Launch();
        }

        public static void AddProgram(Program program)
        {
            Programs[program.Identifier] = program;
        }

        public static string FindTargetExecutable(string exe)
        {
            DirectoryInfo ParentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
            return TraverseDirectory(ParentDirectory, exe);
        }

        private static string TraverseDirectory(DirectoryInfo directoryInfo, string exe)
        {
            var dirs = directoryInfo.GetDirectories().Where(dir => dir.Name[0] != '.');
            foreach (var directory in dirs)
            {
                foreach (var file in directory.GetFiles())
                {
                    if (file.Name == exe)
                    {
                        return file.FullName;
                    }
                }
                return TraverseDirectory(directory, exe);
            }

            throw new ArgumentException($"Can't find file {exe}");
        }
    }
}
