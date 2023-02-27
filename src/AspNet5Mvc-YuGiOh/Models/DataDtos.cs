using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AspNet5Mvc_YuGiOh.Models
{
    public class DataDtos   //alterar depois para  MonsterCards
    {

        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string frameType { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public List<CardSetDtos> card_sets { get; set; }
        public List<CardImageDtos> card_images { get; set; }
        public List<CardPriceDtos> card_prices { get; set; }

    }
}
