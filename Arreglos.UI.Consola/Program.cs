using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

MiArreglo oMiArreglo = new MiArreglo(100);   //tamaño fisico
oMiArreglo.Llenar(1, 20);      //Tamaño logico
Console.WriteLine(oMiArreglo);
//Console.WriteLine(oMiArreglo.EstaVacio);