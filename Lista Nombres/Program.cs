string[] nombres = { "Itza", "Victor", "Alexania", "Lia", "Norvin", "Nate" };
Console.WriteLine("Ingrese el nombre a buscar");
string buscar = Console.ReadLine();
bool encontrado = nombrelista(nombres, buscar);

if (encontrado)
{
    Console.WriteLine("El nombre se encuentra en la lista.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("El nombre no se encuentra en la lista.");
    Console.ReadKey();
}
        
static bool nombrelista(string[] arreglo, string valor)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == valor)
        {
            return true;
        }
    }
    return false;

}