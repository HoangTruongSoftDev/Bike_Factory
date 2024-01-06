using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Xml;
using System.Xml.Serialization;
using BusinessLayer;
namespace DataLayer
{
    public class FileManager
    {
        private static String binFileListOfBikes = @"../listOfBikesBinFile.bin";
        public static String xmlFileListOfBikes = @"../listOfBikesXMLFile.xml";
        public static void WriteIntoBinFileBikes(List<Bike> listOfBikes)
        {
            FileStream fsListOfBikes = new FileStream(binFileListOfBikes, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bfListOfBikes = new BinaryFormatter();
            bfListOfBikes.Serialize(fsListOfBikes, listOfBikes);
            fsListOfBikes.Close();
        }

        public static List<Bike> ReadFromBinFileBikes()
        {
            List<Bike> listOfBikes = new List<Bike>();
            if (File.Exists(binFileListOfBikes))
            {
                FileStream fsListOfBikes = new FileStream(binFileListOfBikes, FileMode.Open, FileAccess.Read);
                BinaryFormatter bfListOfBikes = new BinaryFormatter();
                listOfBikes = (List<Bike>)bfListOfBikes.Deserialize(fsListOfBikes);
                fsListOfBikes.Close();
            }
            return listOfBikes;
        }
        public static void WriteIntoXmlFileBikes(List<Bike> listOfBikes)
        {

            XmlWriter xw = XmlWriter.Create(xmlFileListOfBikes);

            XmlSerializer xs = new XmlSerializer(typeof(List<Bike>));

            xs.Serialize(xw, listOfBikes);

            xw.Close();

        }
        public static List<Bike> ReadFromXmlFileBikes()
        {
            List<Bike> listOfBikes = new List<Bike>();
            if (File.Exists(xmlFileListOfBikes))
            {

                StreamReader sr = new StreamReader(xmlFileListOfBikes);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));

                listOfBikes = (List<Bike>)xmlSerializer.Deserialize(sr);

                sr.Close();
            }


            return listOfBikes;
        }
    }
}
