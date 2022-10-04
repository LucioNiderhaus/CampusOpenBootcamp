int bases, altura;
bool relleno;
string Asteriscos;

Console.WriteLine("Ingresar base");
bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar altura");
altura = int.Parse(Console.ReadLine());
Console.WriteLine("True si querés relleno");
relleno = bool.Parse(Console.ReadLine());

Asteriscos = new string('*', bases);

if (relleno == true)
{

    for (int i = 1; i <= altura; i++)
    {
        for (int j = 1; j <= bases; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine(" ");
    }
}
else
{
    for (int i = 0; i < altura; i++)
    {
        if (i == 0 || i == (altura - 1))
            Console.WriteLine(Asteriscos);
        else
            Console.WriteLine("*{0," + (bases - 2) + "}*", ' ');
    }
}

