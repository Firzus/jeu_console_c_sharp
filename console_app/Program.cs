namespace console_app;
class Program
{
    static void Main(string[] args)
    {
        Intro intro= new Intro();
        intro.drawIntro();

        Menu.menu();

        Console.WriteLine("Fuck the World!");
    }
}