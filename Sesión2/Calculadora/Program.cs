using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
            do
            {
                int valor1 = 0; //Aqui se almacenara el primer valor ingresado.
                int valor2 = 0; //Aqui se almacenara el segundo valor ingresado.
                string Val1;
                string Val2;
                int R = 0; //Aqui se almacenara el resultado de la operacion.
                bool EsNum = false;

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("Elija Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                int ValorNum;
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("Ingrese sus dos numeros");
                while (EsNum == false)
                {
                    Console.Write("Valor1: ");
                    Val1 = Console.ReadLine();
                    EsNum = int.TryParse(Val1, out ValorNum);

                    if (EsNum)
                    {
                        valor1 = ValorNum;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es válido");
                    }
                }

                EsNum = false;

                while (EsNum == false)
                {

                    Console.Write("Valor2: ");
                    Val2 = Console.ReadLine();
                    EsNum = int.TryParse(Val2, out ValorNum);

                    if (EsNum)
                    {
                        valor2 = ValorNum;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es válido");
                    }

                }
                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/":

                        try
                        {
                            Console.WriteLine("El resultado de la division es:");
                            R = valor1 / valor2;
                            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("División entre 0 no permitida");
                        }

                        break;
                }
                Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s");
        }
    }
}
