using Actividad1;

CuentaBancaria? cuenta = null;
bool salir = false;

while (salir == false)
{
    Console.WriteLine("\n==================================");
    Console.WriteLine("        BANCO CAPITALSV           ");
    Console.WriteLine("==================================");
    Console.WriteLine("1. Crear Cuenta Bancaria");
    Console.WriteLine("2. Depositar Dinero");
    Console.WriteLine("3. Retirar Dinero");
    Console.WriteLine("4. Consultar Saldo");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("\nIngrese el monto de apertura de la cuenta: $");
            if (decimal.TryParse(Console.ReadLine(), out decimal saldoInicial))
            {
                cuenta = new CuentaBancaria(saldoInicial);
                Console.WriteLine("¡Cuenta creada exitosamente!");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
            break;

        case "2":
            if (cuenta == null)
            {
                Console.WriteLine("Error: Primero debe crear una cuenta (Opción 1).");
                break;
            }
            Console.Write("\nIngrese el monto a depositar: $");
            if (decimal.TryParse(Console.ReadLine(), out decimal montoDeposito))
            {
                cuenta.Depositar(montoDeposito);
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
            break;

        case "3":
            if (cuenta == null)
            {
                Console.WriteLine("Error: Primero debe crear una cuenta (Opción 1).");
                break;
            }
            Console.Write("\nIngrese el monto a retirar: $");
            if (decimal.TryParse(Console.ReadLine(), out decimal montoRetiro))
            {
                cuenta.Retirar(montoRetiro);
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
            break;

        case "4":
            if (cuenta == null)
            {
                Console.WriteLine("Error: Primero debe crear una cuenta (Opción 1).");
                break;
            }
            Console.WriteLine($"\nSaldo actual en la cuenta: ${cuenta.ObtenerSaldo()}");
            break;

        case "5":
            salir = true;
            Console.WriteLine("\nGracias por usar Banco CapitalSV. ¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }

    // Pausa para que el usuario pueda leer las respuestas antes de volver a mostrar el menú
    if (!salir)
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}
