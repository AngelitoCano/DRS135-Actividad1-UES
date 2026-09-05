using Actividad1;

bool salirProgramaPrincipal = false;

while (!salirProgramaPrincipal)
{
    Console.Clear();
    Console.WriteLine("==================================");
    Console.WriteLine("        ACTIVIDAD EVALUADA 1      ");
    Console.WriteLine("         ANGEL CANO CA98033       ");
    Console.WriteLine("        JOSUE ERAZO EG22009       ");
    Console.WriteLine("==================================");
    Console.WriteLine("1. EJERCICIO 1: Abstracción (CuentaBancaria)");
    Console.WriteLine("2. EJERCICIO 2: Encapsulación (Empleado)");
    Console.WriteLine("3. EJERCICIO 3: Herencia");
    Console.WriteLine("4. EJERCICIO 4: Polimorfismo");
    Console.WriteLine("5. EJERCICIO 5: Interfases");
    Console.WriteLine("6. SALIR");
    Console.Write("Seleccione una opción: ");

    string? opcionPrincipal = Console.ReadLine();

    switch (opcionPrincipal)
    {
        case "1":
            EjecutarEjercicio1();
            break;

        case "2":
            Console.WriteLine("\n[Ejercicio 2 en desarrollo por Josue]");
            EjecutarEjercicio2();
            break;

        case "3":
            Console.WriteLine("\n[Ejercicio 3 en desarrollo por Ángel]");
            EjecutarEjercicio3();
            break;

        case "4":
            Console.WriteLine("\n[Ejercicio 4 en desarrollo por Josué]");
            EjecutarEjercicio4();
            break;

        case "5":
            Console.WriteLine("\n[Ejercicio 5 en desarrollo por Ángel]");
            EjecutarEjercicio5();
            EsperarTecla();
            break;

        case "6":
            salirProgramaPrincipal = true;
            Console.WriteLine("\n¡Gracias por utilizar el sistema!");
            break;

        default:
            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
            EsperarTecla();
            break;
    }
}

// =======================================================
// LÓGICA DE EJERCICIOS
// =======================================================
static void EjecutarEjercicio1()
{
    CuentaBancaria? cuenta = null;
    bool salirSubMenu = false;

    while (!salirSubMenu)
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("        BANCO CAPITALSV           ");
        Console.WriteLine("==================================");
        Console.WriteLine("1. Crear Cuenta Bancaria");
        Console.WriteLine("2. Depositar Dinero");
        Console.WriteLine("3. Retirar Dinero");
        Console.WriteLine("4. Consultar Saldo");
        Console.WriteLine("5. Regresar al Menú Principal");
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
                salirSubMenu = true;
                continue;

            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }

        if (!salirSubMenu)
        {
            EsperarTecla();
        }
    }
}

// =======================================================
// LÓGICA DEL EJERCICIO 2
// =======================================================
static void EjecutarEjercicio2()
{
    Console.Clear();
    Console.WriteLine("=== EJERCICIO 2: ENCAPSULACIÓN (EMPLEADO) ===");

    EsperarTecla();
}

static void EjecutarEjercicio3()
{
    Coche? miCoche = null;
    bool salirSubMenu = false;

    while (!salirSubMenu)
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("    EJERCICIO 3: HERENCIA (COCHE) ");
        Console.WriteLine("==================================");
        Console.WriteLine("1. Registrar Nuevo Coche");
        Console.WriteLine("2. Arrancar Coche");
        Console.WriteLine("3. Ver Detalles del Coche");
        Console.WriteLine("4. Regresar al Menú Principal");
        Console.Write("Seleccione una opción: ");

        string? opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("\nIngrese la marca del coche: ");
                string? marca = Console.ReadLine();

                Console.Write("Ingrese el modelo del coche: ");
                string? modelo = Console.ReadLine();

                Console.Write("Ingrese el número de puertas: ");
                if (int.TryParse(Console.ReadLine(), out int puertas) && puertas > 0)
                {
                    miCoche = new Coche(marca ?? "Sin Marca", modelo ?? "Sin Modelo", puertas);
                    Console.WriteLine("\n¡Coche registrado con éxito en el sistema!");
                }
                else
                {
                    Console.WriteLine("\nError: Debe ingresar un número entero de puertas válido.");
                }
                break;

            case "2":
                if (miCoche == null)
                {
                    Console.WriteLine("\nError: Primero debe registrar un coche (Opción 1).");
                    break;
                }
                Console.WriteLine();
                miCoche.Arrancar();
                break;

            case "3":
                if (miCoche == null)
                {
                    Console.WriteLine("\nError: Primero debe registrar un coche (Opción 1).");
                    break;
                }
                miCoche.MostrarInformacion();
                break;

            case "4":
                salirSubMenu = true;
                continue;

            default:
                Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                break;
        }

        if (!salirSubMenu)
        {
            EsperarTecla();
        }
    }
}

static void EjecutarEjercicio4()
{
    Console.Clear();
    Console.WriteLine("=== EJERCICIO 4: POLIMORFISMO ===");

    EsperarTecla();
}

static void EjecutarEjercicio5()
{
    Console.Clear();
    Console.WriteLine("=== EJERCICIO 5: INTERFASES ===");

    EsperarTecla();
}

// Método auxiliar para pausas
static void EsperarTecla()
{
    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}

