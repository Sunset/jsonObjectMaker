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
            string dataPath = ConfigurationManager.AppSettings["dataPath"];
            string fileIntake = ConfigurationManager.AppSettings["fileIntake"];

            var readDataFromFiles = File.ReadAllLines(fileIntake);

            List<string> readDataToParse = new List<string>(readDataFromFiles);

            var objData = "{\n";
            foreach (var data in readDataToParse)
            {
                if(data == "----")
                {
                    objData += "},\n{\n";
                }
                else
                {
                    var list = data.Split('\t');
                    objData += "\"" + list[0] + "\"" + " : " + "\"" + list[1] + "\"" + "\n";
                }
            }
            objData += "}";

            File.WriteAllText(dataPath, objData);

        }
    }
}
