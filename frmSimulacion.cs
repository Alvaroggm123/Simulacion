using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Simulacion
{
    public partial class frmSimulacion : Form
    {
        /* | Variables globales | */
        List<PCB> Procesos = new List<PCB>();
        string[] Usuarios = { "root", "aggm123", "aranzagtz" };
        string[] Ejecutables = { "Firefox", "Explorer", "Virus", "Chrome", "Calculadora", "Apoint", "Agenservice", "System" };
        int ID = 0, x = 0, y = 0, w = 5, h = 10;
        Pen pen;
        /* | Fin Variables globales | */
        public frmSimulacion()
        {
            InitializeComponent();
        }
        /* | Comienzan los eventos | */

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            // Elemento que permite que nos comuniquemos con el panel
            Graphics G = panelLoading.CreateGraphics();
            // Generación de numeros aleatorios
            Random Ran = new Random();


            // Asignación de elementos a cajas de texto en caso de que se encuentren nulas.
            if (txtProcessN.Text == "")
                txtProcessN.Text = Ejecutables[Ran.Next(0, Ejecutables.Length)];
            if (txtProcessM.Text == "")
                txtProcessM.Text = Convert.ToString(Ran.Next(1, 10));
            // Agregamos nuevo elemento a la lista del PCB
            Procesos.Add( new PCB(
                ID,
                txtProcessN.Text, Usuarios[Ran.Next(0, 3)],
                "new",
                Convert.ToInt32(txtProcessM.Text)));
            // Agregamos los elementos a la lista (Tabla)
            // Definición de la listView
            ListViewItem Elemento =new ListViewItem(Convert.ToString(Procesos[ID].pcbPID));

            Elemento.SubItems.Add(Convert.ToString(Procesos[ID].pcbName));
            Elemento.SubItems.Add(Convert.ToString(Procesos[ID].pcbMemory));
            Elemento.SubItems.Add(Convert.ToString(Procesos[ID].pcbUser));
            Elemento.SubItems.Add(Convert.ToString(Procesos[ID].pcbState));
            Elemento.BackColor = Procesos[ID].pcbColor;
            tabProcesos.Items.Add(Elemento);
            //tabProcesos.Rows[ID].ContextMenuStrip = Procesos[ID].pcbColor;

            Pen Lapiz = new Pen(Procesos[ID].pcbColor);
            Lapiz.Width = 5;

            for (int i = 0; i < Procesos[ID].pcbMemory; i++)
            {
                if (x > panelLoading.Width - w * 2)
                {
                    y += h * 2 - 3;
                    x = 0;
                }
                G.DrawRectangle(Lapiz, new Rectangle(x, y, w, h));
                x += w + w / 2 + 4;
            }
            // Recorremos el apuntador
            ID++;
            // Limpiamos las cajas de texto
            foreach (Control Caja in grpbProcesos.Controls)
                if (Caja is TextBox)
                    Caja.Text = "";
        }

        /* | Terminan los eventos | */
    }
}