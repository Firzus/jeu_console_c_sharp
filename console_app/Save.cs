using console_app;
using System.Text.Json;

namespace console_app
{
    public class DonnéesSortie
    {
        public int _playerX { get; set; }
        public int _playerY { get; set; }
    }

    public class Save
    {
        public void SaveData(int PlayerX, int PlayerY)
        {
            var données = new DonnéesSortie
            {
                _playerX = PlayerX,
                _playerY = PlayerY,
            };

            string fileName = @"Save.json";
            string jsonString = JsonSerializer.Serialize(données);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
