using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public class ComponentsChecker
    {
        public void CheckComponents(string path)
        {
            this.checkSettingsDirectory(path);
            this.checkSettingsFiles(path);
        }
        //Settings directory contains the files for the own company and the rate of the tax.
        private void checkSettingsDirectory(string path)
        {
            string[] dir = Directory.GetDirectories(path);
            bool hasSettings = false;
            foreach (var item in dir)
            {
                if (item.Contains("Settings"))
                    hasSettings = true;
            }
            if (!hasSettings)
            {
                Directory.CreateDirectory("Settings");
            }
        }
        //2 files should be in the directory, Owncompany.txt and Tax.txt
        private void checkSettingsFiles(string path)
        {
            string filePath = path + "\\Settings\\";
            bool hasTax = false;
            bool hasOwnCompany = false;
            string[] files = Directory.GetFiles(filePath);
            foreach (var item in files)
            {
                if (item.Contains("OwnCompany.txt"))
                    hasOwnCompany = true;
                if (item.Contains("Tax.txt"))
                    hasTax = true;
            }
            if (!hasOwnCompany)
            {
                FileStream file = File.Create(filePath + "OwnCompany.txt");
                file.Close();
                string[] dummyText = new[] { "empty", "empty", "empty", "empty" };
                File.WriteAllLines(filePath + "OwnCompany.txt", dummyText);
            }
            
            if (!hasTax)
            {
                FileStream file2 = File.Create(filePath + "Tax.txt");
                file2.Close();
                string[] dummyText = { "0", "5", "27" };
                File.WriteAllLines(filePath + "Tax.txt", dummyText);
            }
                
        }
    }
}
