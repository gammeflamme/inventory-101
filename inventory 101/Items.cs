using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace inventory_101
{
    public class Items
    {
        public XmlSerializer serialiser = new XmlSerializer(typeof(List<Cables>));
        public string name;
        public int id;
        public int Id
        {
        get => id;
        
        
        }
        
        List<object> items = new List<object>();

        public Items()
            {
            /*
            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                items = (List<object>)serialiser.Deserialize(file);

                id = items.Count;

            }
            */

        }
    }
}
