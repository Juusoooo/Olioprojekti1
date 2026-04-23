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
            randomEvent.AddRange(new List<string> { "Merchant", "Robbery", "Battle", "Treasure", "Animal attack", "Ghost attack" });

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
            name = "j";
            age = random.Next(18, 81);
            strenght = random.Next(1, 10);
            agility = random.Next(1, 10);
            health = random.Next(50, 200);

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

        public virtual void ShowInfo()
        {
            Console.WriteLine($"name is: {name} age: {age} \nstrenght: {strenght} agility: {agility} health: {health}\nclasss is {characterClass} origin is {characterOrigin} random event is {randomEventString}");
        }
    }
}
