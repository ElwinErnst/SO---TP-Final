namespace SO___TP_Final.Entities
{
    class Accion
    {
        string name;
        int movement;

        public Accion(){}

        public Accion(string name, int movement)
        {
            this.name = name;
            this.movement = movement;
        }
        public string Name { get => name; set => name = value; }
        public int Movement { get => movement; set => movement = value; }
    }
}