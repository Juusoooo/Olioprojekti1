using character;
using itemNamespace;
using PlayMovement;
using randomEvent;
using shopNamespace;
using weaponNameSpace;

namespace MainFile
{
    class MainRun
    {
        static void Main(string[] args)
        {
            CharacterCreation character = new CharacterCreation();
            character.CharacterRandom();
            character.CharacterAtribute();
            Items items = new Items();
            Movement Map = new Movement(character);
            Shop shop = new Shop(character, Map, items);


            while (true)
            {
                Map.MapCreation();
                Map.GoodEvent();
                Map.AttackEvent();
                Map.DrawPlayer();
                Map.PlayerMovement();
                Console.Clear();
                Map.MapCreation();
                Map.GoodEvent();
                Map.AttackEvent();
                Map.DrawPlayer();

                if (Map.ReturnIsHittable())
                {
                    shop.ShoppingMerchant();
                    
                }
                Console.Clear();
            }
     


            character.ShowInfo();
            RandomEvent randomEvent = new RandomEvent(character);
            randomEvent.EventMaker();


            Console.WriteLine("__________________");

            Weapon weapon = new Weapon(character);

            weapon.AssingWeapon();

            Console.Clear();

            items.AddItem();




        }
    }
}