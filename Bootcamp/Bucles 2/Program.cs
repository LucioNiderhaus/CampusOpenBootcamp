        int num,contadorpositivo,contadornegativo;

        contadornegativo = 0;
        contadorpositivo = 0;

        Console.WriteLine("INGRESAR UN NUMERO : ");
        num = int.Parse(Console.ReadLine());

        do
        {
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                contadornegativo++;
            }
            else
            {
                contadorpositivo++;
            }

        } while (num != 0);

        Console.WriteLine("La cantidad de positivos es de: " + contadorpositivo);
        Console.WriteLine("La cantidad de negativos es de: " + contadornegativo);