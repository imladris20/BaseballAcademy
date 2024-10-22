using BaseballAcademy.Class;
using BaseballAcademy.Enum;

namespace BaseballAcademy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BaseballAcademy! \n");

        Player cardsfan = new Player("Po-Lien", 29, BaseballPosition.Pitcher, 70, 75);

        cardsfan.Introduce();

        Console.WriteLine($"{cardsfan.Position}");

        cardsfan.ChangePosition(BaseballPosition.CenterField);

        Console.WriteLine($"{cardsfan.Position}");

    }
}
