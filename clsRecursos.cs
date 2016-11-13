using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_997024_61421508
{

    class clsRecursos
    {
        public int id { get; set; }
        public int estado { get; set; }

        public clsRecursos(int id)
        {
            this.id = id;
            this.estado = 1;
        }
        public string estadorecurso(int val)
        {
            switch (val)
            {
                case 0: return "Ocupado"; break;
                case 1: return "Disponible"; break;
                default: return "Null"; break;
            }
        }


    }
}
