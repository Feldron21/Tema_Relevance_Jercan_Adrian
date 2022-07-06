using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Base class-ul pentru cele 6 obiecte
//Avem cele 2 propeietati si constructorul cu parametrii
namespace Tema_Relevance.Clase
{
    internal class ArticolInventar
    {
        public float greutate;
        public float volum;

        public ArticolInventar(float greutate, float volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
