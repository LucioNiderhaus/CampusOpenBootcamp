internal class Program
{
    public static void Main(string[] args)
    {
        int num, contador;
        string v;
        contador = 0;
        v = "------------------";
        Console.WriteLine("Ingresar un numero");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(v);
        while (contador!=10)
        {
            contador++;
            Console.WriteLine(num * contador);
            
        }
        Console.WriteLine(v);
    }
}