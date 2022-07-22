using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO.Compression;


namespace JSON_Object_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string directoryPath = ConfigurationManager.AppSettings["directoryPath"];
            string fileIntake = ConfigurationManager.AppSettings["fileIntake"];

            var readDataFromFiles = File.ReadAllLines(fileIntake);

            List<string> readDataToParse = new List<string>(readDataFromFiles);

            foreach (var data in readDataToParse)
            {
                var list = data.Split('\t');
                var a = 0;
            }
        }
    }
}
