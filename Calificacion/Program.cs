/*El colegio “Dios es bueno” necesita obtener la lista de las calificaciones de los estudiantes.
Para esto deberá escribir un programa c# que obtenga los nombres  de los estudiantes y las calificaciones.

                                            Colegio Dios es bueno.
                                        Calificaciones del cuatrimestre
                    ==========================================================
                Nombre  Apellido  Nota1  Nota2 Nota3 Nota4 Promedio Literal
                    ===========================================================
                 Ramona Diaz        80      80  80      80      80      B 
                 Juan   Ruiz        90      90  90      90      90      A
                Andrea  Lao         60      60  60      60      60      F
Nota: Para el literal: 
Promedio > 90 <100 = A
Promedio > 80 <90 = B
Promedio >70 <80 = C
Promedio <70 = D

El programa debe solicitar los datos de forma continua hasta que el usuario determine que ya no desea ingresar más datos.
*/
using System;

void IngresarEstudiante(){
    Console.WriteLine("Ingrese la cantidad de estudiantes: ");
    int estudiantes = int.Parse(Console.ReadLine()!);

    string datos = "";
    for (int i = 0; i < estudiantes; i++ ){
        
        Console.WriteLine($"\nEscriba el nombre del estudiante {i + 1}: ");
        string nombre = Console.ReadLine()!;

        Console.WriteLine("Escriba el apellido del estudiante: ");
        string apellido = Console.ReadLine()!;

        Console.WriteLine("Digite la nota 1: ");
        int nota1 = int.Parse(Console.ReadLine())!;

        Console.WriteLine("Digite la nota 2: ");
        int nota2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite la nota 3: ");
        int nota3 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite la nota 4: ");
        int nota4 = int.Parse(Console.ReadLine()!);

        int promedio = (nota1 + nota2 + nota3 + nota4) / 4;

        string letra = "";
        if(promedio >= 90 && promedio <= 100){
            letra = "A";
        }
        else if(promedio >= 80 && promedio <= 90){
            letra = "B";
        }
        else if(promedio >= 70 && promedio <= 80){
            letra = "C";
        }
        else{
            letra = "F";
        }

        datos += ($"{nombre, -12} {apellido, -12} {nota1, -8} {nota2, -8} {nota3, -8} {nota4, -8} {promedio, -10} {letra, -14}\n");
       /* Console.WriteLine($"\n------------------Colegio Dios es bueno.------------------");
        Console.WriteLine("\t Calificaciones del cuatrimestre");
        Console.WriteLine($"\t================================================");
        Console.WriteLine("\n\tnombre\tapellido\tnota1\tnota2\tnota3\tnota4\tpromedio\tcalificacion");
        Console.WriteLine($"\t{nombre}\t{apellido}\t{nota1}\t{nota2}\t{nota3}\t{nota4}\t{promedio}\t{letra}");*/
    }     
        Console.WriteLine($"\n<------------------Colegio Dios es bueno.------------------>");
        Console.WriteLine("\t  Calificaciones del cuatrimestre");
        Console.WriteLine($"============================================================");
        Console.WriteLine($"{"nombre",-12} {"apellido",-12}  {"nota1",-8} {"nota2",-8} {"nota3",-8} {"nota4",-8} {"promedio",-10}  {"calificacion",-14}");
        Console.WriteLine(datos);
}

IngresarEstudiante(); 