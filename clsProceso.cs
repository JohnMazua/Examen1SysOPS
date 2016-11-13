using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_997024_61421508
{
    class clsProceso
    {
        Random r2 = new Random();

        clsRecursos r;
        clsProcesadores p;
        public int id { get; set; }
        public int estado { get; set; }
        public int prioridad { get; set; }
        public int tiempo { get; set; }
        
        public clsProceso(int id)
        {
            this.id = id;
            this.estado = 1;
            this.prioridad = r2.Next(1, 4);
            this.tiempo = tiempo;
        }

        public void addCurso(clsRecursos r)
        {
            this.r = r;
        }
        
        public string estadoProceso(int val)
        {
            switch (val)
            {
                case 1: return "Espera"; break;
                case 2:return "Ejecución"; break;
                case 3:return "Finalizado"; break;
                case 4:return "Bloqueado"; break;
                default:return "Null"; break;
            }
        }


        public string prioridadProceso(int val){
            switch (val){
                case 1:return "Bajo"; break;
                case 2:return "Medio";break;
                case 3:return "Alto"; break;
                case 4:return "Crítico"; break;
                default:return "Null"; break;
            }
        }


    }
}
