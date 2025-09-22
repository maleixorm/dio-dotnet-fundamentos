using dio_dotnet_fundamentos.Models;

List<string> listaString = new List<string>();
listaString.Add("MG");
listaString.Add("RJ");
listaString.Add("SP");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição Nº {i} - {listaString[i]}");
}