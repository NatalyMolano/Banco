using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Menu
    {
        public static void Main(string[] args)
        {

            string nombre;
            int opcion;
            double deposito;
            double retiro;
            double saldo = 0;
            string salir;

            int n = 0;
            Console.WriteLine("Bienvenido a tu Banco Amigo\n¿Cuantos clientes se le va a realizar el proceso?");
            string dato = Console.ReadLine();
            int cantidad = Convert.ToInt32(dato);

            for (n = 0; n < cantidad; n++)
            {


              /*string nombre;
                int opcion;
                double deposito;
                double retiro;
                double saldo = 0;
                string salir;*/
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("\n-------------------------- ");
                Console.WriteLine( nombre + " su saldo actual es de " + saldo);
                Console.WriteLine("\n¿Que proceso desea realizar?\nSeleccione una de las siguientes opciones\n1.Depositar\n2.Retirar\n3.Salir" +
                    "\n------------------------ ");
                opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1 || opcion == 2 || opcion == 3)
                    {
                        if (opcion == 1)
                        {
                            Console.WriteLine("\nUsted selecciono la opcion de depositar\n¿Cuanto desea Depositar?");
                            deposito = double.Parse(Console.ReadLine());
                            saldo = saldo + deposito;
                            Console.WriteLine("\nSu deposito se realizo exitosamente");
                        }
                        if (opcion == 2)
                        {

                            Console.WriteLine("\nUsted seleccion la opcion de Retirar\n¿Cuanto desea Retirar?");
                            retiro = double.Parse(Console.ReadLine());

                            if (retiro <= saldo)
                            {
                                saldo = saldo - retiro;
                                Console.WriteLine("\nSe realizo exitosamente su retiro de " + saldo);
                            }
                            else
                            {
                                Console.WriteLine("\nEl retiro no se puede realizar por insuficiencia de su saldo actual");
                            }

                        }

                        if (opcion == 3)
                        {
                            Environment.Exit(0);
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nEl ingreso del dato no es valido");
                    }
                    Console.WriteLine("\nSu saldo es de " + saldo);
                    Console.ReadLine();
                    
            }
            double resultado = saldo * cantidad;
            Console.WriteLine("En el dia la cantidad depositada es de: " + resultado);
        }
    }
}
       
