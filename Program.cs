using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;

double saldo = 1000;
int alt = 0;
while (alt != 4)
{
    System.Console.WriteLine("------BIENVENIDO AL SISTEMA BANCARIO------" );
    System.Console.WriteLine("-----LE BRINDAMOS EL MENU DE OPCIONES-----");
    System.Console.WriteLine("1.- Consulta tu saldo ");
    System.Console.WriteLine("2.- Deposita tu dinero aquí ");
    System.Console.WriteLine("3.- Retira tu dinero aquí ");
    System.Console.WriteLine("4.- Salir ");
    System.Console.Write("Que opción desea seleccionar: " );
    alt = int.Parse(Console.ReadLine()!);
    switch (alt)
    {
        case 1:
        Console.WriteLine("Este es tu saldo actual:$ " + saldo);
        break;
        case 2: 
        System.Console.WriteLine("Cuanto dinero desea depositar?: ");
        double deposito = double.Parse(Console.ReadLine()!);
        saldo = saldo + deposito ;
        Console.WriteLine("Deposito hecho con éxito.");
        Console.WriteLine("Ahora tu nuevo saldo es de :" + saldo);
        break;
        
    }
}

