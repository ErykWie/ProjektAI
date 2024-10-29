using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektAI
{
    public class Reader
    {
        public List<Item> ReadItems()
        {
            var items = new List<Item>();

            using (StreamReader reader = new StreamReader("Items.txt")) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] read = line.Split(';');
                    items.Add(new Item(
                        int.Parse(read[0]),
                        read[1],
                        read[2],
                        double.Parse(read[3]),
                        int.Parse(read[4]),
                        double.Parse(read[5])));

                }
            }

            return items;
        }
    }
}
