using character;

namespace PlayMovement
{


    public class Movement
    {
        private CharacterCreation character;
        private Random random = new Random();

        private string randomEvent;
        private string charModel;
        private string charOrigin;

        private bool isHittable;
        private int isHittableCal;

        private string playerModel;
        private string enemyModel;

        private int playerPosX;
        private int playerPosY;
        private int enemyPosX;
        private int enemyPosY;
        private int enemyPosX2;
        private int enemyPosY2;
        private int enemyPosX3;
        private int enemyPosY3;
        private int enemyPosX4;
        private int enemyPosY4;
        private int turn;

        private int mapSizeY;
        private int mapSizeX;

        public Movement(CharacterCreation _character)
        {
            this.character = _character;
        }
        public void GoodEvent()
        {
            randomEvent = character.ReturnEvent();

            if (randomEvent == "Merchant")
            {
                if (turn == 0)
                {
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    enemyModel = "M";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;


                }
                else
                {
                    enemyModel = "M";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;


                }
            }

            else if (randomEvent == "Treasure")
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (turn < 1)
                {
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    enemyModel = "T";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;

                }
                else
                {
                    enemyModel = "T";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;

                }
            }
        }

        public void AttackEvent() //randomEvent == "Robbery" || randomEvent == "Animal attack" || randomEvent == "1V1 Battle" || randomEvent == "Ghost attack" ||
        {

            randomEvent = character.ReturnEvent();

            if (randomEvent == "1V1 Battle")
            {
                if (turn == 0)
                {
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    enemyModel = "E";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;


                }
                else
                {
                    enemyModel = "E";
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;


                }
            }

            else if (randomEvent == "Animal attack")
            {

                Console.ForegroundColor = ConsoleColor.White;
                if (turn == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    enemyModel = "E";
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.Write(enemyModel);
                    enemyPosX2 = random.Next(1, 20);
                    enemyPosY2 = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX2, enemyPosY2);
                    Console.Write(enemyModel);
                    enemyPosX3 = random.Next(1, 20);
                    enemyPosY3 = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX3, enemyPosY3);
                    Console.Write(enemyModel);
                    turn++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    enemyModel = "E";

                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.Write(enemyModel);

                    Console.SetCursorPosition(enemyPosX2, enemyPosY2);
                    Console.Write(enemyModel);

                    Console.SetCursorPosition(enemyPosX3, enemyPosY3);
                    Console.Write(enemyModel);
                    turn++;

                }

            }
            else if (randomEvent == "Robbery")
            {

                if (turn == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    enemyModel = "E";
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.Write(enemyModel);
                    enemyPosX2 = random.Next(1, 20);
                    enemyPosY2 = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX2, enemyPosY2);
                    Console.Write(enemyModel);
                    enemyPosX3 = random.Next(1, 20);
                    enemyPosY3 = random.Next(1, 20);
                    Console.SetCursorPosition(enemyPosX3, enemyPosY3);
                    Console.Write(enemyModel);
                    turn++;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    enemyModel = "E";

                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.Write(enemyModel);

                    Console.SetCursorPosition(enemyPosX2, enemyPosY2);
                    Console.Write(enemyModel);

                    Console.SetCursorPosition(enemyPosX3, enemyPosY3);
                    Console.Write(enemyModel);
                    turn++;

                }
            }
            else if (randomEvent == "Ghost attack")
            {
                if (turn < 1)
                {
                    enemyPosX = random.Next(1, 20);
                    enemyPosY = random.Next(1, 20);
                    enemyModel = "E";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;

                }
                else
                {
                    enemyModel = "E";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(enemyPosX, enemyPosY);
                    Console.WriteLine(enemyModel);
                    turn++;

                }
            }
            Console.ForegroundColor = ConsoleColor.White;

        }





        public void MapCreation()
        {
            mapSizeX = 20;
            mapSizeY = 20;
            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        public void PlayerMovement()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.W:
                    playerPosY -= 1;
                    break;
                case ConsoleKey.S:
                    playerPosY += 1;
                    break;
                case ConsoleKey.A:
                    playerPosX -= 1;
                    break;
                case ConsoleKey.D:
                    playerPosX += 1;
                    break;
            }

            ReturnIsHittable();
            
        }

        public bool ReturnIsHittable()
        {
            if (randomEvent == "Ghost attack" || randomEvent == "1V1 Battle" || randomEvent == "Merchant" || randomEvent == "Treasure")
            {
                if (Math.Abs(playerPosX - enemyPosX) == 1 && playerPosY == enemyPosY || Math.Abs(playerPosY - enemyPosY) == 1 && playerPosX == enemyPosX)
                {
                    isHittable = true;
                    Console.WriteLine("Hitting enemy");
                    return isHittable;
                }

            }
            return isHittable;
        }

        public void DrawPlayer()
        {
            if (playerPosX == null)
            {

                playerPosX = random.Next(1, 20);
                playerPosY = random.Next(1, 20);
                playerModel = "P";

                Console.SetCursorPosition(playerPosX, playerPosY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(playerModel);
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {

                playerModel = "P";

                Console.SetCursorPosition(playerPosX, playerPosY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(playerModel);
                Console.ForegroundColor = ConsoleColor.White;
            }

            charOrigin = character.ReturnOrigin();
        }


    }




}
