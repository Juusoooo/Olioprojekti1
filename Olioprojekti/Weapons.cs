using System;
using System.Collections.Generic;
using System.Text;
using character;
using actions;
namespace weaponNameSpace
{

    public class Weapons : CharacterCreation
    {
        CharacterCreation characterCreation = new CharacterCreation();
        ActionsCreation rndCharacter = new ActionsCreation();
        List<string> weaponTypes = new List<string>();
        List<string> character = new List<string>();

        public Weapons() : base()
        {

        }

        public void weaponList()
        {

            weaponTypes = new List<string> { "Range", "Sword", "Spear", "Instrument", "Staff"};


            foreach(string item in character)
            {
                Console.WriteLine(item);
            }
        }


    }
}
