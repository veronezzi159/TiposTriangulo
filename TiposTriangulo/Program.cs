decimal lado1, lado2, lado3;

do
{
    Console.WriteLine("Digite o primeiro lado");
    lado1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo lado");
    lado2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o terceiro lado");
    lado3 = decimal.Parse(Console.ReadLine());

} while (lado1 > 0 && lado2 > 0 && lado3 > 0);