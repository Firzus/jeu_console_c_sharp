using console_app.Team;

namespace console_app
{
    public class Map
    {
        char[,] _map;

        int m_playerX = 11;
        public int PlayerX
        {
            get { return m_playerX; }
            set { m_playerX = value; }
        }

        int m_playerY = 14;
        public int PlayerY
        {
            get { return m_playerY; }
            set { m_playerY = value; }
        }

        Inventaire inventaire = new Inventaire();

        public Map()
        {
            string[] lines = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Map1.txt");
            _map = new char[lines[1].Count(), lines.GetLength(0)];

            int x = 0, y = 0;

            foreach (string line in lines)
            {
                x = 0;
                foreach (char c in line)
                {
                    _map[x, y] = c;
                    x++;
                }
                y++;
            }
        }


        public void DrawMap()
        {
            debut_map:
            Console.Clear();
            var rand = new Random();

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                for (int i = 0; i < _map.GetLength(0); i++)
                {
                    // Joueur
                    if (m_playerX == i && m_playerY == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_map[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        // Hautes herbes
                        if (_map[i, j] == '%')
                        {
                            int chance = rand.Next(5);
                            if (chance < 2)
                            {
                                Fight fight = new Fight();

                                TeamIA.SetTeamComposition();

                                // fight
                                fight.FightScene();
                                goto debut_map;
                            }
                        }

                        // Objets
                        if (_map[i, j] == '!')
                        {
                            //Object object = new Object();
                            //object.AddObject();
                        }

                        continue;
                    }

                    // Carte
                    switch (_map[i, j])
                    {
                        case '%':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    Console.Write(_map[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.I:
                    inventaire.WindowInventaire();
                    break;

                case ConsoleKey.Z:
                    if (_map[m_playerX, m_playerY - 1] != '#')
                    {
                        m_playerY -= 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.Spacebar:
                    DrawMap();
                    break;


                case ConsoleKey.Escape:
                    Menu.menu();
                    break;

                case ConsoleKey.Q:
                    if (_map[m_playerX - 1, m_playerY] != '#')
                    {
                        m_playerX -= 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.S:
                    if (_map[m_playerX, m_playerY + 1] != '#')
                    {
                        m_playerY += 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.D:
                    if (_map[m_playerX + 1, m_playerY] != '#')
                    {
                        m_playerX += 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.J:
                    inventaire.AddAtInventaire("Potion");
                    inventaire.AddAtInventaire("Pierre D'ames");
                    break;

                default:
                    key = Console.ReadKey();
                    break;

            }
        }
    }
}