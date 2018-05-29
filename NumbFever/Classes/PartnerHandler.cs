using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public static class PartnerHandler
    {
        //static class for handling partners(Create directory, search, save, read)


        //a list that contains the partners as objects
        public static List<Partner> partners;

        static PartnerHandler()
        {
            partners = new List<Partner>();

        }

        //this method creates a directory for the new partner
        public static void CreateDirectoryForPartner(Partner partner)
        {
            Directory.CreateDirectory($"{partner.Name}");
        }

        //this method checks if the partner has a txt file
        public static bool SearchForPartner(Partner partner)
        {
            string path = Directory.GetCurrentDirectory();
            string[] directories = Directory.GetDirectories(path);
            foreach (string i in directories)
            {
                FileInfo file = new FileInfo(i);
                if (file.Name == partner.Name)
                    return true;
            }
            return false;
        }

        //this method creates a txt for the new partner, or delete it and create a new txt to modify the datas.
        //The txt files get hidden attribute
        public static void SavePartner(Partner partner,bool edit)
        {
            string path = $"{partner.Name}\\{partner.Name.Replace(".", "")}.txt";

            if (edit)
            {
                File.Delete(path);
                
            }
            
            using (FileStream file = File.Open(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    List<string> infosList = new List<string>();
                    infosList.Add(partner.Name);
                    infosList.Add(partner.Address);
                    infosList.Add(partner.Taxnumber);
                    infosList.Add(partner.BankAccountNumber);
                    infosList.Add(partner.ContactName);
                    infosList.Add(partner.ContactPosition);
                    infosList.Add(partner.ContactPhoneNumber);
                    infosList.Add(partner.Other);
                    string[] infosArray = infosList.ToArray();
                    foreach (string i in infosArray)
                    {
                        writer.WriteLine(i);
                    }

                }
            }
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);


        }



        //this method refresh the partnerlist of the PartnerHandler static class
        public static void RefreshPartners()
        {
            partners.Clear();
            string path = Directory.GetCurrentDirectory();
            string[] directories = Directory.GetDirectories(path);
            foreach (var item in directories)
            {
                if (item != path+"\\Settings" && item != path+"\\de")
                {
                    string[] partnerInfos = new string[8];
                    string dirName = item.Substring(item.LastIndexOf("\\"));
                    using (FileStream file = File.Open($"{item}{dirName}.txt", FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                partnerInfos[i] = reader.ReadLine();
                            }
                        }
                    }
                    Partner partner = new Partner(partnerInfos[0], partnerInfos[1], partnerInfos[2], partnerInfos[3], partnerInfos[4], partnerInfos[5], partnerInfos[6], partnerInfos[7]);
                    partners.Add(partner);

                }


            }

        }
    }
}
