namespace Simulacion
{
    internal class Asignacion
    {
        private int tamaño;
        private string tarea;
        private int Quantum;

        public Asignacion(int tamaño, string tarea, int quantum)
        {
            this.tamaño = tamaño;
            this.tarea = tarea;
            this.Quantum = quantum;
        }
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public int EBT { get => Quantum;
                              set => Quantum = value; }
        public string Proceso
        {
            get { return tarea; }
            set { tarea = value; }
        }
    }
}