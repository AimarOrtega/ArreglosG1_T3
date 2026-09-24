using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;   // tamaño logico 
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
        //Metodo ordenar (burbuja)
        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i<_tope-1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j]) //orden ascendente
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j]) //orden descendente
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

        //SOBRECARGA DE METODO ORDENAR
        public void Ordenar()
        {
            Ordenar(true); //llama al metodo ordenar con parametro ascendente
        }

        //Metodo cambiar
        private void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
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
