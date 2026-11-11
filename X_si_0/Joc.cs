using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace X_si_0
{
    internal class Joc
    {
        private Tabla tabla;
        private Jucator jucator1;
        private Jucator jucator2;
        private Jucator jucatorCurent;

        private Meniu UI;

        public Joc(Meniu uI)
        {
            tabla = new Tabla();
            jucator1 = new Jucator('X');
            jucator2 = new Jucator('0');
            jucatorCurent = jucator1;
            UI = uI;
        }

        public void JoacaJoc()
        {
            UI.ArataTabla(tabla);
            while (true)
            {

                UI.ScrieMesaj($"Randul lui {jucatorCurent.Simbol}");
                int linie, coloana;
                while (true)
                {
                    UI.ScrieMesaj("Da linia (0-2): ");
                    if (!int.TryParse(UI.ObtineInput(), out linie) || (linie < 0 || linie > 2))
                    {
                        UI.ScrieMesaj("Linie invalida");
                        continue;
                    }
                    UI.ScrieMesaj("Da coloana (0-2): ");
                    if (!int.TryParse(UI.ObtineInput(), out coloana) || (coloana < 0 || coloana > 2))
                    {
                        UI.ScrieMesaj("Coloana invalida");
                        continue;
                    }
                    if (tabla.EstePozitiaLibera(linie, coloana))
                        break;
                    UI.ScrieMesaj("Celula ocupata");
                }
                tabla.AplicaMutare(linie, coloana, jucatorCurent.Simbol);
                UI.ArataTabla(tabla);
                if (tabla.ACastigat(jucatorCurent.Simbol))
                {
                    UI.ScrieMesaj($"A castigat {jucatorCurent.Simbol}");
                    break;
                }
                if (tabla.EGata())
                {
                    UI.ScrieMesaj("E remiza");
                    break;
                }
                SchimbaJucatorCurent();
            }
        }


        private void SchimbaJucatorCurent()
        {
            jucatorCurent = (jucatorCurent == jucator1) ? jucator2 : jucator1;
        }

    }
}