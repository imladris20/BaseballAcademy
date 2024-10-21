using BaseballAcademy.Class;

namespace BaseballAcademy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BaseballAcademy! \n");

        Player player = new Player("Po-Lien", 29, 1, 70, 75);

        player.Introduce();
    }
}
