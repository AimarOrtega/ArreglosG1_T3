using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;
        //Constructor
        public MiArreglo(int n) //recibe tamanio
        {
            N = n;
            _arreglo = new int[N];      //al no darle setter no se puede cambiar el tamaño, esto se debe proteger
            _tope = 0;
        }

        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;
        //Metodos
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for(int i = 0; i<N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;  //reescalar el tope al tamaño del arreglo
        }

        //Metodo ToString
        public override string ToString()
        {
            if(EstaVacio)
            {
                return "Arreglo vacio";
            }


            string cadena = string.Empty;       //limpiar cadena vacia
            int contador = 0; 
            for (int i = 0; i < _tope; i++)
            {
                cadena += $"{_arreglo[i]}\t";    //concatenar los elementos del arreglo
                contador++;
                if (contador > 9)
                {
                    contador = 0;      //reiniciar el contador
                    cadena += "\n";      //salto de linea cada 10 elementos
                }
            }
            return cadena;
        }
    }
}
