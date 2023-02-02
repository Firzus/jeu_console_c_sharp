using console_app;
using System.Text.Json;

namespace console_app
{
    public class DonnéEntrée
    {
        public int _playerX { get; set; }
        public int _playerY { get; set; }
    }

    public class Load
    {
        public void LoadData()
        {
            string fileName = @"Save.json";
            string jsonString = File.ReadAllText(fileName);
            DonnéEntrée donnéesentrée = JsonSerializer.Deserialize<DonnéEntrée>(jsonString)!;

            Console.WriteLine($"PlayerX : {donnéesentrée._playerX}");
            Console.WriteLine($"PlayerX : {donnéesentrée._playerY}");
        }
    }
}
