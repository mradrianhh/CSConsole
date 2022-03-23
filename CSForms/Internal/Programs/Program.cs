using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSForms.Internal.Programs
{
    internal class Program
    {
        private readonly string _identifier;
        public string Identifier { get => _identifier; }

        public string FullPath { get; set; }

        private string _args = string.Empty;
        public string Args
        {
            get
            {
                _args.TrimStart(' ');
                _args.TrimEnd(' ');
                return _args;
            }
            set => _args = value;
        }

        public Program(string identifier)
        {
            _identifier = identifier;
        }

        public bool Launch()
        {
            Process process = new Process();
            process.StartInfo.Arguments = Args;
            process.StartInfo.FileName = FullPath;
            return process.Start();
        }
    }

    internal static class ProgramBuilder
    {
        public static Program CreateProgram(string identifier)
        {
            return new Program(identifier);
        }

        public static Program SetFullPath(this Program program, string fullPath)
        {
            program.FullPath = fullPath;
            return program;
        }

        public static Program AddArgument(this Program program, string argument)
        {
            program.Args += argument + " ";
            return program;
        }

        public static Program AddArguments(this Program program, string[] arguments)
        {
            foreach (var argument in arguments)
                program.Args += argument + " ";

            return program;
        }
    }
}
