using System.Collections.Generic;

namespace SO___TP_Final.Entidades
{
    class Animal
    {
        int milla;
        List<Accion> acciones;

        public Animal()
        {
            this.acciones = new List<Accion>();
        }
        public Animal(int milla, List<Accion> acciones)
        {
            this.milla = milla;
            this.acciones = acciones;
        }

        public int Milla { get => milla; set => milla = value; }
        internal List<Accion> Acciones { get => acciones; set => acciones = value; }
    }
}