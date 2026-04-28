using System.Threading.Channels;

namespace character
{
    public class CharacterCreation
    {
        Random random = new Random();
        private int randomNum;
        private string name;
        private int age;
        private int level;
        private int strenght;
        private int agility;
        private int health;

        private string characterClass;
        private string characterOrigin;
        private string randomEventString;
        List<string> randomEvent = new List<string>();
        List<string> playerOrigin = new List<string>();
        List<string> playerCharacter = new List<string>();
        List<string> characterCreation = new List<string>();
        List<string> characterAtribute = new List<string>();

        public CharacterCreation()
        {
            name = "0";
            age = 0;
            level = 0;
            strenght = 0;
            agility = 0;
            health = 0;
            characterClass = "0";
            characterOrigin = "0";
            randomEventString = "0";
        }

        public CharacterCreation(string _name, int _age, int _level, int _strenght, int _agility, int _healt, string _characterOrigin, string _characterClass, string _randomEvent)
        {
            this.randomEventString = _randomEvent;
            this.characterOrigin = _characterOrigin;
            this.characterClass = _characterClass;
            this.name = _name;
            this.age = _age;
            this.level = _level;
            this.strenght = _strenght;
            this.agility = _agility;
            this.health = _healt;
        }

        public List<string> CharacterRandom() //random class, random origin, random event
        {
            playerCharacter.AddRange(new List<string> { "Archer", "Wizard", "Knight", "Bard", "Warlock", "Thief" });
            playerOrigin.AddRange(new List<string> { "Ork", "Elf", "Dwarf", "Minotaur", "Kobold", "Goblin" });
            randomEvent.AddRange(new List<string> { "Merchant", "Robbery", "1V1 Battle", "Treasure", "Animal attack", "Ghost attack" });

            randomNum = random.Next(0, playerCharacter.Count());
            characterClass = playerCharacter[randomNum];

            randomNum = random.Next(0, playerOrigin.Count());
            characterOrigin = playerOrigin[randomNum];

            randomNum = random.Next(0, randomEvent.Count());
            randomEventString = randomEvent[randomNum];

            characterCreation.AddRange(new List<string> { characterClass, characterOrigin, randomEventString });

            return characterCreation;
        }
        public (string, string, string, string, string) CharacterAtribute() //random age, strenght, agility, health etc
        {

            Console.WriteLine("Whats the characters name? ");
            name = Console.ReadLine();
            Console.Clear();
            if (characterOrigin == "Elf")
            {
                age = random.Next(18, 500);
            }
            else if (characterOrigin == "Ork")
            {
                age = random.Next(18, 150);
            }
            else if (characterOrigin == "Dwarf")
            {
                age = random.Next(18, 300);
            }
            else if (characterOrigin == "Minotaur")
            {
                age = random.Next(18, 150);
            }
            else if (characterOrigin == "Kobold")
            {
                age = random.Next(18, 120);
            }
            else if (characterOrigin == "Goblin")
            {
                age = random.Next(18, 60);
            }
            else
            {
                age = random.Next(18, 81);
            }


            switch (characterOrigin)
            {
                case "Minotaur" or "Kobold" or "Ork":
                    if (age > 100)
                    {
                        strenght = random.Next(5, 8);
                        agility = random.Next(1, 3);
                        health = random.Next(150, 200);
                    }
                    else
                    {
                        strenght = random.Next(1, 10);
                        agility = random.Next(1, 5);
                        health = random.Next(100, 200);
                    }
                    break;
                case "Dwarf":
                    if (age > 250)
                    {
                        strenght = random.Next(5, 10);
                        agility = random.Next(1, 3);
                        health = random.Next(150, 300);
                    }
                    else
                    {
                        strenght = random.Next(1, 20);
                        agility = random.Next(1, 2);
                        health = random.Next(250, 300);
                    }
                    break;
                case "Elf":
                    if (age > 400)
                    {
                        strenght = random.Next(5, 10);
                        agility = random.Next(5, 10);
                        health = random.Next(100, 150);
                    }
                    else
                    {
                        strenght = random.Next(1, 10);
                        agility = random.Next(1, 520);
                        health = random.Next(100, 200);
                    }
                    break;

            }
            characterAtribute = new List<string> { name, age.ToString(), strenght.ToString(), agility.ToString(), health.ToString() };

            return (name, age.ToString(), strenght.ToString(), agility.ToString(), health.ToString());
        }

        public string ReturnOrigin()
        {
            return characterOrigin;
        }
        public string ReturnClass()
        {
            return characterClass;
        }
        public string ReturnEvent()
        {
            return randomEventString;
        }

        public virtual void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"name is: {name} age: {age} class is {characterClass}");
            Console.SetCursorPosition(0, 21);
            Console.WriteLine($"strenght: {strenght} agility: {agility} health: {health}");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine($"origin is {characterOrigin} random event is {randomEventString}");
        }   
    }
}
