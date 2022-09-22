using System;
using System.Diagnostics;

namespace net.calculadora.xyz
{
    class Program
    {
        public static string entrada1;
        public static string entrada2;
        public static int numero1;
        public static int numero2;
        public static void Ends(string clase)
        {
            Console.WriteLine($">>   [{clase}: Salida] para iniciar de nuevo el programa escribe nueva operación");
            Console.WriteLine($">>   [{clase}: Salida] para terminar la ejecucion del programa escribe salir");
            string texto = Console.ReadLine();
            switch (texto.ToLower())
            {
                case "nueva operación":
                    Main();
                    break;
                case "nueva operacion":
                    Main();
                    break;
                case "salir":
                    Process[] proc = Process.GetProcessesByName("net.calculadora.xyz");
                    Console.WriteLine(">>   [Proceso: Fin] terminando la ejecucion del programa");
                    proc[0].WaitForExit(1000);
                    proc[0].Kill();
                    break;
                default:
                    Console.Clear();
                    Ends(clase);
                    break;
            }
        }
        public static void Suma()
        {
            Console.WriteLine(">>   [Suma: Entrada] ingresa el primer numero de la suma");
            entrada1 = Console.ReadLine(); try
            {
                numero1 = int.Parse(entrada1);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Suma: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Suma();
            }
            Console.WriteLine(">>   [Suma: Entrada] ingresa el segundo numero de la suma");
            entrada2 = Console.ReadLine(); try
            {
                numero2 = int.Parse(entrada2);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Suma: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Suma();
            }
            int resultado = numero1 + numero2;
            Console.WriteLine($"\n>>   [Suma: Proceso] la suma {numero1} + {numero2} ha dado como resultado: {resultado}\n");
            Ends("Suma");
            return;
        }
        public static void Resta()
        {
            Console.WriteLine(">>   [Resta: Entrada] ingresa el primer numero de la resta");
            entrada1 = Console.ReadLine(); try
            {
                numero1 = int.Parse(entrada1);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Resta: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Resta();
            }
            Console.WriteLine(">>   [Resta: Entrada] ingresa el segundo numero de la resta");
            entrada2 = Console.ReadLine(); try
            {
                numero2 = int.Parse(entrada2);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Resta: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Resta();
            }
            int resultado = numero1 - numero2;
            Console.WriteLine($"\n>>   [Resta: Proceso] la resta {numero1} - {numero2} ha dado como resultado: {resultado}\n");
            Ends("Resta");
            return;
        }
        public static void Multiplicacion()
        {
            Console.WriteLine(">>   [Multiplicación: Entrada] ingresa el primer numero de la multiplicación");
            entrada1 = Console.ReadLine(); try
            {
                numero1 = int.Parse(entrada1);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Multiplicación: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Multiplicacion();
            }
            Console.WriteLine(">>   [Multiplicación: Entrada] ingresa el segundo numero de la multiplicación");
            entrada2 = Console.ReadLine(); try
            {
                numero2 = int.Parse(entrada2);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [Multiplicación: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Multiplicacion();
            }
            int resultado = numero1 * numero2;
            Console.WriteLine($"\n>>   [Multiplicación: Proceso] la multiplicación {numero1} * {numero2} ha dado como resultado: {resultado}\n");
            Ends("Multiplicación");
            return;
        }
        public static void Division()
        {
            Console.WriteLine(">>   [División: Entrada] ingresa el primer numero de la división");
            entrada1 = Console.ReadLine(); try
            {
                numero1 = int.Parse(entrada1);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [División: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Division();
            }
            Console.WriteLine(">>   [División: Entrada] ingresa el segundo numero de la división");
            entrada2 = Console.ReadLine(); try
            {
                numero2 = int.Parse(entrada2);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(">>   [División: Error] no se ha detectado ningun numero en lo escrito o el numero es demasiado grande");
                Division();
            }
            if (numero2 == 0)
            {
                Console.Clear();
                Console.WriteLine(">>   [División: Error] no puedes dividir un numero entre 0 ya que esta matematicamente incorrecto");
                Division();
            }
            else
            {
                int resultado = numero1 / numero2;
                Console.WriteLine($"\n>>   [División: Proceso] la división {numero1} / {numero2} ha dado como resultado: {resultado}\n");
                Ends("División");
                return;
            }
        }
        static void Main()
        {
            Console.WriteLine(">>   [Operaciones: Entrada] Escribe que tipo de operacion deseas realizar...\n>>   [Operaciones: Tipo] tienes entre 'suma', 'resta', 'multiplicación' y 'división'");
            string operacion = Console.ReadLine();
            switch (operacion.ToLower())
            {
                case "suma":
                    Suma();
                    break;
                case "resta":
                    Resta();
                    break;
                case "multiplicación":
                    Multiplicacion();
                    break;
                case "multiplicacion":
                    Multiplicacion();
                    break;
                case "división":
                    Division();
                    break;
                case "division":
                    Division();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($">>   {operacion} no es una operacion valida");
                    Program.Main();
                    break;
            }
        }
    }
}