using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAI
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public string Producer { get; set; }
        public double Price { get; set; }
        public int SoldperM { get; set; }
        public double SoldPrice() 
        { 
            return Price * SoldperM;
        }
        public double Makeprice { get; set; }
        public double MakepriceperM() { return Makeprice * SoldperM;}
        public double Erning()
        {
            return SoldPrice() - MakepriceperM();
        }
        public Item()
        {
            
        }
        public Item(int id, string name, string producer, double price, int soldperM, double makePrice)
        {
            ID = id;
            Name = name;
            Producer = producer;
            Price = price;
            SoldperM = soldperM;
            Makeprice = makePrice;

        }
        public override string ToString()
        {
            return $"id: {ID}\n Name: {Name}\n Producer: {Producer}\n Price: {Price} \n {SoldperM} \n {SoldPrice} \n {Makeprice} \n {MakepriceperM} \n {Erning}";
        }
    }
    
}
