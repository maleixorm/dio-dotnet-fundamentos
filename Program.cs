using dio_dotnet_fundamentos.Models;

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 56;

foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}