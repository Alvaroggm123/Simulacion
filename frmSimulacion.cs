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
        List<PCB> ProcesoEntrante = new List<PCB>();
        List<PCB> ProcesoSaliente = new List<PCB>();
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
        }
        /* |=========================================================| */
        /* |====|             Comienzan los eventos             |====| */
        /* |=========================================================| */
        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            // Inicializamos el timer
            if (timQuant.Enabled == false)
                timQuant.Enabled= !timQuant.Enabled;
            else
                timQuant.Enabled = !timQuant.Enabled;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no se exceda la cantidad de elementos.
            if (ProcesoEntrante.Sum(item => item.pcbQuantum) < 512)
                // Agregamos un proceso mas a el list principal
                Agregar();
            // De lo contrario solamente se dibuja.
            else Dibuja(ProcesoEntrante, pnelCola);
        }
        // Evento Quantum
        private void timQuant_Tick(object sender, EventArgs e)
        {
            // Generación de numeros aleatorios
            Random Ran = new Random();

            // Validamos la posibilidad de agregar un nuevo proceso
            if (Convert.ToInt32(Ran.Next(0, 5)) == 3)
                // Validamos que no se exceda la cantidad de elementos.
                if (ProcesoEntrante.Sum(item => item.pcbQuantum) < 512)
                    Agregar();
                // De lo contrario solamente se dibuja.
                else Dibuja(ProcesoEntrante, pnelCola);

            // Validamos que existan elementos en la lista
            List<PCB> ProcesosOrd = ProcesoSaliente.ToList();
            if (Index >= 2)
            {
                // Ordenamos con base en la prioridad
                ProcesosOrd.Sort((p, q) => p.pcbPriority.CompareTo(q.pcbPriority));
                Dibuja(ProcesosOrd, pnelCola);

                // Llamamos al evento que imprime los rectangulos
                Dibuja(ProcesosOrd, pnelCola);

                // |===| Agregamos los elementos a la Tabla |===|
                // "limpiamos" la tabla
                datagvCola.DataSource = null;
                // agregamos los nuevos elementos.
                datagvCola.DataSource = ProcesosOrd;
                datagvCola.Columns[0].HeaderText = "ID";
                datagvCola.Columns[1].HeaderText = "Nombre";
                datagvCola.Columns[2].HeaderText = "Prioridad";
                datagvCola.Columns[3].HeaderText = "Tiempo llegada";
                datagvCola.Columns[4].HeaderText = "EBT";
                datagvCola.Columns[5].HeaderText = "Usuario";
                datagvCola.Columns[6].HeaderText = "Estado";
                // Llamada al metodo Round Robin con el arreglo ordenado si se tienen mas de n elementos
                if (ProcesoSaliente.Sum(item => item.pcbQuantum) > 1)
                    ProcesoSaliente=RoundR(ProcesosOrd);
                Dibuja(ProcesoSaliente, pnelCola);
            }
        }

        private void datagvLlegada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

            // Limpieza de panel
            G.Clear(Color.DimGray);

            // Index local
            int i = 0;
            if (Procesos.Sum(item => item.pcbQuantum) > 0)
                foreach (PCB Proceso in Procesos)
                {
                    Pen[] Lapiz = new Pen[2];
                    Lapiz[0] = new Pen(Procesos[i].pcbColor[1]);
                    Lapiz[1] = new Pen(Procesos[i].pcbColor[0]);
                    Lapiz[0].Width = 6;
                    Lapiz[1].Width = 6;

                    for (int j = 0; j < Procesos[i].pcbQuantum; j++)
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
            if (Index > 0) InTime = Ran.Next(ProcesoEntrante[Index - 1].pcbInTime, ProcesoEntrante[Index - 1].pcbInTime +
                ProcesoEntrante[Index - 1].pcbQuantum);

            // Agregamos nuevo elemento a la lista del PCB.
            ProcesoEntrante.Add(new PCB(
                Index,                                  // Identificador unico
                txtProcessN.Text,                       // Nombre
                Ran.Next(1, 6),                         // Prioridad
                InTime,                                 // Tiempo de llegada
                Usuario,                                // Usuario
                0,                                      // Estado ( Nuevo )
                Convert.ToInt32(txtProcessM.Text)));    // EBT
            ProcesoSaliente.Add(new PCB(
                Index,                                  // Identificador unico
                txtProcessN.Text,                       // Nombre
                ProcesoEntrante[Index].pcbPriority,     // Prioridad
                InTime,                                 // Tiempo de llegada
                Usuario,                                // Usuario
                0,                                      // Estado ( Nuevo )
                Convert.ToInt32(txtProcessM.Text)));    // EBT

            // Llamamos al evento que imprime los rectangulos
            Dibuja(ProcesoEntrante, pnelLlegada);

            // |===| Agregamos los elementos a la Tabla |===|
            // "limpiamos" la tabla
            datagvLlegada.DataSource = null;
            // agregamos los nuevos elementos.
            datagvLlegada.DataSource = ProcesoEntrante;

            // Aquí van las etiquetas de las columnas
            datagvLlegada.Columns[0].HeaderText = "ID";
            datagvLlegada.Columns[1].HeaderText = "Nombre";
            datagvLlegada.Columns[2].HeaderText = "Prioridad";
            datagvLlegada.Columns[3].HeaderText = "Tiempo llegada";
            datagvLlegada.Columns[4].HeaderText = "EBT";
            datagvLlegada.Columns[5].HeaderText = "Usuario";
            datagvLlegada.Columns[6].HeaderText = "Estado";
            // Recorremos el apuntador
            Index++;
            // Limpiamos las cajas de texto
            foreach (Control Caja in grpbProcesos.Controls)
                if (Caja is TextBox)
                    Caja.Text = "";
        }
        /* |====|           Algoritmo de Round Robin            |====| */
        List<PCB> RoundR(List<PCB> Procesos)
        {
            /* |====|              Aquí se puede validar el tiempo.             |====| */
            // Trabajamos con la lista de procesos salientes
            int i = 0;
            while (Procesos[i].pcbQuantum < 1)
            {
                if (Procesos[i].pcbQuantum == 0)
                {
                    Procesos[i].pcbState = 4;
                    // Eliminamos el elemento ya trabajado
                    ProcesoEntrante[i].pcbState = Procesos[i].pcbState;
                }
                i++;
            }
            if (Procesos[i].pcbQuantum >= tackQuantum.Value)
            {
                Procesos[i].pcbQuantum -= tackQuantum.Value;
                Procesos[i].pcbState = 2;
                ProcesoEntrante[i].pcbState = Procesos[i].pcbState;
            }
            else
            {
                Procesos[i].pcbQuantum = 0;
                Procesos[i].pcbState = 4;
                ProcesoEntrante[i].pcbState = Procesos[i].pcbState;
            }
            // Aquí validamos el track
            return Procesos;

        }
        /* |=========================================================| */
        /* |====|              Terminan los métodos             |====| */
        /* |=========================================================| */
    }
}
/* |=========================================================| */
/* |                                                         | */
/* |              Alumnos y numeros de control:              | */
/* |     González Martínez Álvaro Gabriel - 19211651         | */
/* |                                                         | */
/* |=========================================================| */
/* |                                                         | */
/* |                 Prioridad de procesos                   | */
/* |                                                         | */
/* |    _________________________________________________    | */
/* |    | Nombre de la prioridad del proceso  |  Valor  |    | */
/* |    |-----------------------------------------------|    | */
/* |    | Tiempo real                         |    1    |    | */
/* |    | Alta prioridad                      |    2    |    | */
/* |    | Prioridad arriba de la normal       |    3    |    | */
/* |    | Prioridad normal                    |    4    |    | */
/* |    | Prioridad de bajo de la normal      |    5    |    | */
/* |    | Baja prioridad                      |    6    |    | */
/* |    |_____________________________________|_________|    | */
/* |                                                         | */
/* |=========================================================| */
/* |                                                         | */
/* |                 Estados disponibles                     | */
/* |                                                         | */
/* |    _________________________________________________    | */
/* |    |    Nombre del estado del proceso    |  Valor  |    | */
/* |    |-----------------------------------------------|    | */
/* |    | Estado de nuevo       ( New     )   |    0    |    | */
/* |    | Estado de listo       ( Ready   )   |    1    |    | */
/* |    | Estado en ejecucion   ( Running )   |    2    |    | */
/* |    | Estado de bloqueo     ( Blocked )   |    3    |    | */
/* |    | Estado de finalizado  ( Exit    )   |    4    |    | */
/* |    |_____________________________________|_________|    | */
/* |                                                         | */
/* |=========================================================| */