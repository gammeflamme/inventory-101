using System;
using System.Collections.Generic;
using System.Text;


namespace inventory_101
{

    public class Cables : Electronics
    {
        public float length;



        public override string ToString()
        {
            return "Cable id:" + this.id + " Name:" + this.name + " Length:" + this.length + " M";
        }
    }

    
    
}
