using character;
namespace weaponNameSpace
{

    public class Weapon
    {
        Random random = new Random();

        private CharacterCreation character;

        private string charClass;
        private string charOrigin;
        private string charWeapon;

        List<string> longMeleeWeapons = new List<string> { "Longsword", "Poleaxe", "Lance", "War hammer" };
        List<string> rangeWeapons = new List<string> { "Bow", "Longbow", "Crossbow",  };
        List<string> staffWeapons = new List<string> { "Fire", "Water", "Earth", };
        List<string> bardWeapons = new List<string> { "Shortsword", "Shortbow", "Whip", };
        List<string> warlockWeapons = new List<string> { "Skull", "Zombi", "Whip", };
        List<string> thiefWeapons = new List<string> { "Dagger", "Throwing knife", "Claw", };





        private int randomNum;
        public Weapon(CharacterCreation _character)
        {
            this.character = _character;
        }

        public void AssingWeapon()
        {
            charClass = character.ReturnClass();
            charOrigin = character.ReturnOrigin();

            switch (charClass)
            {
                case "Archer" :
                    randomNum = random.Next(rangeWeapons.Count());

                    charWeapon = rangeWeapons[randomNum];
                    break;
                case "Knight":
                    randomNum = random.Next(longMeleeWeapons.Count());
                    charWeapon = longMeleeWeapons[randomNum];
                        break;
                case "Wizard":
                    randomNum = random.Next(staffWeapons.Count());
                    charWeapon = staffWeapons[randomNum];
                    break;
                case "Bard":
                    randomNum = random.Next(bardWeapons.Count());
                    charWeapon = bardWeapons[randomNum];
                    break;
                case "Warlock":
                    randomNum = random.Next(warlockWeapons.Count());
                    charWeapon = warlockWeapons[randomNum];
                    break;
                case "Thief":
                    randomNum = random.Next(thiefWeapons.Count());
                    charWeapon = thiefWeapons[randomNum];
                    break;


            }



            ShowInfo();
        }
        //getorigin void 

        public void ShowInfo()
        {
            Console.WriteLine(charClass);
            Console.WriteLine(charOrigin);
            Console.WriteLine(charWeapon);

        }


    }
}
