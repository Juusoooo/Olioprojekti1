using character;
using PlayMovement;
using randomEvent;
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

            Movement Map = new Movement(character);


            
                Map.MapCreation();
                Map.GoodEvent();
                Map.AttackEvent();
                Map.DrawPlayer();
                Map.PlayerMovement();
                Console.Clear();
            

            character.ShowInfo();
            RandomEvent randomEvent = new RandomEvent(character);
            randomEvent.EventMaker();


            Console.WriteLine("__________________");

            Weapon weapon = new Weapon(character);

            weapon.AssingWeapon();




        }
    }
}