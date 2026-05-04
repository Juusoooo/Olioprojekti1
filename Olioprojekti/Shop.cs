using character;
using InventoryNamespace;
using itemNamespace;
using PlayMovement;



namespace shopNamespace
{
    public class Shop
    {
        CharacterCreation character;
        Movement movement;
        Items items;
        Inventory playerInventory = new Inventory();
        private string input;
        private string eventType;
        private string buyItem;

        private bool isHittable;
        private bool buying;

        private int playerMoney;

        private int itemNum;
        private int itemSortNum;

        private int turn;
        List<string> itemsList;

        private int itemPrice;

        private List<string> itemList1;
        private List<string> itemList2;
        private List<string> itemList3;
        private List<string> itemList4;
        private List<string> itemList5;


        public void itemListed()
        {
            itemList1 = new List<string> { "Apple", "Pear", "Banana" };
            itemList2 = new List<string> { "Mango", "Pineapple" };
            itemList3 = new List<string> { "Healing potion", "Strenght potion", "Agility potion" };
            itemList4 = new List<string> { "Helmet", "Gloves", "Shoes" };
            itemList5 = new List<string> { "Cow meat", "Chicken meat", "Horse meat" };


        }

        public Shop(CharacterCreation _character, Movement _movement, Items _items)
        {
            this.character = _character;
            this.movement = _movement;
            this.items = _items;

        }


        public int GetItemPrice(string item)
        {
            if (itemList1.Contains(item))
                return 5;
            else if (itemList2.Contains(item))
                return 10;
            else if (itemList3.Contains(item))
                return 50;
            else if (itemList4.Contains(item))
                return 100;
            else if (itemList5.Contains(item))
                return 20;

            return 0;
        }



      

        public void ShoppingMerchant()
        {
            

            if (turn < 1)
            {
                items.AddItem();
                playerMoney = playerInventory.PlayerMoney();

            }

            items.RandomItem();
            itemsList = items.ReturnFinalList();
            isHittable = movement.ReturnIsHittable();
            eventType = character.ReturnEvent();







            if (eventType == "Merchant" && isHittable == true)
            {
                Console.SetCursorPosition(30, 2);
                Console.WriteLine("Would you like to buy something? (Y/N)");
                Console.SetCursorPosition(30, 3);
                input = Console.ReadLine().ToLower();
                Console.SetCursorPosition(30, 2);
                Console.Clear();
                itemNum = 0;
                itemSortNum = 0;
                if (input == "y")
                {
                    buying = true;
                    Console.Clear();
                    movement.MapCreation();
                    movement.AttackEvent();
                    movement.GoodEvent();
                    movement.DrawPlayer();

                    Console.SetCursorPosition(30, 2);
                    Console.WriteLine($"Here are all the items i have for sale:\n Your currently have {playerMoney}");

                    foreach (string items in itemsList)
                    {
                        itemPrice = GetItemPrice(items);
                        Console.SetCursorPosition(30, 5 + itemSortNum);
                        Console.WriteLine($"item {itemNum + 1} {items} Price is: {itemPrice}");
                        itemNum++;
                        itemSortNum++;

                    }

                    Console.SetCursorPosition(30, 3);
                    Console.WriteLine($"To select item press 1, 2, 3, 4");

                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            buyItem = itemsList[0];
                            Console.WriteLine($"You bought {itemsList[0]}");
                            break;
                        case ConsoleKey.D2:
                            buyItem = itemsList[1];
                            Console.WriteLine($"You bought {itemsList[1]}");

                            break;
                        case ConsoleKey.D3:
                            buyItem = itemsList[2];
                            Console.WriteLine($"You bought {itemsList[2]}");

                            break;
                        case ConsoleKey.D4:
                            buyItem = itemsList[3];
                            Console.WriteLine($"You bought {itemsList[3]}");

                            break;
                    }

                    playerInventory.AddPlayerItem(buyItem);
                    playerMoney = playerInventory.BuyingItem(buyItem, itemPrice);


                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"You have ");
                    Console.ReadLine();


                }
                else
                {

                }
            }

        }
        public string ReturnBuyItem()
        {
            return buyItem;
        }

        public int ReturnItemPrice()
        {
            return itemPrice;
        }
    }
}
