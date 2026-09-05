namespace Actividad1;

public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public virtual void Arrancar()
    {
        Console.WriteLine($"El vehículo {Marca} {Modelo} está encendiendo el motor...");
    }
}

public class Coche : Vehiculo
{
    public int NumeroDePuertas { get; set; }

    public Coche(string marca, string modelo, int numeroDePuertas) 
        : base(marca, modelo)
    {
        NumeroDePuertas = numeroDePuertas;
    }

    public override void Arrancar()
    {
        Console.WriteLine($"El coche {Marca} {Modelo} de {NumeroDePuertas} puertas arrancó suavemente. ¡Listo para conducir!");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\n--- DETALLES DEL COCHE ---");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de Puertas: {NumeroDePuertas}");
    }
}