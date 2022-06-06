using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace TDX_Extended
{
    internal class AddressEntry
    {

        public string friendlyName { get; set; } = "";
        public string serverAddress { get; set; } = "";
        public string environment { get; set; } = string.Empty;
        public string account { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public bool isWebServices { get; set; } = false;


        public AddressEntry()
        {

        }


    }
}
