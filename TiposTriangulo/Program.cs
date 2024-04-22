decimal lado1, lado2, lado3;
int r = 0;
bool ok = false;
do {
    do
    {
        Console.WriteLine("Digite o primeiro lado");
        lado1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo lado");
        lado2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro lado");
        lado3 = decimal.Parse(Console.ReadLine());
        if (lado1 == 0 || lado2 == 0 || lado3 == 0)
        {
            Console.WriteLine("Lado zerado invalido, repita a declaração");
        }

    } while (lado1 < 0 || lado2 < 0 || lado3 < 0);

    if((lado1 + lado2) >= lado3)
    {
        ok = true;
    }
    else
    {
        if ((lado2 + lado3) >= lado1)
        {
            ok = true;
        } else
        {
            if (lado1 + lado3 >= lado2)
            {
                ok = true;
            }
            else 
            {
                ok = false; 
            }
        }
    }



    if (ok == true)
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("É um triângulo equilátero");
        }
        else
        {
            if ((lado1 == lado2 && lado2 != lado3) || (lado2 == lado3 && lado3 != lado1) || (lado3 == lado1 && lado1 != lado2))
            {
                Console.WriteLine("É um triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("É um triângulo escaleno");
            }
        }
        do
        {
            Console.WriteLine("Deseja digitar outro triângulo? 1 - sim, 2 - não");
            r = int.Parse(Console.ReadLine());
        } while (r < 1 && r > 2);
    } else
    {
        Console.WriteLine("Não é possivel formar um triângulo com esses valores");
    }
} while (r == 1);