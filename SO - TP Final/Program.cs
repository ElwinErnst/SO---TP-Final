using System;
using System.Threading;
using SO___TP_Final.Controladores;

namespace SO___TP_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            Control.inicializandoCorredores();
            Thread threadTortuga = new Thread(Control.carreraTortuga);
            Thread threadLiebre = new Thread(Control.carreraLiebre);
            threadLiebre.Start();
            threadTortuga.Start();
            Console.ReadKey();
        }
    }
}
