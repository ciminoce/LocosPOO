using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LocosPOO.Entidades
{
    public class NumerosLocos
    {
        private int[] numeros;
        public int[] GetNumeros => numeros;
        public NumerosLocos():this(20)
        {
            
        }

        public NumerosLocos(int capacidad)
        {
            if (capacidad<20)
            {
                throw new ArgumentException("Capacidad menor a la permitida: 20");
            }

            numeros = new int[capacidad];
            PopularNumeros();
        }

        private void PopularNumeros()
        {
            Random r = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.Next(-20, 20);
            }
        }

        public string MostrarDatos(int[] nros)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var nro in nros)
            {
                sb.Append($"{nro} ");
            }

            return sb.ToString();
        }

        public string MostrarPositivosDecreciente()
        {
            var positivos = numeros.Where(n => n > 0)
                .OrderByDescending(n => n)
                .ToArray();
            return this.MostrarDatos(positivos);
        }

        public string MostrarNegativosCreciente()
        {
            var negativos = numeros.Where(n => n < 0)
                .OrderBy(n => n).ToArray();
            return this.MostrarDatos(negativos);
        }

        public int GetDato(int index)
        {
            return numeros[index];
        }

        public int this[int i]
        {
            get
            {
                if (i <numeros.Length)
                {
                    return numeros[i];

                }

                throw new ArgumentOutOfRangeException(nameof(i),"Índice fuera del rango");
            }
        }
    }
}
