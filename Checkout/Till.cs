using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Till
    {

        private Dictionary<char, int> _items = new Dictionary<char, int>{
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0}
        };

        public double Total()
        {
            double total = 0;
            foreach (var item in _items)
            {
                if (item.Key.Equals('A'))
                {
                    total += AddItemA(item.Value);
                }
                else if (item.Key.Equals('B'))
                {
                    total += AddItemB(item.Value);
                }
                else if (item.Key.Equals('C'))
                {
                    total += AddItemC(item.Value);
                }
                else total += AddItemD(item.Value);
            }
            return total;
        }

        public double AddItemD(int numberItems)
        {
            double items = numberItems;

            return 15*items;
        }


        public double AddItemC(int numberItems)
        {
            double items = numberItems;

            if(items > 6){
                items = 6;
            }
            
            return 20*items;
        }

        public double AddItemB(int numberItems)
        {
            double items = numberItems;

            var cost = items * 30;
            var remainder = items % 2;  
            var numberOfPairs = (items-remainder) / 2;

            // discount is 15 on each pair
            var discount = numberOfPairs * 15;
            return cost - discount;
        }

        public double AddItemA(int numberItems)
        {
            
            double items = numberItems;
            var remainder = items % 3;            
            var numberOf3s = (items-remainder)/3;            
            var cost = items * 50;            
            var discount = numberOf3s * 20;
            return cost - discount;
        }

        public void Scan(string items)
        {
            foreach (var item in items)
            {
                _items[item]++;
            }
        }
    }
}