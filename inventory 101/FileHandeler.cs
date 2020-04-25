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

        bool isSaved = true;
        public ItemLists get() 
        {

            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                isSaved = false;
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
        public void set(ItemLists lists) 
        {

            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                serialiser.Serialize(file, lists);
                isSaved = true;


            }


        }
        
        
        



    }
}
