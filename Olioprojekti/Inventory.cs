namespace InventoryNamespace
{
    public class Inventory
    {
        private int playerMoney;
        private int playerItemAmount;
        private int sortNum;

        private string playerItem;

        private List<string> playerItems = new List<string>();

        public Inventory()
        {
            playerMoney = 100;
            playerItemAmount = 0;
        }

        public Inventory(int _playerMoney, int _playerItemAmount, List<string> _playerItems, string _playerItem)
        {
            this.playerMoney = _playerMoney;
            this.playerItemAmount = _playerItemAmount;
            this.playerItems = _playerItems;
            this.playerItem = _playerItem;
        }

        public void AddPlayerItem(string _playerItem)
        {
            playerItem = _playerItem;
            playerItems.Add(playerItem);

            Console.SetCursorPosition(35, 15);
            Console.WriteLine("Here is your invetory: ");

            foreach (var item in playerItems)
            {
                Console.SetCursorPosition(35, 17 + sortNum);
                Console.WriteLine($"{item}");
                sortNum++;
            }

        }



    }
}
