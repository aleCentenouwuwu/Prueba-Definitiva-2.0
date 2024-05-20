Console.WriteLine("Calculo de IMC");
Console.WriteLine("Ingrese valores, por favor");
Console.WriteLine("Altura (en metros)>>");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Peso (en kg) >>");
double peso = Convert.ToDouble(Console.ReadLine());
Console.Clear();
double indicecorporal = peso / (altura * altura);
Console.WriteLine("Su Indice de masa corporal es de " + indicecorporal);
if (indicecorporal > 29 && indicecorporal < 35)
{
    Console.WriteLine("Usted se enceuntra en Obesidad I");
}
else if (indicecorporal >= 35 && indicecorporal < 40)
{
    Console.WriteLine("Usted se encuentra en Obesidad II");
}
else if (indicecorporal >= 40)
{
    Console.WriteLine("Usted se encuentra en Obesidad III ");
}
else if (indicecorporal >= 25 && indicecorporal < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (indicecorporal >= 19 && indicecorporal < 25)
{
    Console.WriteLine("Usted es saludable");

}
else
{
    Console.WriteLine("Estas demasiado delgado");
}



