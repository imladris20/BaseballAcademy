using BaseballAcademy.Class;
using BaseballAcademy.Enum;
using BaseballAcademy.Evaluators;

namespace BaseballAcademy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to BaseballAcademy! \n");

        CertificationAgency agency = new CertificationAgency();

        Pitcher lpl = new Pitcher("Po-Lien, Lin", 29);
        lpl.Spinrate = 2000;
        lpl.Velocity = 92.7;

        Infielder ytl = new Infielder("Yin Tai, Lai", 31, BaseballPosition.FirstBase);
        ytl.FieldSpeed = 84;


        lpl.Introduce();
        Console.WriteLine();

        ytl.Introduce();
        Console.WriteLine();

        lpl.Pitch();
        Console.WriteLine();

        ytl.Field();
        Console.WriteLine();

        agency.Certify(lpl);
        Console.WriteLine();

        agency.Certify(ytl);
        Console.WriteLine();
    }
}
