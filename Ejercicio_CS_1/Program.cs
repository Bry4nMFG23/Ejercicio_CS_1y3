/*Programa que pida dos valores y luego imprima
por pantalla los resultados de estas operaciones:
 -Suma
 -Resta
 -Multiplicacion
 -Division
 -Raiz cuadrada de cada valor*/
using System; 


 void Operaciones(int a, int b) 
 {
    int Suma = a + b;
    Console.WriteLine($"La suma de {a} + {b} es: {Suma}");

    int Resta = a - b;
    Console.WriteLine($"La resta de {a} + {b} es: {Resta}");

    int Multiplicacion = a * b;
    Console.WriteLine($"La multiplicacion de {a} * {b} es: {Multiplicacion}");

    decimal Division = (decimal) a / b;
    Console.WriteLine($"La division de {a} y {b} es: {Division}");

    double RaizA = Math.Sqrt(a);
    double RaizB = Math.Sqrt(b);
    Console.WriteLine($"La raiz cuadrada de {a} es: {RaizA:F2}\nLa raiz cuadrada de {b} es: {RaizB:F2} ");

 }

 Operaciones(20, 40);
