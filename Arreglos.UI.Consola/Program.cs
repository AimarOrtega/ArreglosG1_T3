using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

//MiArreglo oMiArreglo = new MiArreglo(5);   //tamaño fisico
MiArreglo oMiArreglo = new MiArreglo(50000);   //tamaño fisico

try
{
	Console.WriteLine("\nArreglo\n");
    var tiempo1 = DateTime.Now;
	oMiArreglo.Llenar(1, 999999);
    Console.WriteLine(oMiArreglo);
	var tiempo2 = DateTime.Now;

    var restaTiempo = tiempo2 - tiempo1;

    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos.");
	Console.ReadKey();

    /*
	Console.WriteLine("\nPares\n");
	var verPares = oMiArreglo.ObtenerPares();
	Console.WriteLine(verPares);        //tostring
	Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
	verPares.Ordenar(true);			//false desendente, true ascendente
    Console.WriteLine(verPares);        //tostring
    Console.ReadKey();
    */

    //primos
    Console.WriteLine("\nPrimos\n");
    var tiempo3 = DateTime.Now;                 //* tarea
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);        //tostring
    var tiempo4 = DateTime.Now;         //* tarea

    var restaTiempo2 = tiempo4 - tiempo3;   //* tarea

    Console.WriteLine($"\nTiempo transcurrido para obtener primos: {restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos."); //* tarea


    Console.ReadKey();

    Console.WriteLine("\nPrimos ordenados\n");
    var tiempo5 = DateTime.Now;
    verPrimos.Ordenar(true);			//false desendente, true ascendente
    Console.WriteLine(verPrimos);        //tostring
    var tiempo6 = DateTime.Now;
    var restaTiempo3 = tiempo6 - tiempo5;
    Console.WriteLine($"\nTiempo transcurrido para ordenar primos ascendentemente: {restaTiempo3.Minutes} minutos, {restaTiempo3.Seconds} segundos, {restaTiempo3.Milliseconds} milisegundos, {restaTiempo3.Nanoseconds} nanosegundos."); //* tarea

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
