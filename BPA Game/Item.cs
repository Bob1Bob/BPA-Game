using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPA_Game
{

    enum rarity { common, uncommon, rare, epic, legendary }; //used for saying how rare this item is compared to other items
    class Item
    {
        //private variables
        private rarity _itemRarity; //the rarirty of the item
        
        public Item(rarity itemRarity)
        {
            _itemRarity = itemRarity;

        }
    }
}
