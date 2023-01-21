using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDeEjercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio #4 Determine la raíz Cuadrada de un número cualquiera.
            /*int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n<=0);
            Console.WriteLine("La raiz cuadrada de {0} es: {1}",n,(Math.Pow(n,2)));
            */


            /*Ejercicio 5# Evaluar la Función Y= 5X^4 + 2X^3 + 3X^2 + 7 para el valor de 
            a)	X = 1;
            b)	X un número cualquiera.*/

            /*do
            {
                int x, y1, y2, y3, opc;
                String var;
                bool com;
                do
                {
                    Console.WriteLine("Seleccione una opcion");
                    Console.WriteLine("1.X=1");
                    Console.WriteLine("2.X es un numero cualquiera");
                    //Se valida la entrada de solo numeros con un TryParse
                    var = Console.ReadLine();
                    com = int.TryParse(var, out opc);
                    if (opc <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || opc <= 0 || opc > 3);

                switch (opc)
                {
                    case 1:
                        x = 1;
                        y1=5*Math
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }

            } while (true);*/

            //Ejercicio 6# Convertir N kilogramos a Libras.
            /*double kg, lb;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = double.TryParse(var, out kg);
                if (kg <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || kg <= 0);
            //la formula para pasar de kg a lb es 2.205
            lb = kg * 2.205;
            Console.WriteLine("{0} kg son iguales a {1} lb", kg, lb);
            */


            //Ejercicio 7# Convertir X grados Fahrenheit a grados Celsius. Celsius= 5/9 (Fahrenheit -32).
            /*double cels, fhnr;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese los grados Fahrenheit");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = double.TryParse(var, out fhnr);
                if (fhnr <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || fhnr <= 0);
            //el nueve y cinco deben ir como decimales porque si van como enteros C# lo tomara como una division entera dando cero
            cels =(fhnr - 32)*(5.0/ 9.0);
            Console.WriteLine("{0} grados fahrenheit son iguales a {1} grados celcius",fhnr, cels);
            */


            //Ejercicio 8# Calcular el área de un triangulo conociendo sus tres lados.
            //la formula es Raiz cuadrada de S(s-a)*(s-b)*(s-b), siendo S semiPerimetro
            /*double l1,l2,l3,p,s,a;
            String var1, var2, var3;
            bool com1, com2, com3;
            do
            {
                Console.WriteLine("Ingrese el lado uno");
                var1 = Console.ReadLine();
                com1= double.TryParse(var1, out l1);
                Console.WriteLine("Ingrese el lado dos");
                var2 = Console.ReadLine();
                com2= double.TryParse(var2, out l2);
                Console.WriteLine("Ingrese el lado tres");
                var3 = Console.ReadLine();
                com3= double.TryParse(var3, out l3);
                if (l1 <= 0 || l2 <=0 || l3<=0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com1 ||!com2 || !com3 || l1 <= 0 || l2 <= 0 || l3 <= 0);
            p = l1 + l2 + l3;
            s = p/2;
            a = s * ((s - l1) * (s - l2) * (s - l3)); ;
            Console.WriteLine("Perimetro:{0}, SemiPerimetro:{1}, Area{2}", p, s, Math.Sqrt(a));
            */


            //9# Calcular el volumen de un cilindro conociendo su radio y altura
            /*double r, h, v;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese el radio");
                var = Console.ReadLine();
                com = double.TryParse(var, out r);
                Console.WriteLine("Ingrese la altura");
                var = Console.ReadLine();
                com = double.TryParse(var, out h);
                if (r <= 0 || h<=0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || r <= 0 || h<=0);
            v = (Math.PI * Math.Pow(r, 2)) * h;
            Console.WriteLine("El volumen del cilindro es: " + v);
            */


            //10# Determine el valor de la fuerza de un cuerpo que tiene por masa “M” y aceleración “A”.
            /*double m,a;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la masa");
                var = Console.ReadLine();
                com = double.TryParse(var, out m);
                Console.WriteLine("Ingrese la aceleracion");
                var = Console.ReadLine();
                com = double.TryParse(var, out a);
                if (m <= 0 || a <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || m <= 0 || m <= 0) ;
            Console.WriteLine("Masa:{0}, Aceleracion:{1}, Fuerza:{2} ",m,a,(m*a));
            */


            // 11# Obtener el valor del Coseno de un número cualquiera



            //12# Obtener el promedio de N notas.
            /*double c, p;
            p = 0;
            int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la cantidad de notas");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Ingresa la nota {0}: ",i);
                c = double.Parse(Console.ReadLine());
                p = p + c;
                Console.WriteLine();
            }
            if (n == 0)
            {
                p = 0;
            }
            else
            {
                p = p / n;
            }
            Console.WriteLine("El promedio: " + p);
            */




            //13# Convertir Y yardas, F pies y I pulgadas a Centímetros.
            /*do
            {
                double i, f, p, cm; 
                int opc;
                String var;
                bool com;
                do
                {
                    Console.WriteLine("Seleccione una opcion");
                    Console.WriteLine("1.Yardas a entimetros");
                    Console.WriteLine("2.Pies a centimetros");
                    Console.WriteLine("3.Pulgadas a centimetros");
                    Console.WriteLine("4.Salir");
                    var = Console.ReadLine();
                    com = int.TryParse(var, out opc);
                    if (opc <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || opc <= 0 || opc > 4);

                switch (opc)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese las yardas");
                            var = Console.ReadLine();
                            com = double.TryParse(var, out f);
                            if (f <= 0)
                            {
                                Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                            }
                        } while (!com || f <= 0);
                        cm = f * 91.44;
                        Console.WriteLine("{0} yardas son igual a {1} centimetros", f, cm);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Ingrese los Pies");
                            var = Console.ReadLine();
                            com = double.TryParse(var, out p);
                            if (p <= 0)
                            {
                                Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                            }
                        } while (!com || p <= 0);
                        cm = p * 30.48;
                        Console.WriteLine("{0} Pies son igual a {1} centimetros", p, cm);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Ingrese las Pulgadas");
                            var = Console.ReadLine();
                            com = double.TryParse(var, out i);
                            if (i <= 0)
                            {
                                Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                            }
                        } while (!com || i <= 0);
                        cm = i * 2.54;
                        Console.WriteLine("{0} Pulgadas son igual a {1} centimetros", i, cm);
                        break;
                    case 4:
                        Console.WriteLine("Que tenga buen dia");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }

            } while (true);
            */



            //14.
            //15.
            //16.
            //17.
            //18. Leer un numero de 3 cifras e imprimirlo en orden invertido
            /*
            int n, i, d, u, c;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero de 3 Cifras");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n < 100 || n>999 )
                {
                    Console.WriteLine("No puede agregar numeros menores ni mayores de 3 cifras o letras");
                }
            } while (!com || n < 100 || n>999);
            c = n / 100;
            n = n % 100;
            d = n / 10;
            u = n % 10;
            i = (u * 100) + (d * 10) + c;
            Console.WriteLine("El numero invertido es: " + i);
            */



            //19 Escriba un programa que lea la edad de una persona e imprima es votante dado que tiene 16 o más años de edad.
            /*
            int edad;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese su edad");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = int.TryParse(var, out edad);
                if (edad <= 0 || edad > 90)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos, numeros mayores o letras");
                }else if (edad < 16)
                {
                    Console.WriteLine("Usted no puede votar, es menor de edad");
                }
                else
                {
                    Console.WriteLine("Es votante dado que tiene 16 o más años de edad, su edad es: "+edad);
                }
            } while (!com || edad <= 0 || edad>90);
            */



            //20 Escriba un programa que lea un número cualquiera e imprima si es par o impar.
            /*
            int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            if (n % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            */



            //21.	Escriba un programa que lea un número que verifique si X es negativo que calcule X^4 en caso contrario que calcule X^2.
            /*
            int x;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero X");
                var = Console.ReadLine();
                com = int.TryParse(var, out x);
                if (x == 0)
                {
                    Console.WriteLine("No puede agregar cero o letras");
                }
            } while (!com || x == 0);
            if (x > 0)
            {
                Console.WriteLine("X es positivo");
                Console.WriteLine("El valor de X es ahora: "+(Math.Pow(x,2)));
            }
            else
            {
                Console.WriteLine("X es negativo");
                Console.WriteLine("El valor de X es ahora: " + (Math.Pow(x, 4)));
            }
            */




            //22.	Escribir un programa para calcular el interés de una capital conforme a la siguiente condición.
            //Si el capital prestado es mayor que 10,000 dólares entonces la tasa es del 7% en caso contrario del 6% , debe imprimir el capital y su interés.*/


            //23  Escribir un programa que lea la calificación de un alumno e imprima el mensaje de aprobado si su calificación es mayor o igual a 60, en caso contrario imprima reprobado.
            /*
            int nt;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la nota");
                var = Console.ReadLine();
                com = int.TryParse(var, out nt);
                if (nt < 0 || nt>100 || !com)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos, mayores de 100 o letras");
                }
            } while (!com || nt < 0 || nt>100);
            if (nt >= 60)
            {
                Console.WriteLine("Su nota es {0}, usted esta aprobado",nt);
            }
            else
            {
                Console.WriteLine("Su nota es {0}, usted esta reprobado",nt);
            }
            */




            //24 Escriba un programa que lea un numero A, si A es un número positivo calcule Y=2^A, si es negativo calcule Y=A+5 imprimir el resultado de Y.
            /*
            int A;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese el Numero A");
                var = Console.ReadLine();
                com = int.TryParse(var, out A);
                if (A == 0 || !com)
                {
                    Console.WriteLine("No puede agregar cero o letras");
                }
            } while (!com || A == 0);
            if (A > 0)
            {
                Console.WriteLine("A es igual:{0}, asi que Y es igual:{1}",A,(Math.Pow(2,A)));
            }
            else
            {
                Console.WriteLine("A es igual:{0}, asi que Y es igual:{1}", A, (A+5));
            }
            */


            //25 Escribir un programa que lea un número cualquiera e imprima si el número leído es divisible por tres.
            /*
            int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            if(n%3 == 0)
            {
                Console.WriteLine("El numero {0} si es divisible entre 3",n);
            }
            */




            //26 Escriba un programa independiente para cada inciso considerando una lectura de distintos números tal como se detallan a continuación. 
            //a) XY    b) XYZ     c) XYZW



            //27 Unos pantalones se venden a 10 dólares cada uno si se compran más de tres, 12 dólares en los demás casos, estructure un programa que lea un número de entrada de pantalones comprados e imprima el costo total.




            //28 Escriba un programa que lea dos números enteros como entrada y escriba el mensaje signos opuestos si y solo si uno de los enteros es positivo y el otro negativo.



            //29 Escriba un programa que lea dos números enteros positivos distintos y escriba la diferencia entre el mayor y el menor.
            //Asegúrese que su programa escriba por ejemplo 8 si los números son 10 y 2 o bien 2 y 10.
            /*
            int n1, n2;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero positivo");
                var = Console.ReadLine();
                com = int.TryParse(var, out n1);
                Console.WriteLine("Ingrese un segundo numero positivo");
                var = Console.ReadLine();
                com = int.TryParse(var, out n2);
                if (n1 <= 0 || n2 <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n1 <= 0 ||n2<=0);
            if (n1 < n2)
            {
                Console.WriteLine("La diferencia entre {0} y {1} es igual a: {2}", n1, n2, (n2-n1));
            }
            else
            {
                Console.WriteLine("La diferencia entre {0} y {1} es igual a: {2}", n1, n2, (n1 - n2));
            }
            */




            //30.	Escriba un programa que tenga como entrada la lectura de dos números llamados “X” y “Y” y que imprima una salida que corresponda a cada uno de los pares.
            /*a)	(-X, -Y) Entonces sumar los cuadrados de cada componente.
              b)	(-X, Y) Entonces restar al valor Y el valor de X.
              c)	(X, -Y) Entonces dividir X entre Y
              d)	(X, Y) Entonces verificar si X es mayor que Y, si es así sumarle a X el valor de Y, si no obtener la raíz cuadrada de X.
             */
            /*double X, Y, Z;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese X");
                var = Console.ReadLine();
                com = double.TryParse(var, out X);
                Console.WriteLine("Ingrese Y");
                var = Console.ReadLine();
                com = double.TryParse(var, out Y);
                if (X == 0 || Y == 0)
                {
                    Console.WriteLine("No puede agregar cero o letras");
                }
            } while (!com || X == 0 || Y == 0);
            if (X<0 && Y<0)
            {
                Z = Math.Pow(X, 2)+ Math.Pow(Y, 2);
                Console.WriteLine("Dado que X={0} y Y={1} son negativos, la suma de los cuadrados de los componentes es: {2}", X, Y, Z);
            }else if (X<0 && Y>0)
            {
                Z = X-Y;
                Console.WriteLine("Dado que X={0} es negativo y Y={1} es positivo, entonces la resta del valor Y con el valor de X es: {2}", X, Y, Z);
            }else if (X>0 && Y<0)
            {
                Z= (X/Y);
                Console.WriteLine("Dado que X={0} es positivo y Y={1} es negativo, entonces la division entre X & Y es: {2}", X, Y, Z);
            }else if (X>0 && Y>0)
            {
                if (X>Y)
                {
                    Z = X + Y;
                    Console.WriteLine("Dado que X={0} y Y={1} son positivos y X es mayor que Y, la suma de los componentes es: {2}", X, Y, Z);
                }
                else
                {
                    Z = Math.Sqrt(X);
                    Console.WriteLine("Dado que X={0} y Y={1} son positivos y X es menor que Y, la raiz cuadrada de X es: {2}", X, Y, Z);
                }

            }
            */




            //31.	UN triangulo es equilátero si posee sus tres lados iguales, es Isósceles si tiene solamente dos lados iguales y
            //es escaleno cuando todos sus lados son desiguales.
            //Escribir un programa que lea las dimensiones de los lados del triángulo y presente como salida el mensaje de su clasificación de triangulo.
            /*int l1,l2,l3;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese lado 1");
                var = Console.ReadLine();
                com = int.TryParse(var, out l1);
                Console.WriteLine("Ingrese lado 2");
                var = Console.ReadLine();
                com = int.TryParse(var, out l2);
                Console.WriteLine("Ingrese lado 3");
                var = Console.ReadLine();
                com = int.TryParse(var, out l3);
                if (l1<= 0 || l2<=0 || l3<=0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || l1 <= 0 || l2<= 0 || l3<=0 );
            if (l1==l2 && l2==l3 && l3==l1)
            {
                Console.WriteLine("Los lados forman un triangulo equilatero");
            }else if ( l1==l3 || l2==l1 || l3==l2)
            {
                Console.WriteLine("Los lados forman un triangulo Isoceles");
            }else if( l1 != l2 && l2!=l3 && l3 != l1)
            {
                Console.WriteLine("Los lados forman un triangulo Escaleno");
            }
            */





            //32.	Las calificaciones de los alumnos en un instituto son consideradas de la siguiente forma:
            /*a)	A es 90 o más.
            b)	B es al menos 80 pero menos de 90.
            c)	C es al menos 70 pero menos de 80.
            d)	D es al menos 65 pero menos de 70.
            e)	E es menos de 65.
            Escriba un programa que considere la entrada de nota en número e imprima su codificación en letra.*/
            /*int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la nota");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            if (n>=90)
            {
                Console.WriteLine("Usted tiene una nota de {0} que es una nota A",n);
            }else if (n>=80 && n<90)
            {
                Console.WriteLine("Usted tiene una nota de {0} que es una nota B", n);
            }else if(n >= 70 && n < 80)
            {
                Console.WriteLine("Usted tiene una nota de {0} que es una nota C", n);
            }
            else if (n >= 65 && n < 70)
            {
                Console.WriteLine("Usted tiene una nota de {0} que es una nota D", n);
            }
            else if (n < 65)
            {
                Console.WriteLine("Usted tiene una nota de {0} que es una nota E", n);
            }
            */





            //33. Escriba un programa que imprima los números del 1 al 100.
            /*for(int n=0; n<100; n++)
            {
                Console.Write("" + (n+1) + "-");
            }
            Console.Write("Fin");
            */



            //34. Escriba un programa que lea “n” números enteros y que los imprima.
            /*int n,m;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros a imprimir");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (int i=0; i<n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}",(i+1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m <= 0);
                Console.WriteLine("El numero {0} es: {1}", (i+1), m);
            }
            */





            //35 Escriba un programa que lea tres números cualesquiera y que calcule la suma de ellos y su promedio.
            /*double n, suma, sumaActual;
            String var;
            bool com;
            suma = 0;
            sumaActual = 0;
            for(int i=0; i<3; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}",(i+1));
                    var = Console.ReadLine();
                    com = double.TryParse(var, out n);
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || n <= 0);
                sumaActual = n;
                suma = suma + sumaActual;


            }
            Console.WriteLine("La suma de los numeros ingresados es: " + suma);
            */





            //36 Escriba un programa que lea “n” números que calcule su suma y su promedio.
            /*double n, m, suma, sumaActual, promedio;
            String var;
            bool com;
            suma = 0;
            sumaActual = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros");
                var = Console.ReadLine();
                com = double.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for ( i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}", (i + 1));
                    var = Console.ReadLine();
                    com = double.TryParse(var, out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m <= 0);
                sumaActual = m;
                suma = suma + sumaActual;
                

            }
            promedio = suma / n;
            Console.WriteLine("La suma de los numeros ingresados es: " + suma);
            Console.WriteLine("El promedio de la suma es: " + promedio);
            */




            //37 Escriba un programa que tenga como entrada “n” números enteros y que calcule el número de números pares e impares.
            /*int n, m, Cpar, Cimpar;
            String var;
            bool com;
            int i = 0;
            Cpar = 0;
            Cimpar = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}", (i + 1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m <= 0);
                if (m % 2 == 0)
                {
                    Cpar = Cpar + 1;
                }
                else
                {
                    Cimpar = Cimpar + 1;
                }

            }
            Console.WriteLine("Ingreso {0} numeros pares", Cpar);
            Console.WriteLine("Ingreso {0} numeros impares", Cimpar);
            */




            //39 Escriba un programa que lea las notas de “N” alumnos y calcule cuantos aprobados y desaprobados hay (está aprobado si la nota es mayor de 60).
            /*int n, m, CAprobados, CDesaprobados;
            String var;
            bool com;
            int i = 0;
            CAprobados = 0;
            CDesaprobados = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de Estudiantes a evaluar");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese la nota del estudiante {0}", (i + 1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m <= 0 || m>100);
                if (m>=60)
                {
                    CAprobados = CAprobados + 1;
                }
                else
                {
                    CDesaprobados = CDesaprobados + 1;
                }

            }
            Console.WriteLine("Hay {0} estudiantes aprobados", CAprobados);
            Console.WriteLine("Hay {0} estudiantes desaprobados", CDesaprobados);
            */



            //40.	Escribir un programa que calcule la factorial de un número entero.
            /*3 != 1’ 2’ 3’= 6
              5 != 1’ 2’ 3’ 4’ 5’= 120*/
            /*
            int n, z;
            String var;
            bool com;
            z = 1;
            do
            {
                Console.WriteLine("Ingrese un numero");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            if (n == 0 || n == 1)
            {
                Console.WriteLine(" " + 1);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    z = z * i;
                }
            }
            Console.WriteLine("El factorial es: " + (z));
            */



            //41 Calcule e imprima el producto de “N” números
            /*
            int n, num, prod, x;
            String var;
            bool com;
            num = 1;
            prod = 0;
            
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros"); 
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}", (i + 1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out x);
                    if (x <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || x <= 0);
                num = num * x ;
                prod=num;


            }
            Console.WriteLine("El producto de los numeros es " + prod);
            */





            //42 Leer “N” números distintos de 0, si el número leído es positivo súmelo en caso contrario cuéntelo.
            /*
            int n, m, CPositivos, CNegativos, suma;
            suma = 0;
            String var;
            bool com;
            int i = 0;
            CPositivos = 0;
            CNegativos = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for (i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}", (i + 1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out m);
                    if (m == 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m == 0);
                if (m >= 0)
                {
                    suma = m;
                    CPositivos = CPositivos + suma;
                }
                else
                {
                    CNegativos = CNegativos + 1;
                }

            }
            Console.WriteLine("La suma de los numeros positivos es: "+CPositivos);
            Console.WriteLine("Hay {0} numeros negativos", CNegativos);
            */



            //43.	En un curso de 25 alumnos se practican 3 exámenes los datos de cada estudiante se registran así: Nombre, Nota1, Nota2, Nota3.
            //Escriba un programa que calcule por cada estudiante el promedio de las notas.
            /*
            for (int i=0; i < 25; i++)
            {
                String nombre;
                double nota1, nota2, nota3, prom;
                String var;
                bool com;
                do
                {
                    Console.WriteLine("Escriba el nombre del estudiante");
                    nombre=Console.ReadLine();
                    Console.WriteLine("Ingrese un numero");
                    var = Console.ReadLine();
                    com = double.TryParse(var, out nota1);
                    Console.WriteLine("Ingrese un numero");
                    var = Console.ReadLine();
                    com = double.TryParse(var, out nota2);
                    Console.WriteLine("Ingrese un numero");
                    var = Console.ReadLine();
                    com = double.TryParse(var, out nota3);
                    if (nota1 <0 || nota2<0 || nota3<0)
                    {
                        Console.WriteLine("No puede agregar letras, numeros negativos o numeros mayores a 100");
                    }
                } while (!com || nota1<0 || nota2<0 || nota3<0);
                prom = (nota1 + nota2 + nota3) /3;
                Console.WriteLine("Estudiante {0}, Nota 1: {1}, Nota 2: {2}, Nota 3: {3}, Promedio: {4}",nombre,nota1,nota2,nota3,prom);
            }
            */




            //44 Dada la edad de una persona
            //escriba un programa que imprima
            //“niño” si la edad es menor que 13
            //“joven” si la edad es mayor que 13 y menor o igual 25 y
            //“adulto” si la edad es mayor que 25.
            /*
            int edad;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese la edad de alguien");
                var = Console.ReadLine();
                com = int.TryParse(var, out edad);
                if (edad <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || edad <= 0);
            if (edad < 13)
            {
                Console.WriteLine("Usted tiene {0} años, usted es un niño", edad);
            }
            else if (edad >= 13 && edad <= 25)
            {
                Console.WriteLine("Usted tiene {0} años, usted es un joven", edad);
            }
            else if (edad > 25)
            {
                Console.WriteLine("Usted tiene {0} años, usted es un adulto", edad);
            }
            */





            //45 De una lista de n voltajes escriba el programa que calcule el voltaje mínimo, el voltaje máximo y el promedio de todos.


            //50 Escribir un programa para averiguar todos los divisores de un número digitado por el usuario.
            /*int n;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                //Se valida la entrada de solo numeros con un TryParse
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            for(int i = 1; i < n; i++)
            {
                if (n % i ==0)
                {
                    Console.WriteLine("{0} es divisor de {1}",n,i);
                }
            }
            */



            //51 Diseñar un programa para averiguar su un número digitado por el usuario es primo.
            /*int n, x, y, resi;
            x = 2;
            y = 0;
            String var;
            bool com;
            do
            {
                Console.WriteLine("Ingrese un numero");
                var = Console.ReadLine();
                com = int.TryParse(var, out n);
                if (n <= 0)
                {
                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                }
            } while (!com || n <= 0);
            while (x < n && y == 0)
            {
                resi = n % x;
                if (resi == 0)
                {
                    y = 1;
                }
                else
                {
                    x = x + 1;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("El numero {0} es numero primo",n);
            }
            else
            {
                Console.WriteLine("El numero {0} no es un numero primo",n);
            }
            */




            //52 Leer 20 números desde el teclado y obtener cuantos son positivos, negativos e iguales a cero.
            /*int n, sumaP, sumaNE, sumaZR, x;
            String var;
            bool com;
            sumaP = 0;
            sumaNE = 0;
            sumaZR = 0;
            x = 0;
            for (int i=0; i<25; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}",(i+1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out n);
                    if (!com)
                    {
                        Console.WriteLine("No puede agregar letras");
                    }
                } while (!com);
                if(n > 0)
                {
                    sumaP = sumaP + 1;
                }
                else if (n < 0)
                {
                    sumaNE = sumaNE + 1;
                }
                else
                {
                    sumaZR = sumaZR + 1;
                }
            }
            Console.WriteLine("Hay {0} numeros positivos", sumaP);
            Console.WriteLine("Hay {0} numeros negativos", sumaNE);
            Console.WriteLine("Hay {0} ceros", sumaZR);
            */



            //53 Leer 20 números desde el teclado y averiguar la suma de los números pares e impares.
            /*int m, Cpar, Cimpar, sumaActual;
            String var;
            bool com;
            Cpar = 0;
            Cimpar = 0;
            for(int i=0; i<20; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero {0}", (i + 1));
                    var = Console.ReadLine();
                    com = int.TryParse(var, out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com || m <= 0);
                if (m % 2 == 0)
                {
                    sumaActual = m;
                     Cpar = Cpar + sumaActual;
                }
                else
                {
                    sumaActual = m;
                    Cimpar= Cimpar + sumaActual;
                }

            }
            Console.Clear();
            Console.WriteLine("Ingreso {0} numeros pares", Cpar);
            Console.WriteLine("Ingreso {0} numeros impares", Cimpar);
            */




            //54 Elaborar un programa que permita leer N números desde el teclado y calcule la media aritmética(promedio).
            /*int n;
            Console.WriteLine("Ingrese la cantidad de numeros");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Numero {0} ", (i + 1));
                vector[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Lista de numeros [");
            for (int i = 0; i < n; i++)
            {

                Console.Write(" "+vector[i]+ " ");
            }
            Console.Write("] ");
            int sumatoria = 0;
            for (int x = 0; x < n; x++)//Sumar datos
            {
                int numeroActual = vector[x];
                sumatoria = sumatoria + numeroActual;
            }
            Console.WriteLine(" ");
            Console.WriteLine("La media aritmetica es: {0}", (sumatoria/n));
            */




            //57 Dado un número determinar la suma de sus dígitos.
            /*String numeros;
            Console.WriteLine("Escriba una serie de numeros");
            numeros = Console.ReadLine();
            char[] ListaNum = numeros.ToCharArray();


            int suma = 0;
            foreach (char numero in ListaNum
                )
            {
                Console.WriteLine("Escriba un numero: "+numero);
                suma += int.Parse(numero.ToString());
            }

            Console.WriteLine("suma:  " + suma);
            */

            //59 Escribir un programa para averiguar si un número digitado por el usuario es perfecto.
            //Un numero es perfecto si la suma de sus divisores distintos de el mismo es igual a este. Ejemplo: 6= 1+2+3.
            /*int i, suma = 0, n;
            Console.WriteLine("Introduce un número: ");
            n =int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {                              
                if (n % i == 0)
                {
                    suma = suma + i; 
                }
            }
            if (suma == n)
            {                         
                Console.WriteLine("Perfecto");
            }
            else
            {
                Console.WriteLine("No es perfecto");

            }
            */

            //60 Elaborar un programa adivinanza.
            //Este programa preguntará ¿Cuál es la capital del folclore nicaragüense?
            //El usuario tendrá tres oportunidades de responder, si el usuario acierta antes de la tercera posibilidad
            //el programa le informara de su acierto si no acertara en ninguna el programa posteriormente suministrará la respuesta.
            /*int cont, comprobar;
            string resp;
            comprobar = 0; cont = 0;
            do
            {
                Console.WriteLine("¿Cuál es la capital del folclore nicaragüense?");
                Console.Write("Escriba su respuesta: "); 
                resp = Console.ReadLine();
                if ((resp.ToUpper() == "MASAYA"))
                {
                    comprobar = 1;
                    break;
                }
                else
                {
                    cont++;
                }
            } while (((cont < 3)));
            if (comprobar == 1)
            {
                Console.WriteLine("Correcto! La respuesta es: " + resp);
            }
            else
            {
                Console.WriteLine("No hay mas oportunidades");
            }
            */




            //61 Elabore un programa que calcule los 20 primeros números de la serie de Fibonacci: 0,1,1,2,3,5,8,13,
            //Esta serie empieza con 0 y 1 y tiene la propiedad que cada número Fibonacci subsecuente es la suma de dos números Fibonacci previos.
            /*
            int A, B, C, CAN, K;
            CAN = 20;
            A = 0; B = 1;
            Console.Write("Serie de Fibonacci: ");
            Console.Write(A + " " + B + " ");
            for (K = 3; K <= CAN; K++)
            {
                C = A + B;
                Console.Write(C + " ");
                //Se hace un intercambio de valores
                A = B;
                B = C;
            }
            */


            //62.	Escriba un programa que encuentre los primeros tres números perfectos.
            //Un número perfecto es un número entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluidos el mismo) que son divisores del número.
            //El primer número es 6 ya que los divisores de 6 son 1,2,3 y 1+2+3=6
            int b, s, a;
            for(int i=2; i<=500; i++)
            {
                b = 0;
                s = i / 2;
                for(int j=1; j<=s; j++)
                {
                    if((i%j) == 0)
                    {
                        b = b + j;
                    }
                }
                if (b == i)
                {
                    Console.WriteLine("El numero perfecto es: " + i);
                }
            }

            Console.ReadKey();
        }
    }
}
