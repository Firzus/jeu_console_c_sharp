namespace console_app;
class Game
{
    static void Main(string[] args)
    {
        Intro intro= new Intro();
        intro.drawIntro();

        Menu.menu();

        Console.WriteLine("Fuck the World!");
    }
}