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

        public AddressBook()
        {
            addresses = new List<AddressEntry>();
            selection = 0;
        }
    }
}
