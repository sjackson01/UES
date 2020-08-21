using System;
using System.IO;
using System.Net;

namespace UES
{
    class MoodleConnection
    {
        private string _connect;
        private string _url;
        private string _token;
        private string _function; 
        private string _fullName;
        private string _shortName;
        private string _categoryId;

        public string Connect
        {
            get { return _connect; }
            set { _connect = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }

        public string Function
        {
            get { return _function;  }
            set { _function = value; }

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

        
        public MoodleConnection(string url, string token, string function, string fullName, string shortName, string categoryId)
        {
            Url = url;
            Token = token;
            Function = function;
            FullName = fullName;
            ShortName = shortName;
            CategoryId = categoryId; 
            Connect = string.Format(Url, Token, Function,FullName,ShortName,CategoryId);
        }

        // Returns Null upon successful execution 
        public bool CreateRecord()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Connect);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream resStream = resp.GetResponseStream();
                StreamReader reader = new StreamReader(resStream);
                string result = reader.ReadToEnd();
                Console.WriteLine(result);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed: " + e);
                return false;
            }
        }

    }
}
