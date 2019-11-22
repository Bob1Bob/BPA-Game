using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPA_Game
{

    enum rarity { common, uncommon, rare, epic, legendary }; //used for saying how rare this item is compared to other items
    abstract class Item
    {
        //private variables
        private rarity _itemRarity; //the rarirty of the item
        private string _itemName; //the name of the item
        //TODO:
        //add stat names (maybe health, damage, energy)
        
        public Item(rarity itemRarity)
        {
            _itemRarity = itemRarity;

        }
    }
}
