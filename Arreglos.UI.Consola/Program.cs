using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

MiArreglo oMiArreglo = new MiArreglo(5);   //tamaño fisico
/*oMiArreglo.Llenar(1, 20);      //Tamaño logico
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo desordenado:" );
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado (ascendente): ");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado (descendente): ");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);*/
//Console.WriteLine(oMiArreglo.EstaVacio);
try
{
	oMiArreglo.Agregar(7);
	oMiArreglo.Agregar(-2);
	/*oMiArreglo.Agregar(7);
	oMiArreglo.Agregar(-2);
	oMiArreglo.Agregar(7);
	*/
	Console.WriteLine(oMiArreglo);
    Console.ReadKey();
	oMiArreglo.Insertar(500, 20);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
Console.WriteLine(oMiArreglo);