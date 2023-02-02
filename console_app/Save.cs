using console_app;
using System.Text.Json;

namespace console_app
{
    public class Données
    {
        public int _playerX { get; set; }
        public int _playerY { get; set; }

    }

    public class Save
    {
        public void SaveData(int m_playerX, int m_playerY)
        {
            var données = new Données
            {
                _playerX = m_playerX,
                _playerY = m_playerY,
            };

            string fileName = "Save.json";
            string jsonString = JsonSerializer.Serialize(données);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }

    }
}
