/* |=========================================================| */
/* |====|          Simulacion de procesos en SO         |====| */
/* |=========================================================| */
/* |====| */ using System;                           /* |====| */
/* |====| */ using System.Collections.Generic;       /* |====| */
/* |====| */ using System.Linq;                      /* |====| */
/* |====| */ using System.Threading.Tasks;           /* |====| */
/* |====| */ using System.Windows.Forms;             /* |====| */
/* |====| */ using System.Drawing;                   /* |====| */
/* |=========================================================| */
/* |====| Aspectos principales a evaluar en el proyecto |====| */
/* |=========================================================| */
/* |                                                         | */
/* | Para  el  proyecto  se  contemplara  el algoritmo Round | */
/* | Robin con  prioridad,  para  definir las prioridades se | */
/* | establecio  la  plantilla  que  Windows  10  tiene  por | */
/* | defecto, al menos hata este momento.                    | */
/* |                                                         | */
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

namespace Simulacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSimulacion());
        }
    }
    /* | Comienzan las clases | */
    public class PCB
    {
        /* |==| Campos de clase |==| */
        public int pcbPID { get; set; }         // Identificador unico del PCB
        public string pcbName { get; set; }     // Nombre que conserva el PCB 
        public int pcbPriority { get; set; }    // Prioridad del PCB
        public int pcbInTime { get; set; }      // Orden de llegada del proceso
        public int pcbQuantum { get; set; }      // EBT (Estimated Burst time) (Quantums necesarios)
        public string pcbUser { get; set; }     // Usuario que se registra en el PCB
        public int pcbState { get; set; }       // Estado en el que se encuentra el PCB

        public Color[] pcbColor = new Color[2]; // Color que conserva el PCB

        public int pcbMemoriaProceso { get; set; } //Memoria del proceso

        /* |==| Constructor con parametros de entrada |==| */
        public PCB(int pcbPID, string pcbName, int pcbPriority,int pcbInTime, string pcbUser, int pcbState, int pcbQuantum)
        {
            // Variable que permitira generar parametros aleatorios.
            Random Ran = new Random();
            // Asignacion de parametros en campos.
            this.pcbPID = pcbPID;
            this.pcbName = pcbName;
            this.pcbPriority = pcbPriority;
            this.pcbInTime = pcbInTime;
            this.pcbQuantum = pcbQuantum;
            this.pcbUser = pcbUser;
            this.pcbState = pcbState;

            // Asignamos colores para la prioridad e identificador.
            pcbColor[0] = Color.FromArgb(Ran.Next(100, 255), Ran.Next(100, 255), Ran.Next(100, 255));
            switch (pcbPriority)
            {
                case 1:
                    pcbColor[1] = Color.DarkBlue;
                    break;
                case 2:
                    pcbColor[1] = Color.DarkGreen;
                    break;
                case 3:
                    pcbColor[1] = Color.DarkCyan;
                    break;
                case 4:
                    pcbColor[1] = Color.DarkGray;
                    break;
                case 5:
                    pcbColor[1] = Color.Red;
                    break;
                case 6:
                    pcbColor[1] = Color.Magenta;
                    break;
            }
            this.pcbMemoriaProceso = Ran.Next(100,1000);
        }
    }
}