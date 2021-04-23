using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class frmSimulacion : Form
    {
        /* | Variables globales | */
        List<PCB> Process = new List<PCB>();
        string[] Usuarios = { "root", "aggm123", "aranzagtz", "Anonymous" };
        string[] Ejecutables = { "Firefox", "Explorer", "Virus", "Chrome", "Calculadora", "Apoint", "Agenservice", "System" };
        int Index = 0, w = 5, h = 10;
        int x = 0, y = 0;

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            // Validamos que existan elementos en la lista
            if (Index >= 2)
            {
                int i = 0;
                List<PCB> ProcesosOrd = Process.ToList();
                ProcesosOrd.Sort((p, q) => p.pcbMemory.CompareTo(q.pcbMemory));
                Dibuja(ProcesosOrd, panel1);
            }
            else
            {

            }
        }

        Pen pen;
        /* | Fin Variables globales | */
        public frmSimulacion()
        {
            InitializeComponent();
        }
        /* | Comienzan los eventos | */

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            // Generación de numeros aleatorios
            Random Ran = new Random();


            // Asignación de elementos a cajas de texto en caso de que se encuentren nulas.
            if (txtProcessN.Text == "")
                txtProcessN.Text = Ejecutables[Ran.Next(0, Ejecutables.Length)];
            if (txtProcessM.Text == "")
                txtProcessM.Text = Convert.ToString(Ran.Next(1, 10));
            // Agregamos nuevo elemento a la lista del PCB
            Process.Add(new PCB(
                Index,
                txtProcessN.Text, Usuarios[Ran.Next(0, 3)],
                "new",
                Convert.ToInt32(txtProcessM.Text)));
            // Llamamos al evento que imprime los rectangulos
            Dibuja(Process, panelLoading);


            // Agregamos los elementos a la lista (Tabla)
            // Definición de la listView
            ListViewItem Elemento = new ListViewItem(Convert.ToString(Process[Index].pcbPID));

            Elemento.SubItems.Add(Convert.ToString(Process[Index].pcbName));
            Elemento.SubItems.Add(Convert.ToString(Process[Index].pcbMemory));
            Elemento.SubItems.Add(Convert.ToString(Process[Index].pcbUser));
            Elemento.SubItems.Add(Convert.ToString(Process[Index].pcbState));
            Elemento.BackColor = Process[Index].pcbColor;
            tabProcesos.Items.Add(Elemento);

            // Recorremos el apuntador
            Index++;
            // Limpiamos las cajas de texto
            foreach (Control Caja in grpbProcesos.Controls)
                if (Caja is TextBox)
                    Caja.Text = "";
        }

        /* | Terminan los eventos | */

        /* |==| Comienzan los métodos |==| */
        public void Dibuja(List<PCB> Procesos, Panel panel)
        {
            // Elemento que permite que nos comuniquemos con el panel
            Graphics G = panel.CreateGraphics();

            // Index local
            int i = 0;
            foreach(PCB Proceso in Procesos)
            {
                Pen Lapiz = new Pen(Procesos[i].pcbColor);
                Lapiz.Width = 5;

                for (int j = 0; j < Procesos[i].pcbMemory; j++)
                {
                    if (x > panelLoading.Width - w * 2)
                    {
                        y += h * 2 - 3;
                        x = 0;
                    }
                    G.DrawRectangle(Lapiz, new Rectangle(x, y, w, h));
                    x += w + w / 2 + 4;
                }
                i++;
            }
            x = 0; y = x;
        }
    }
}