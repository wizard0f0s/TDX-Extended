using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDX_Extended
{
    internal class Logger
    {

        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private string debug_file = "TDX_Extender.log";


        public Logger()
        {
            _path = AppDomain.CurrentDomain.BaseDirectory;
        }

        public Logger(string path)
            : this()
        {
            _path = path;
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
        }

        public void Console(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Debug(string message)
        {
            File.AppendAllText(_path + "\\" + debug_file, message);
        }
    }
}
