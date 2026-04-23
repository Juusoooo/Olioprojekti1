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

        public CharacterCreation()
        {
            name = "0";
            age = 0;
            level = 0;
            strenght = 0;
            agility = 0;
            health = 0;
        }

        public CharacterCreation(string _name, int _age, int _level, int _strenght, int _agility, int _healt)
        {
            this.name = _name;
            this.age = _age;
            this.level = _level;
            this.strenght = _strenght;
            this.agility = _agility;
            this.health = _healt;
        }

        public List<string> CharacterRandom()
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

        public void CharacterAtribute()
        {
            name = Console.ReadLine();
            age = random.Next(18, 81);
            strenght = random.Next(1, 10);
            agility = random.Next(1, 10);
            health = random.Next(50, 200);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"name is: {name} age: {age} \nstrenght: {strenght} agility: {agility} health: {health}");
        }
    }
}
