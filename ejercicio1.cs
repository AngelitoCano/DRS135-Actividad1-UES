namespace Actividad1;

public class CuentaBancaria
{
    private decimal saldo;

    public CuentaBancaria(decimal saldoInicial)
    {
        if (saldoInicial < 0)
        {
            Console.WriteLine("El saldo inicial no puede ser negativo. Se asignará $0.00");
            saldo = 0;
            return;
        }
        saldo = saldoInicial;
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto a depositar debe ser positivo.");
            return;
        }
        saldo = saldo + monto;
        Console.WriteLine($"Depósito exitoso de ${monto}. Saldo actual: ${saldo}");
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto a retirar debe ser positivo.");
            return;
        }
        if (monto > saldo)
        {
            Console.WriteLine("Error: Fondos insuficientes para realizar el retiro.");
            return;
        }
        saldo = saldo - monto;
        Console.WriteLine($"Retiro exitoso de ${monto}. Saldo restante: ${saldo}");
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}