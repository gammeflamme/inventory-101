using System;
using System.Collections.Generic;
using System.Text;


namespace inventory_101
{
 
    public class Items
    {

        public string name;
        public int id;
        public int Id
        {
        get => id;
        
        
        }
        
        List<object> items = new List<object>();

        public Items()
            {


        }
    }
}
