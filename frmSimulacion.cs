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
        /* |=========================================================| */
        /* |====|            Variables globales                 |====| */
        /* |=========================================================| */
        List<PCB> Process = new List<PCB>();
        string[] Usuarios = { "root", "aggm123", "aranzagtz",
        /* |==========| */    "Anonymous","Erasmo","MikeCrack",
        /* |==========| */    "Rubiuh","Vegeta777","Kim.com","UlisesGtz",
                              "User200", "Maxima200","eulalio99","Felip0898",};
        string[] Ejecutables = { "Firefox", "Explorer", "Virus",
        /* |=============| */    "Chrome", "Calculadora", "Apoint",
        /* |=============| */    "Agenservice", "System","Phishing",
                                 "Arduino","Recorte","Spotify","Skype" };
        // Index, width, height, xCoord, yCoord, RoundRobinPosition
        int Index = 0, w = 5, h = 10, x = 4, y = 0;

        /* |=========================================================| */
        /* |====|          Comienzan los eventos                |====| */
        /* |=========================================================| */
        public frmSimulacion()
        {
            InitializeComponent();
            // Inicializamos el timer
            timQuant.Start();
        }
        /* |=========================================================| */
        /* |====|             Comienzan los eventos             |====| */
        /* |=========================================================| */
        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            // Validamos que existan elementos en la lista
            if (Index >= 2)
            {
                List<PCB> ProcesosOrd = Process.ToList();
                // Ordenamos con base en la prioridad
                ProcesosOrd.Sort((p, q) => p.pcbPriority.CompareTo(q.pcbPriority));
                Dibuja(ProcesosOrd, pnelProcesO);
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no se exceda la cantidad de elementos.
            if (Process.Sum(item => item.pcbMemory) < 255)
                // Agregamos un proceso mas a el list principal
                Agregar();
            // De lo contrario solamente se dibuja.
            else Dibuja(Process, pnelProcesO);

            // Elemento auxiliar para conocer la cantidad de bloques
            lblProcesado.Text="Cantidad de bloques de memoria = "+ Process.Sum(item => item.pcbMemory);
        }
        // Evento Quantum
        private void timQuant_Tick(object sender, EventArgs e)
        {
            // Generación de numeros aleatorios
            Random Ran = new Random();

            // Validamos la posibilidad de agregar un nuevo proceso
            if (Convert.ToInt32(Ran.Next(0, 100)) == 3)
                // Validamos que no se exceda la cantidad de elementos.
                if (Process.Sum(item => item.pcbMemory) < 255)
                    Agregar();
                // De lo contrario solamente se dibuja.
                else Dibuja(Process, pnelProcesO);
        }

        private void frmSimulacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Finalizamos el timer.
            timQuant.Stop();
        }
        /* |=========================================================| */
        /* |====|              Terminan los eventos             |====| */
        /* |=========================================================| */


        /* |=========================================================| */
        /* |====|             Comienzan los métodos             |====| */
        /* |=========================================================| */

        /* |====|    Método de dibujo de la memoria del PCB     |====| */
        public void Dibuja(List<PCB> Procesos, Panel panel)
        {
            // Elemento que permite que nos comuniquemos con el panel
            Graphics G = panel.CreateGraphics();

            // Index local
            int i = 0;
            foreach (PCB Proceso in Procesos)
            {
                Pen[] Lapiz = new Pen[2];
                Lapiz[0] = new Pen(Procesos[i].pcbColor[1]);
                Lapiz[1] = new Pen(Procesos[i].pcbColor[0]);
                Lapiz[0].Width = 6;
                Lapiz[1].Width = 6;

                for (int j = 0; j < Procesos[i].pcbMemory; j++)
                {
                    // Validamos que el cursor se encuentre dentro del rango de las x
                    if (x > panel.Width - w * 3)
                    {
                        y += h * 2 - 3;
                        x = 4;
                    }
                    // Dibujamos los rectangulos que permiten ver la prioridad y el proceso
                    G.DrawRectangle(Lapiz[0], new Rectangle(x, y - 1, w, h + 2));
                    G.DrawRectangle(Lapiz[1], new Rectangle(x, y, w, h / 2));
                    x += w + w / 2 + 6;
                }
                // Cambiamos el index del elemento a imprimir
                i++;
            }
            // Reposicionamos el cursor del panel
            x = 4; y = 0;
        }

        /* |====|           Algoritmo de Round Robin            |====| */
        public void RoundR(List<PCB> Procesos)
        {
            // Leemos los Quantum que el usuario escogió.
            int Quantum = tackQuantum.Value;
            // Elemento que permite que nos comuniquemos con el panel
            Graphics G = pnelCinco.CreateGraphics();

            // Al llamarse el metodo de Round Robin, se ejecutara
            // la impresión y reduccion de n (quantums) del proceso
            // dependiendo de la prioridad que tenga
            int i = 0;
            foreach (PCB Proceso in Procesos)
            {
                Pen[] Lapiz = new Pen[2];
                Lapiz[0] = new Pen(Procesos[i].pcbColor[1]);
                Lapiz[1] = new Pen(Procesos[i].pcbColor[0]);
                Lapiz[0].Width = 6;
                Lapiz[1].Width = 6;
                if (Procesos[Index].pcbPriority == 1)
                {
                    G.DrawRectangle(Lapiz[0], new Rectangle(x, y - 1, w, h + 2));
                    G.DrawRectangle(Lapiz[1], new Rectangle(x, y, w, h / 2));
                }
            }
        }
        // Método que agrega un nuevo PCB
        public void Agregar()
        {
            // Generación de numeros aleatorios
            Random Ran = new Random();
            string Usuario = Usuarios[Ran.Next(0, Usuarios.Length)];

            // Asignación de elementos a cajas de texto en caso de que se encuentren nulas.
            if (txtProcessM.Text != "" && txtProcessN.Text != "")
                Usuario = "Dios";
            else
            {
                if (txtProcessN.Text == "")
                    txtProcessN.Text = Ejecutables[Ran.Next(0, Ejecutables.Length)];
                if (txtProcessM.Text == "")
                    txtProcessM.Text = Convert.ToString(Ran.Next(1, 10));
            }

            // Validamos el tiempo de llegada con base en el anterior (si es que existe)
            // y la cantidad de ciclos que se le aplicarán.
            int InTime = 0;
            if (Index > 0) InTime = Ran.Next(Process[Index - 1].pcbInTime, Process[Index - 1].pcbInTime +
                Process[Index - 1].pcbMemory);

            // Agregamos nuevo elemento a la lista del PCB.
            Process.Add(new PCB(
                Index,                                  // Identificador unico
                txtProcessN.Text,                       // Nombre
                Ran.Next(1, 6),                         // Prioridad
                InTime,                                 // Tiempo de llegada
                Usuario,                                // Usuario
                0,                                      // Estado ( Nuevo )
                Convert.ToInt32(txtProcessM.Text)));    // EBT 

            // Llamamos al evento que imprime los rectangulos
            Dibuja(Process, pnelProcessI);

            // |===| Agregamos los elementos a la Tabla |===|
            // "limpiamos" la tabla
            datagvPCB.DataSource = null;
            // agregamos los nuevos elementos.
            datagvPCB.DataSource = Process;

            // Recorremos el apuntador
            Index++;
            // Limpiamos las cajas de texto
            foreach (Control Caja in grpbProcesos.Controls)
                if (Caja is TextBox)
                    Caja.Text = "";
        }
        /* |=========================================================| */
        /* |====|              Terminan los métodos             |====| */
        /* |=========================================================| */
    }
}