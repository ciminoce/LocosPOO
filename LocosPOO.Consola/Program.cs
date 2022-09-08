using System;
using LocosPOO.Entidades;

namespace LocosPOO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello Crazy Numbers!");
                var locos = new NumerosLocos();
                Console.WriteLine(locos.MostrarDatos(locos.GetNumeros));
                Console.WriteLine(locos.MostrarPositivosDecreciente());
                Console.WriteLine(locos.MostrarNegativosCreciente());
                var numero = locos[74];
                Console.WriteLine(numero);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                ;
            }            Console.ReadLine();
        }
    }
}
