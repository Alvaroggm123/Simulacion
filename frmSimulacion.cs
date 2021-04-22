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
        PCB[] Procesos= new PCB[255];
        string[] Usuarios = { "root", "aggm123", "aranzagtz" };
        int i=0;
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
            Random Ran = new Random();
            // Generamos nuevo objeto de clase PCB
            Procesos[i] = new PCB(
                i,
                txtProccesN.Text, Usuarios[Ran.Next(0, 3)],
                "new",
                Convert.ToInt32(txtProccesT.Text));
            tabProcesos.Rows.Add();
            // Agregamos los parametros de nuestro objeto a la tabla.
            tabProcesos.Rows[i].Cells[0].Value = Procesos[i].pcbPID;
            tabProcesos.Rows[i].Cells[1].Value = Procesos[i].pcbName;
            tabProcesos.Rows[i].Cells[2].Value = Procesos[i].pcbMemory;
            tabProcesos.Rows[i].Cells[3].Value = Procesos[i].pcbUser;
            tabProcesos.Rows[i].Cells[4].Value = Procesos[i].pcbState;

            Pen Lapiz = new Pen(Procesos[i].pcbColor);
            Lapiz.Width = 5;
            G.DrawRectangle(Lapiz, new Rectangle(10, 10, 5, 10));
            // Recorremos el apuntador
            i++;
        }

        /* | Terminan los eventos | */
    }
}
