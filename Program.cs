using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // Campos de clase
        public string pcbName, pcbUser, pcbState;
        public int pcbPID, pcbMemory = 0;
        // Constructor con parametros de entrada
        public PCB(int pcbPID, string pcbName, string pcbUser, string pcbState, int pcbMemory)
        {
            this.pcbPID = pcbPID;
            this.pcbName = pcbName;
            this.pcbMemory = pcbMemory;
            this.pcbUser = pcbUser;
            this.pcbState = pcbState;
        }
    }
}
