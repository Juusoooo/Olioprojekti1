using character;
using itemNamespace;
using PlayMovement;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace shopNamespace
{
    public class Shop
    {
        CharacterCreation character;
        Movement movement;
        Items items;

        private string eventType;
        private bool isHittable;
        private string input;
        private int itemNum;
        List<string> itemsList;

        public Shop(CharacterCreation _character, Movement _movement, Items _items) 
        { 
            this.character = _character;
            this.movement = _movement;
            this.items = _items;
            
        }

        public void ShoppingMerchant()
        {
            items.AddItem();
            itemsList = items.ReturnFinalList();
            isHittable = movement.ReturnIsHittable();
            eventType = character.ReturnEvent();

            if(eventType == "Merchant" && isHittable == true)
            {
                Console.SetCursorPosition(30, 2);
                Console.WriteLine("Would you like to buy something? (Y/N)");
                input = Console.ReadLine().ToLower();
                
                if(input == "y")
                {
                    for(int i = 0; i < itemsList.Count(); i++)
                    {
                        Console.SetCursorPosition(30, i + 1);
                        Console.WriteLine($"Here are items {itemsList[i]}");
                    }
                    Console.ReadLine();
                }
                else
                {
                    
                }
            }
            
        }

    }
}
