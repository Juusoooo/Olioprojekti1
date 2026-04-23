using character;
using actions;
using weaponNameSpace;
namespace MainFile
{
    class MainRun
    {
        static void Main (string[] args)
        {
            CharacterCreation characterCreation = new CharacterCreation ();
            Weapons weapons = new Weapons();
            ActionsCreation actions = new ActionsCreation();

            characterCreation.CharacterRandom();
            characterCreation.CharacterAtribute();

            characterCreation.ShowInfo();


        }
    }
}