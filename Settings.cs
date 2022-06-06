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
    internal class Settings
    {

        public string selectedFriendlyName { get; set; } = string.Empty;
        public string selectedServer { get; set; } = string.Empty;
        public string selectedAccount { get; set; } = string.Empty;
        public string selectedPassword { get; set; } = string.Empty;
        public string selectedEnvironment { get; set; } = string.Empty;
        public bool selectedIsWebServices { get; set; } = false;

        private string secretsID = "48024d93-9b5e-40b8-99a1-e75d6cf33c61";
        public int selection = 0;
        public AddressBook addressBook = new AddressBook();


        public Settings()
        {
            populateAddressBook();
            selection = addressBook.selection;
            if (addressBook.addresses != null)
            {
                selectedFriendlyName = addressBook.addresses[selection].friendlyName;
                selectedServer = addressBook.addresses[selection].serverAddress;
                selectedAccount = addressBook.addresses[selection].account;
                selectedPassword = addressBook.addresses[selection].password;
                selectedEnvironment = addressBook.addresses[selection].environment;
                selectedIsWebServices = addressBook.addresses[selection].isWebServices;
            }

        }

        private void populateAddressBook()
        {
            var secretsPath = Microsoft.Extensions.Configuration.UserSecrets.PathHelper.GetSecretsPathFromSecretsId(secretsID);
            if (File.Exists(secretsPath))
            {
                var secretsJson = File.ReadAllText(secretsPath);
                //dynamic secrets = JsonConvert.DeserializeObject<ExpandoObject>(secretsJson, new ExpandoObjectConverter());
                addressBook = JsonConvert.DeserializeObject<AddressBook>(secretsJson);
            }
        }

        public void saveAddressBook()
        {
            var secretsPath = Microsoft.Extensions.Configuration.UserSecrets.PathHelper.GetSecretsPathFromSecretsId(secretsID);

            var updatedSecretsJson = JsonConvert.SerializeObject(addressBook, Formatting.Indented);
            if (!Directory.Exists(Path.GetDirectoryName(secretsPath)))
            {
                Directory.CreateDirectory(secretsPath);
            }
            File.WriteAllText(secretsPath, updatedSecretsJson);
        }

    }
}
