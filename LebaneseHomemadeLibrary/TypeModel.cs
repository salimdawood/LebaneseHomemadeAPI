﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebaneseHomemadeLibrary
{
    public class TypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //navigation
        public List<CardModel> CardList { get; set; }
    }
}
