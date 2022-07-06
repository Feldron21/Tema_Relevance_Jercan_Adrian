using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_Relevance.Clase;

//Clasa pentru ghiozdan
namespace Tema_Relevance.Clase
{
    internal class Ghiozdan
    {
        //declaram limitele ghiozdanului cu radonly pentru a nu putea fi modificate ulterior 
        private readonly int nrMaxArticole;
        private readonly float volumMax;
        private readonly float greutateMax;

        //declaram lista pentru obiectele ce urmeaza a fi adaugate in ghiozdan
        public List<ArticolInventar> articolInventar { get; set; }

        //constructorul cu parametrii pentru ghiozdan
        public Ghiozdan(int n, float max_v, float max_g)
        {
            this.nrMaxArticole = n;
            this.volumMax = max_g;
            this.greutateMax = max_g;
            this.articolInventar = new List<ArticolInventar>();
        }

        //metoda ce returneaza numarul total al obiectelor din ghiozdan
        public int NumarArticole()
        {
            return this.articolInventar.Count;
        }

        //metoda ce returneaza greutatea totala a obiectelor din ghiozdan
        public float GreutateArticole()
        {
            return this.articolInventar.Select(x => x.greutate).Sum();
        }

        //metoda ce returneaza volumul total al obiectelor din ghiozdan
        public float VolumArticole()
        {
            return this.articolInventar.Select(x => x.volum).Sum();
        }
        
        //metoda pentru a afisa raportul dintre valorile actuale si limitele parametrilor ghiozdanului 
        public void AfisareParametriiArticole()
        {
            Console.WriteLine($"Ca numar de articole avem {NumarArticole()} din {this.nrMaxArticole} maxim.");
            Console.WriteLine($"Ca greutate avem {GreutateArticole()} din {this.greutateMax} maxim.");
            Console.WriteLine($"Ca volum avem {VolumArticole()} din {this.volumMax} maxim.");
        }

        //metoda ce verifica daca obiectul ce urmeaza a fi adaugat poate fi adaugat sau nu
        public bool Adauga(ArticolInventar articol)
        {
            try
            {
                //comparam numarul de articole deja existente plus articolul ce urmeaza a fi adaugat cu numarul maxim de articole ce incap in ghiozdan
                var nr_articole = NumarArticole();
                if (nr_articole + 1 > this.nrMaxArticole) return false;

                //comparam greutatea articolelor deja existente plus greutatea articolului ce urmeaza a fi adaugat cu greutatea maxima ce incape in ghiozdan
                var greutateTotala = GreutateArticole();
                if (greutateTotala + articol.greutate > this.greutateMax) return false;

                //comparam volumul articolelor deja existente plus volumul articolului ce urmeaza a fi adaugat cu volumul maxim al ghiozdanului
                var volumTotal = VolumArticole();
                if (volumTotal + articol.volum > this.volumMax) return false;

                this.articolInventar.Add(articol);
            }
            catch (Exception ex) { return false; }

            return true;

        }


    }

}
