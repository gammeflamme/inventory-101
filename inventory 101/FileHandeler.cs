using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace inventory_101
{
    public class FileHandeler
    {
        XmlSerializer serialiser = new XmlSerializer(typeof(ItemLists));

        public ItemLists Load() 
        {

            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                //return (ItemLists)serialiser.Deserialize(file);
                try
                {
                    return (ItemLists)serialiser.Deserialize(file);
                }
                catch(System.InvalidOperationException)
                {
                    return (new ItemLists());
                }
            }
        }
        public void Save(ItemLists lists) 
        {

            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                serialiser.Serialize(file, lists);



            }


        }








    }
}
