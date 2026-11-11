using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace X_si_0
{
    internal class Tabla
    {
        private char[,] matrice;
        public const int dim = 3;
        public const char spatiu = ' ';

        public Tabla()
        {
            matrice = new char[dim, dim];
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                    matrice[i, j] = spatiu;
        }

        public char GetCelula(int linie, int coloana) => matrice[linie, coloana];

        public bool EstePozitiaLibera(int rand, int coloana)
        {
            return matrice[rand, coloana] == spatiu;
        }

        public void AplicaMutare(int rand, int coloana, char simbol)
        {
            matrice[rand, coloana] = simbol;
        }

        public bool EsteLinieCastigatoare(int rand, char simbol)
        {
            for (int i = 0; i < dim; i++)
                if (matrice[rand, i] != simbol)
                    return false;
            return true;
        }

        public bool EsteColoanaCastigatoare(int coloana, char simbol)
        {
            for (int i = 0; i <dim; i++)
                if (matrice[i, coloana] != simbol)
                    return false;
            return true;
        }

        public bool EsteDiagonalaCastigatoare(int diag, char simbol)
        {
            //linie = coloana = 2* 0 + 1 * coloana
            //linie + coloana = 2 <=> linie = 2 - coloana 2 * 1+ (-1)*coloana
            for (int i = 0; i < dim; i++)
            {
                int c = (diag == 0) ? i : (dim - 1) - i;
                if (matrice[i, c] != simbol)
                        return false;
            }
            return true;
        }

        public bool ACastigat(char simbol)
        {
            for (int i = 0;i < 3;i++)
            {
                if (EsteLinieCastigatoare(i, simbol))
                    return true;
                if (EsteColoanaCastigatoare(i, simbol))
                    return true;
            }
            if (EsteDiagonalaCastigatoare(0, simbol)) return true;
            if (EsteDiagonalaCastigatoare(1, simbol)) return true;
            return false;
        }

        public bool EGata()
        {
            foreach (char c in matrice)
                if (c == spatiu) return false;
            return true;
        }

        //public bool ERemiza(char simbol1, char simbol2)
        //{
        //    return EGata() && (!ACastigat(simbol1)) && !ACastigat(simbol2); 
        //}

    }

}
