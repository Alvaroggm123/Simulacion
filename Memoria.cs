public class memoria
{
    int numParticion;
    int tamañoParticion;
    int tamañoParticionOcupado;
    bool Disponibilidad;

    public int NumParticion { get => numParticion; set => numParticion = value; }
    public int TamañoParticion { get => tamañoParticion; set => tamañoParticion = value; }
    public int TamañoParticionOcupado { get => tamañoParticionOcupado; set => tamañoParticionOcupado = value; }
    public bool Disponibilidad1 { get => Disponibilidad; set => Disponibilidad = value; }

    public Memoria(int IDP, int Tam, int TamO, bool Disp)
    {
        this.numParticion = IDP;
        this.tamañoParticion = Tam;
        this.tamañoParticionOcupado = TamO;
        this.Disponibilidad = Disp;
    }
}
