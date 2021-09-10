using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaudemyy
{
    class Program
    {
        // EJERCICIO 1: Crear 3 variables numéricas con el valor
        // que tu quieras y en otra variable numérica guardar el valor 
        //  de la suma de las 3 anteriores. Mostrar por consola.
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;
            int num3 = 6;

            int suma = num1 + num2 + num3;

            Console.WriteLine("La suma de 2 + 4 +6 = " + suma);
            Console.ReadKey();
            // EJERCICIO 2: Pedir dos números al usuario por teclado y decir que número es el mayor
            int num4;
            int num5;
            string dato1;
            string dato2;

            Console.WriteLine("escribe un numero");
            dato1 = Console.ReadLine();
            num4 = Convert.ToInt32(dato1);
            Console.WriteLine("Escriba otro numero");
            dato2 = Console.ReadLine();
            num5 = Convert.ToInt32(dato2);

            if (num4 > num5)
            {
                Console.WriteLine("El numero mayor es: " + num4);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + num5);
            }
            Console.ReadKey();

            // EJERCICIO 3: Pedir el dia de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo

            int dia6 = 6;
            int dia7 = 7;
            string diaUsuario2;
            int finde;

            Console.WriteLine("Ingrese su dia de la semana");
            diaUsuario2 = Console.ReadLine();
            finde = Convert.ToInt32(diaUsuario2);
            if (finde == dia6 || finde == dia7)
            {
                Console.WriteLine("Hoy es fin de semana!! ");
            }
            else
            {
                Console.WriteLine("Hoy no es fin de semana :( ");
            }
            Console.ReadLine();

            // EJERCICIO 4: Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar 
            //(efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).

            double montoProducto;
            int metodoPago;
            string metodoPago2;
            string montoProducto2;
            int mEfectivo = 1;
            
            Console.WriteLine("Ingrese el monto del producto");
            montoProducto2 = Console.ReadLine();
            montoProducto = Convert.ToDouble(montoProducto2);

            Console.WriteLine("El monto del producto es de:$ " + montoProducto);
            Console.WriteLine("Ingrese el metodo de pago: PRESIONE 1 SI ES CON EFECTIVO Y 2 SI ES CON TARJETA");
            metodoPago2 = Console.ReadLine();
            metodoPago = Convert.ToInt32(metodoPago2);
            if (metodoPago == mEfectivo)
            {
                Console.WriteLine("Producto pagado exitosamente");

            }
            else
            {
                Console.WriteLine("Ingrese el numero de cuenta bancaria: ");
                Console.ReadLine();
                Console.WriteLine("Pago exitoso!");
            }

            Console.ReadKey();

            // EJERCICIO 5: Recorre los números del 1 al 100. Usa un bucle for.
            int numero = 0;
            for (int v = 1; v < 100; v++)
            {
                numero++;
                Console.WriteLine(numero);
            }

            Console.WriteLine("los numeros se recorrieron con bucle for exitosamente!");
            Console.ReadKey();

            // EJERCICIO 6:Recorre los números del 1 al 100. Usa un bucle while.

            int num = 0;

            while (num < 100)
            {
                num++;
                Console.WriteLine(num);
            }

            Console.WriteLine("los numeros se recorrieron con bucle while exitosamente! ");
            Console.ReadKey();

            // EJERCICIO 7: Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

            for (int f = 2; f <= 100; f = f + 2)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();

            //EJERCICIO 8: Recorre los números del 1 al 100. Muestra los números divisibles entre 3 o pares
            for (int f = 1; f < 101; f++)
            {
                if (f % 2 == 0 || f % 3 == 0)
                {
                    Console.WriteLine(f);
                }
            }
            Console.ReadKey();

            // EJERCICIO 9: Crea un array e inserta los números pares del 1 al 100 en ese array.

            int[] arrayInt = new int[50];
            int index = 0;

            for (int h = 1; h < 101; h++)
            {
                if (h % 2 == 0)
                {
                    arrayInt[index] = h;
                    index++;
                }

            }
            foreach (var numeroPar in arrayInt)
            {
                Console.WriteLine(numeroPar);
            }

            Console.ReadKey();
            // EJERCICIO 10: Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
            //iniciamos las variables, para ir sumando los valores
            int sumaPares = 0;
            int sumaImpares = 0;
            
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("Introduce un numero");
                var numerogg = Console.ReadLine();
                int numeroInts = int.Parse(numerogg);

                if (int.Parse(numerogg) % 2 == 0)
                {
                    sumaPares = sumaPares + numeroInts;
                }
                else
                {
                    sumaImpares = sumaImpares + numeroInts;
                }
            }

            Console.WriteLine($"Los pares suman {sumaPares}");
            Console.WriteLine($"Los impares suman {sumaImpares}");
            Console.ReadKey();

            //EJERCICIO 11: Crea un programa, que pida un número del 1 al 7, 
            //devuelva el día de la semana , teniendo en cuenta que el 1 es Lunes, hacer con un switch.


            Console.WriteLine("introduce un numero de 1 al 7");
            var numeroTT = Console.ReadLine();
            int numeroSemana = int.Parse(numeroTT);
            
            if (numeroSemana > 7 || numeroSemana < 1)
            {
                Console.WriteLine("El numero es incorrecto");
                Console.ReadKey();
            }
            else
            {
                switch (numeroSemana)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }


            //EJERCICIO 12:Crea un programa que pida por consola un numero del 1 al 1000 (validara que el numero introducido es correcto)
            //y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.
            int sumas2 = 0;


            Console.WriteLine("Introduce un numero del 1 al 1000");
            var numeroee = Console.ReadLine();
            int numeroInt = int.Parse(numeroee);


            if (numeroInt < 1 || numeroInt > 1000)
            {
                Console.WriteLine("Introduce un numero del 1 al 1000");
                Console.ReadKey();
            }
            for (int k = 1; k < numeroInt + 1; k++)
            {
                sumas2 = sumas2 + k;
            }

            Console.WriteLine($"La suma es {sumas2}");
            Console.WriteLine($"La media es {sumas2 / numeroInt}");
            Console.ReadKey();

            //EJERCICIO 13: Comprobar si un numero introducido por consola es primo

            int a = 0, i, numeror;
            Console.WriteLine("Ingrese numero");
            numeror = int.Parse(Console.ReadLine());

            for (i = 1; i < (numeror + 1); i++)
            {
                if (numeror % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("No es Primo");
            }
            else
            {
                Console.WriteLine("Si es Primo");
            }
            Console.ReadLine();

            //EJERCICIO 14: Crear un programa calcule cuantas cifras tiene un número entero positivo 
            // (pista: se puede hacer dividiendo varias veces entre 10).

            Console.WriteLine("introduce un numero");
            int numeroQ = int.Parse(Console.ReadLine());           
            float numeroDividido = numeroQ;           
            int numeroCifras = 0;

            while (numeroDividido > 1)
            {
                numeroDividido = numeroDividido / 10;
                numeroCifras++;
            }

            Console.WriteLine($"El numero tienen {numeroCifras} cifras");
            Console.ReadKey();

        }
    }

}
