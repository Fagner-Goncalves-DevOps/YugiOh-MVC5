using System;
using System.Collections.Generic;

namespace AspNet5Mvc_YuGiOh.Models
{
    //public class Root
    //{
    //    public List<DataDtos> data { get; set; }
    //}

    public class DataDtos   //alterar depois para  MonsterCards
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

        public List<CardSetDtos> card_sets { get; set; }
        public List<CardImageDtos> card_images { get; set; }
        public List<CardPriceDtos> card_prices { get; set; }

        //public string card_sets { get; set; }
        //public string card_images { get; set; }
        //public string card_prices { get; set; }


        //Monster Cards

        //id - ID or Passcode of the card.
        //name - Name of the card.
        //type* - The type of card you are viewing (Normal Monster, Effect Monster, Synchro Monster, etc).
        //desc - Card description/effect.
        //atk - The ATK value of the card.
        //def - The DEF value of the card.
        //level - The Level/RANK of the card.
        //race - The card race which is officially called type (Spellcaster, Warrior, Insect, etc).
        //attribute - The attribute of the card.

        //EF relactions - implementações futuras
        //public List<CardSetDtos> CardSetDtos { get; set; }
        //public List<CardImageDtos> CardImageDtos { get; set; }
        //public List<CardPriceDtos> CardPriceDtos { get; set; }
    }






}
