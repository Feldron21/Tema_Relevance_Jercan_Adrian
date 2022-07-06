using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clasa derivata pentru obiectul "portie de mancare" cu valorile corespunzatoare
namespace Tema_Relevance.Clase
{
    internal class PortieMancare : ArticolInventar
    {
        public PortieMancare() : base(1f, 0.5f) { }
    }
}
