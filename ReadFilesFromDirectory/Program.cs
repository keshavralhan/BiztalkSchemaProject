using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFilesFromDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string gacutilFilePath = System.Configuration.ConfigurationManager.AppSettings["GacutilFilePath"];
            string dllDirectoryPath = System.Configuration.ConfigurationManager.AppSettings["DLLDirectoryPath"];
            string saveFilePath = System.Configuration.ConfigurationManager.AppSettings["SaveFilePath"] + "\\";
            
            if (!string.IsNullOrEmpty(gacutilFilePath) && !string.IsNullOrEmpty(dllDirectoryPath))
            {
                var dllFiles = Directory.GetFiles(dllDirectoryPath, "*.dll");
                List<string> gacFiles = new List<string>();
                foreach (string dlls in dllFiles)
                {
                    //gacutilFilePath = "\"" + gacutilFilePath + "\"" + "-i";
                    string gacUtilQuery = string.Format("\"{0}\"" + " -i " + "\"{1}\"" + " -f ", gacutilFilePath, dlls);
                    gacFiles.Add(gacUtilQuery);
                }
                gacFiles.Add("pause");
                File.WriteAllLines(saveFilePath+ "GacDLLs.bat", gacFiles.ToArray());
            }
        }
    }
}
