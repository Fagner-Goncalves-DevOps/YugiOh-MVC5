using System;
using System.Collections.Generic;

namespace AspNet5Mvc_YuGiOh.Models
{
    public class Root
    {
        public List<DataDtos> data { get; set; }
    }

    public class DataDtos
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }

        //EF relactions - implementações futuras
        //public List<CardSetDtos> CardSetDtos { get; set; }
        //public List<CardImageDtos> CardImageDtos { get; set; }
        //public List<CardPriceDtos> CardPriceDtos { get; set; }
    }






}
