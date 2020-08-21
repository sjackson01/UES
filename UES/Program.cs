using System;

namespace UES
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool BOOMICONNECTION = false;
            string json = null; 

            /* Boomi Connection */

            // Create credentials object to pass authentication details
            DataSource boomi = new DataSource();
            
            // Connect to api 
            BoomiConnection boomiConnect = new BoomiConnection(boomi.GetUri(), boomi.GetUserName(), boomi.GetPassword());
            
            if (BOOMICONNECTION) { 
                json = boomiConnect.RetrieveCourses(); 
            }

            // Display Json
            Console.WriteLine(json);


            /* Moodle Connection */

            // Create credentials object to pass authentication details 
            DataTarget moodle = new DataTarget();

            // Connect to Moodle web service
            MoodleConnection moodleConnect = new MoodleConnection(moodle.GetUrl(), moodle.GetToken(), moodle.GetFunction(), moodle.GetFullName(), moodle.GetShortName(), moodle.GetCategoryId());

            // Create course
            moodleConnect.CreateRecord();

        }
    }
}
