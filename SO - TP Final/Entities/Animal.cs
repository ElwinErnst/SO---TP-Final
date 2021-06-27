using System.Collections.Generic;

namespace SO___TP_Final.Entities
{
    class Animal
    {
        int mile;
        List<Accion> acciones;

        public Animal()
        {
            this.acciones = new List<Accion>();
        }
        public Animal(int mile, List<Accion> acciones)
        {
            this.mile = mile;
            this.acciones = acciones;
        }

        public int Mile { get => mile; set => mile = value; }
        internal List<Accion> Acciones { get => acciones; set => acciones = value; }
    }
}