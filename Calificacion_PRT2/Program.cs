using System;
using System.Collections.Generic;

void IngresarEstudiante(){
    Console.WriteLine("Ingrese la cantidad de estudiantes: ");
    int estudiantes = int.Parse(Console.ReadLine()!);

    string datos = "";
    List<string> ListaA = new List<string>();
    List<string> ListaB = new List<string>();
    List<string> ListaC = new List<string>();
    List<string> ListaF = new List<string>();

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

        //Aqui guarda el promedio en letra
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
        //========================================================================================

        //Almacena las letras en la lista
        if (letra == "A"){
            ListaA.Add($"{nombre} {apellido}");
        }
        else if(letra == "B"){
            ListaB.Add($"{nombre} {apellido}");
        }
        else if(letra == "C"){
            ListaC.Add($"{nombre} {apellido}");
        }
        else{
            ListaF.Add($"{nombre} {apellido}");
        }
        //=========================================================================================================================

        datos += ($"{nombre, -12} {apellido, -12} {nota1, -8} {nota2, -8} {nota3, -8} {nota4, -8} {promedio, -10} {letra, -14}\n");
       
    }     
        Console.WriteLine($"\n<------------------Colegio Dios es bueno.------------------>");
        Console.WriteLine("\t  Calificaciones del cuatrimestre");
        Console.WriteLine($"============================================================");
        Console.WriteLine($"{"nombre",-12} {"apellido",-12}  {"nota1",-8} {"nota2",-8} {"nota3",-8} {"nota4",-8} {"promedio",-10}  {"calificacion",-14}");
        Console.WriteLine(datos);
        Console.WriteLine($"\nLos estudiantes que sacaron A son: {ListaA.Count}\n {string.Join(", ", ListaA)}.");
        Console.WriteLine($"\nLos estudiantes que sacaron B son: {ListaB.Count}\n {string.Join(", ", ListaB)}.");
        Console.WriteLine($"\nLos estudiantes que sacaron C son: {ListaC.Count}\n {string.Join(", ", ListaC)}.");
        Console.WriteLine($"\nLos estudiantes que reprobaron son: {ListaF.Count}\n {string.Join(", ", ListaF)}.");
        
        
}




IngresarEstudiante(); 

