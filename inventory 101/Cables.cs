﻿using System;
using System.Collections.Generic;
using System.Text;


namespace inventory_101
{

    public class Cables : Electronics
    {
        public float length;


        public override string ToString()
        {
            return "Cable id:" + id + " Name:\"" + name + "\" Length:" + length + "m";
        }
    }
}
