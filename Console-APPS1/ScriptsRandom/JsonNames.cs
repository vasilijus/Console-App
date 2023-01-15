using System;
using System.Net;
// Some of the things that want to practice: 
// JSON(), WebClient()
namespace ScriptsRandom
{
    public class JSON
    {
        public static string GetNamesJSON()
        {
            string baseUrl = "https://gist.githubusercontent.com/vasilijus";
            string pathUrl = "/da6d54cd935ac4027d085a7cba0149e9/raw/deea873f6228f2ad1f429aa6e443df779abf9ad0/NameList.json";
            var json = new WebClient().DownloadString(baseUrl+pathUrl);
            // using (WebClient wc = new WebClient())
            // {
            //     var json = wc.DownloadString(url);
            // }
            Console.WriteLine("string: '{0}", json);
            return json;
        }

        // public static string[] GetNamesArray(string raw)
        // {
        //     // dynamic stuff = Json
        // }
    }
}