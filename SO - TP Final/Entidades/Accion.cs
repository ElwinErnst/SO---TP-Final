namespace SO___TP_Final.Entidades
{
    class Accion
    {
        string nombre;
        int movimiento;

        public Accion()
        {
        }

        public Accion(string nombre, int movimiento)
        {
            this.nombre = nombre;
            this.movimiento = movimiento;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Movimiento { get => movimiento; set => movimiento = value; }
    }
}