using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1_997024_61421508
{
    public partial class Form1 : Form
    {
        int c_procesos = 0;
        int c_recursos = 0;
        int c_procesador = 0;
        public Form1(){InitializeComponent();}

        private void btnProcesador_Click(object sender, EventArgs e) {
            c_procesador++;
            clsProcesadores nuevo = new clsProcesadores(c_procesador);
            lstProcesadores.Items.Add(new ListViewItem(new String[] { nuevo.id.ToString(), nuevo.estadoProceso(nuevo.estado) , nuevo.hilos.ToString()}));
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            if (c_recursos == 0){
                MessageBox.Show("Imposible crear un proceso sin un Recurso");
            }else{
                c_procesos++;
                clsProceso nuevo = new clsProceso(c_procesos);
                lstProcesos.Items.Add(new ListViewItem(new String[] { nuevo.id.ToString(), nuevo.prioridadProceso(nuevo.prioridad),nuevo.estadoProceso(nuevo.estado)}));
               

                
            }
        }

        private void btnRecurso_Click(object sender, EventArgs e)
        {
            if (c_procesador == 0){
                MessageBox.Show("Imposible crear un recursos sin un procesador");
            }else{
                c_recursos++;
                clsRecursos nuevo_r = new clsRecursos();
            }
        }

        private void lstRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
