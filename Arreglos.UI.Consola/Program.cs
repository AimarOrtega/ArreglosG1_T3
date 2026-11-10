using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

//MiArreglo oMiArreglo = new MiArreglo(5);   //tamaño fisico
MiArreglo oMiArreglo = new MiArreglo(100);   //tamaño fisico

try
{
	Console.WriteLine("\nArreglo\n");
	oMiArreglo.Llenar();
	Console.WriteLine(oMiArreglo);
	Console.ReadKey();


	Console.WriteLine("\nPares\n");
	var verPares = oMiArreglo.ObtenerPares();
	Console.WriteLine(verPares);        //tostring
	Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
	verPares.Ordenar(true);			//false desendente, true ascendente
    Console.WriteLine(verPares);        //tostring
    Console.ReadKey();

    //primos
    Console.WriteLine("\nPrimos\n");
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);        //tostring
    Console.ReadKey();

    Console.WriteLine("\nPrimos ordenados\n");
    verPrimos.Ordenar(true);			//false desendente, true ascendente
    Console.WriteLine(verPrimos);        //tostring
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
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
    /*
try
{
	oMiArreglo.Agregar(7);
	oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);
    oMiArreglo.Agregar(7);
	oMiArreglo.Agregar(-2);
	oMiArreglo.Agregar(7);
    Console.WriteLine(oMiArreglo);
    Console.ReadKey();
	oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

	Console.WriteLine("Eliminar 500 en posicion 1: ");
	Console.ReadKey();
	oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);

}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
	*/
