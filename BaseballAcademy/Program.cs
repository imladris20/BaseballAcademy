using BaseballAcademy.Class;
using BaseballAcademy.Enum;

namespace BaseballAcademy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to BaseballAcademy! \n");

        Pitcher lpl = new Pitcher("Po-Lien, Lin", 29);
        Infielder ytl = new Infielder("Yin Tai, Lai", 31, BaseballPosition.FirstBase);

        lpl.Introduce();
        Console.WriteLine();

        ytl.Introduce();
        Console.WriteLine();

        lpl.Pitch();
        Console.WriteLine();

        ytl.Field();
        Console.WriteLine();
    }
}
