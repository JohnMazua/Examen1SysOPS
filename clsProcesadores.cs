using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_997024_61421508
{
    class clsProcesadores
    {
        Random r = new Random();

        public clsProcesadores(int id){
            this.id = id;
            this.hilos = r.Next(1, 4);
            this.estado = 1;
        }

        public int hilos { get; set; }
        public int estado { get; set; }
        public int id { get; set; }

        public string estadoProceso(int val){
            switch (val) {
                case 1: return "Libre";break;
                case 2: return "Ocupado";break;
                default: return "Null";break;
            }
        }
    }
}
