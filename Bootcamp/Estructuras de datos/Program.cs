
datos persona = new datos("Alberto", "Sanchez", "4761-4535", "Perú 4891","alberto_sanchez78@outlook.com","Antiguo");


Console.WriteLine("-----------------------------------" + "\n" + "Nombre y Apellido: " + persona.nombre +" "+ persona.apellido + "\n" + "Numero de teléfono: "+ persona.numero + "\n" + "Dirección: " + persona.direccion + "\n" + "Correo: " + persona.email + "\n" + "Cliente: " + persona.cliente + "\n" + "-----------------------------------");

public struct datos
{

    public datos(string nombre, string apellido,string numero,string direccion,string email,string cliente)
    {
        this.nombre = nombre;

        this.apellido = apellido;

        this.numero = numero;

        this.direccion = direccion;

        this.email = email;

        this.cliente = cliente;
    }

    public string nombre { get; set; }
  
    public string apellido { get; }

    public string numero { get; }
    
    public string direccion { get; }

    public string email { get; }

    public string cliente { get; }

    public override string ToString() => $"{nombre} {apellido} {numero} {direccion} {email} {cliente}";

}