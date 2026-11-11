using System.ComponentModel.DataAnnotations.Schema;

namespace X_si_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meniu ui = new Vizualizare();
            Joc joc = new Joc(ui);
            joc.JoacaJoc();
        }
    }
}
