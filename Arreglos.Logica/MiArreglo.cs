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

        //Metodo agregar
        public void Agregar(int numero)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;
        }

        //Merodo insertar
        public void Insertar(int numero, int posicion) 
        { 
            if(EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }

            if (posicion < 0) { 
                posicion = 0;
            }
            if (posicion > _tope) { 
                posicion = _tope;
            }

            for(int i = _tope; i>posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1]; //desplazar elementos de derecha a izquierda
            }
            _arreglo[posicion] = numero; //insertar el numero en la posicion
            _tope++; //incrementar el tope

        }

        public void Eliminar(int posicion) 
        {
            if(EstaVacio)
            {
                throw new Exception("El arreglo esta vacio");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1]; //desplazar elementos de izquierda a derecha
            }
            _tope--; //decrementar el tope
        }

        //Metodo ToString
        public override string ToString()
        {
            if(EstaVacio)
            {
                return "esta vacio";
            }


            string cadena = string.Empty;       //limpiar cadena vacia
            int contador = 0; 
            for (int i = 0; i < _tope+1; i++)
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
