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
        int ID=0, x=0,y=0,w=5,h=10;
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
            Procesos[ID] = new PCB(
                ID,
                txtProccesN.Text, Usuarios[Ran.Next(0, 3)],
                "new",
                Convert.ToInt32(txtProccesT.Text));
            tabProcesos.Rows.Add();
            // Agregamos los parametros de nuestro objeto a la tabla.
            tabProcesos.Rows[ID].Cells[0].Value = Procesos[ID].pcbPID;
            tabProcesos.Rows[ID].Cells[1].Value = Procesos[ID].pcbName;
            tabProcesos.Rows[ID].Cells[2].Value = Procesos[ID].pcbMemory;
            tabProcesos.Rows[ID].Cells[3].Value = Procesos[ID].pcbUser;
            tabProcesos.Rows[ID].Cells[4].Value = Procesos[ID].pcbState;

            Pen Lapiz = new Pen(Procesos[ID].pcbColor);
            Lapiz.Width = 5;

            for(int i = 0; i < Procesos[ID].pcbMemory; i++)
            {
                if (x > panelLoading.Width - w)
                {
                    y += h*2-3;
                    x = 0;
                }
                G.DrawRectangle(Lapiz, new Rectangle(x, y, w, h));
                x += w+w/2+4;
            }
            // Recorremos el apuntador
            ID++;
        }

        /* | Terminan los eventos | */
    }
}
