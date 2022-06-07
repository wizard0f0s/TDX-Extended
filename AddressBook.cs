using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDX_Extended
{
    internal class AddressBook
    {
        public List<AddressEntry> addresses { get; set; }
        public int selection { get; set; }

        private Logger _myLogger;

        public AddressBook(Logger log)
        {
            _myLogger = log;
            addresses = new List<AddressEntry>();
            selection = 0;
        }
    }
}
