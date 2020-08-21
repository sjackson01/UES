using System.IO;
using Newtonsoft.Json;

namespace UES
{
    class DataSource
    {
        private string _uri;
        private string _userName;
        private string _boomiPassword;

        public string Uri
        {
            get { return _uri; }
            set { _uri = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string BoomiPassword
        {
            get { return _boomiPassword; }
            set { _boomiPassword = value; }
        }

        // Obtain URI from Config.json 
        public string GetUri()
        {
            DataSource uri = JsonConvert.DeserializeObject<DataSource>(File.ReadAllText("../../../Config.json"));
            return uri.Uri; 
        }

        // Obtain UserName from Config.json
        public string GetUserName()
        {
            DataSource username = JsonConvert.DeserializeObject<DataSource>(File.ReadAllText("../../../Config.json"));
            return username.UserName;
        }

        // Obtain Password from Config.json
        public string GetPassword()
        {
            DataSource boomiPassword = JsonConvert.DeserializeObject<DataSource>(File.ReadAllText("../../../Config.json"));
            return boomiPassword.BoomiPassword;
        }
    }
}
