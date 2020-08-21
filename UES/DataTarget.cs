using System.IO;
using Newtonsoft.Json;

namespace UES
{
    class DataTarget
    {
        private string _token;
        private string _url;
        private string _function;
        private string _fullName;
        private string _shortName;
        private string _categoryId;

        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string Function
        {
            get { return _function; }
            set { _function = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string ShortName
        {
            get { return _shortName; }
            set { _shortName = value; }
        }

        public string CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }




        // Obtain Token from Config.json 
        public string GetToken()
        {
            DataTarget token = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return token.Token;
        }

        // Obtain Url from Config.json
        public string GetUrl()
        {
            DataTarget url = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return url.Url;
        }

        // Obtain Function from Config.json
        public string GetFunction()
        {
            DataTarget function = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return function.Function;
        }

        // Obtain Course Full Name from Config.json
        public string GetFullName()
        {
            DataTarget fullName = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return fullName.FullName;
        }

        // Obtain Course Short Name from Config.json
        public string GetShortName()
        {
            DataTarget shortname = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return shortname.ShortName;
        }

        // Obtain Course Category Id from Config.json
        public string GetCategoryId()
        {
            DataTarget categoryId = JsonConvert.DeserializeObject<DataTarget>(File.ReadAllText("../../../Config.json"));
            return categoryId.CategoryId;
        }

    }
}