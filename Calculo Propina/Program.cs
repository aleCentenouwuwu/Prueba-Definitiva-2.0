
Console.WriteLine(">Ingrese su total a pagar.");
double pago = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Desea dejar propina? (diga que si pls)");
Console.WriteLine("1. Si");
Console.WriteLine("2. No");
byte siono = Convert.ToByte(Console.ReadLine());

switch (siono)
{
    case 1:
        Console.WriteLine("Cuanto porcentaje de propina quiere dejarnos? uwu");
        double propina = Convert.ToDouble(Console.ReadLine());
        double totalpropina = pago * (propina / 100);
        Console.WriteLine();
        double totalpagar = totalpropina + pago;
        Console.WriteLine("Su total es de " + pago + " con una propina de " + totalpropina + ".");
        Console.WriteLine("TOTAL>>" + totalpagar);
        break;

    case 2:
        Console.WriteLine("TOTAL>>" + pago);
        Console.WriteLine("Gracias por venir, lo esperamos de nuevo!");
        break;

    default:
        Console.WriteLine("Opcion no valida");
        break;
}



