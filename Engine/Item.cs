﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item // gives a item an id and name 
    {
        public int ID {get;set;}
        public string Name {get;set;}
        public string NamePlural {get;set;}


        public Item(int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
