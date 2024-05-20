Console.WriteLine("Ingrese el tamaño del arreglo:");
int tamaño = Convert.ToInt32(Console.ReadLine());
int[] numeros = new int[tamaño];
Console.Clear();
Console.WriteLine("Ingrese los elementos del arreglo");
for (int i = 0; i < tamaño; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
BubbleSort(numeros);

Console.WriteLine("Ingrese el número que desea buscar:");
int numerobuscar = Convert.ToInt32(Console.ReadLine());
int indice = BusquedaBinaria(numeros, numerobuscar);


if (indice != -1)
{
    Console.WriteLine("El número se encuentra en el índice " + indice + " del arreglo.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("El número no se encuentra en el arreglo.");
    Console.ReadKey();
}

        
        static void BubbleSort(int[] arreglo)
{
    int n = arreglo.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arreglo[j] > arreglo[j + 1])
            {

                int temp = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = temp;
            }
        }
    }
}

 static int BusquedaBinaria(int[] arreglo, int valor)
{
    int inicio = 0;
    int fin = arreglo.Length - 1;

    while (inicio <= fin)
    {
        int medio = (inicio + fin) / 2;

        if (arreglo[medio] == valor)
        {
            return medio;
        }
        else if (arreglo[medio] < valor)
        {
            inicio = medio + 1;
        }
        else
        {
            fin = medio - 1;
        }
    }

    return -1;

}