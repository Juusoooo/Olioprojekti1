using actions;
using character;
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
            character.ShowInfo();
            Console.WriteLine("__________________");

            RandomEvent randomEvent = new RandomEvent(character);

            randomEvent.EventMaker();

            Console.WriteLine("__________________");

            Weapon weapon = new Weapon(character);

            weapon.AssingWeapon();




        }
    }
}