using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BusinessLayer;
namespace DataLayer
{
    public class FileHandlerAccount
    {
        public static String binFileListOfAccount = @"../listOfAccount.bin";
        public static void WriteIntoFileAccounts(List<Account> listOfAccounts)
        {
            FileStream fsListOfAccounts = new FileStream(binFileListOfAccount, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bfListOfAccounts = new BinaryFormatter();
            bfListOfAccounts.Serialize(fsListOfAccounts, listOfAccounts);
            fsListOfAccounts.Close();
        }
        public static List<Account> ReadFromFileAccounts()
        {
            List<Account> listOfAccounts = new List<Account>();
            if (File.Exists(binFileListOfAccount))
            {
                FileStream fsListOfAccounts = new FileStream(binFileListOfAccount, FileMode.Open, FileAccess.Read);
                BinaryFormatter bfListOfAccounts = new BinaryFormatter();
                listOfAccounts = (List<Account>)bfListOfAccounts.Deserialize(fsListOfAccounts);
                fsListOfAccounts.Close();
            }
            return listOfAccounts;
        }
    }
}
