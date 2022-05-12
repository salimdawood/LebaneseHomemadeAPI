﻿using LebaneseHomemadeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebaneseHomemade.Data.ViewModel
{
    public class CardViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string InstagramLink { get; set; }
        public string FaceBookLink { get; set; }
        public string WhatsAppLink { get; set; }
        public List<PhotoViewModel> PhotoList { get; set; }
        public MenuViewModel Menu { get; set; }
        public string Type { get; set; }
        public DateTime DateCreated { get; set; }
    }
}