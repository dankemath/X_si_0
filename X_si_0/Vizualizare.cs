using System;
using System.Collections.Generic;
using System.Text;

namespace X_si_0
{
    internal class Vizualizare: Meniu
    {
        public void ArataTabla(Tabla tabla)
        {
            for (int i = 0; i < Tabla.dim; i++)
                Console.Write($"   {i}");
            Console.WriteLine();
            for (int i = 0; i < Tabla.dim; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < Tabla.dim; j++)
                {
                    Console.Write(tabla.GetCelula(i, j));
                    if (j < Tabla.dim - 1) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < Tabla.dim - 1) Console.WriteLine(" ---+---+---");
            }
        }

        public void ScrieMesaj(string mesaj) => Console.WriteLine(mesaj);

        public string ObtineInput() => Console.ReadLine();
    }
}
