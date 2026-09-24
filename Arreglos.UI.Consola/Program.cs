using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

MiArreglo oMiArreglo = new MiArreglo(10);   //tamaño fisico
oMiArreglo.Llenar(1, 20);      //Tamaño logico
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado (ascendente): ");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado (descendente): ");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);
//Console.WriteLine(oMiArreglo.EstaVacio);