using BaseballAcademy.Class;

namespace BaseballAcademy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BaseballAcademy! \n");

        Player cardsfan = new Player("Po-Lien", 29, 1, 70, 75);

        cardsfan.Introduce();
        
        Console.WriteLine($"{cardsfan.Position}");

        cardsfan.ChangePosition(8);

        Console.WriteLine($"{cardsfan.Position}");

    }
}
