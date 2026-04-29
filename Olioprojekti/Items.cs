using System;
using System.Collections.Generic;
using System.Text;

namespace itemNamespace
{
    public class Items
    {



        Random random = new Random();

        private string item1;
        private string item2;
        private string item3;
        private string item4;

        private int rndNum;
        private int price;
        private int money;

        private List<string> itemList1;
        private List<string> itemList2;
        private List<string> itemList3;
        private List<string> itemList4;
        private List<string> finalList;

        

        public Items() 
        {
            item1 = " ";
            item2 = " ";
            item3 = " ";
            item4 = " ";
            

        }
        public Items(string _item1, string _item2, string _item3, string _item4)
        {
            this.item1 = _item1;
            this.item2 = _item2;
            this.item3 = _item3;
            this.item4 = _item4;
        }

        public void AddItem()
        {

            itemList1 = new List<string> { "Apple", "Pear", "Mango", "Pineapple", "Banana" };
            itemList2 = new List<string> { "Healing potion", "Strenght potion", "Agility potion" };
            itemList3 = new List<string> { "Helmet", "Gloves", "Shoes" };
            itemList4 = new List<string> { "Beef", "Chicken", "Horse" };

            rndNum = random.Next(itemList1.Count);
            item1 = itemList1[rndNum];

         
            itemList1.Remove(item1);
            rndNum = random.Next(itemList2.Count);
            item2 = itemList2[rndNum];
            itemList2.Remove(item2);
            rndNum = random.Next(itemList3.Count);
            item3 = itemList3[rndNum];
            itemList3.Remove(item3);
            rndNum = random.Next(itemList4.Count);
            item4 = itemList4[rndNum];
            itemList4.Remove(item4);

            finalList = new List<string> { item1, item2, item3, item4 };   

        }

        public List<string> ReturnFinalList()
        {
            return finalList;
        }

    }
}
