using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_8
{
    public class Repository
    {
        List<Group> group = new List<Group>();

        public void LoadDB(string fileName)
        {
            this.group = GetDB(fileName);
        }

        public string[] GetName(int idx)
        {
            string[] result = @group[idx].name;
            return result;
        }
        
        public string[] GetQuantity(int idx)
        {
            string[] result = @group[idx].quantity;
            return result;
        }
        
        public string[] GetRegion(int idx)
        {
            string[] result = @group[idx].region;
            return result;
        }
        
        public string[] GetCost(int idx)
        {
            string[] result = @group[idx].cost;
            return result;
        }

        static List<Group> GetDB(string fileName)
        {
            List<Group> group = new List<Group>();
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Group>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            group = (xmlFormat.Deserialize(fStream) as List<Group>);
            fStream.Close();
            return group;
        }
    }
}