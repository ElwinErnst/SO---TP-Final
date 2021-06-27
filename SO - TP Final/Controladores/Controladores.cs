using System;
using System.Threading;
using SO___TP_Final.Entities;

namespace SO___TP_Final.Controladores 
{

    class Control
    {
        public static Animal tortuga = new Animal();
        public static Animal liebre = new Animal();
        public static Random r_liebre = new Random();
        public static Random r_tortuga = new Random();

        public static void inicializandoCorredores()
        {

            liebre.Mile = 0;
            tortuga.Mile = 0;

            Accion a = new Accion("Avance rapido", 3);
            Accion b = new Accion("Resbalo", -6);
            Accion c = new Accion("Avance lento", 1);

            Accion d = new Accion("Duerme", 0);
            Accion e = new Accion("Gran salto", 9);
            Accion f = new Accion("Resbalon grande", -12);
            Accion g = new Accion("Pequeño salto", 1);
            Accion h = new Accion("Resbalon pequeño", -2);

            tortuga.Acciones.Add(a);
            tortuga.Acciones.Add(b);
            tortuga.Acciones.Add(c);

            liebre.Acciones.Add(d);
            liebre.Acciones.Add(e);
            liebre.Acciones.Add(f);
            liebre.Acciones.Add(g);
            liebre.Acciones.Add(h);
        }

        public static void carreraLiebre()
        {
            while(true)
            {
                if (liebre.Mile >= 70)
                {
                    Console.WriteLine("gano la liebre");
                    break;
                }

                liebre.Mile += generarAccionLiebre().Movement;

                if (liebre.Mile < 1)
                {
                    liebre.Mile = 0;
                }
                Console.WriteLine($"L: {liebre.Mile}, {generarAccionLiebre().Name}");
                Thread.Sleep(1000);
            }
        }

        public static void carreraTortuga()
        {
            while (true)
            {
                if (tortuga.Mile >= 70)
                {
                    Console.WriteLine("gano la tortuga");
                    break;
                }

                tortuga.Mile += generarAccionTortuga().Movement;

                if (tortuga.Mile < 1)
                {
                    tortuga.Mile = 0;
                }
                Console.WriteLine($"T: {tortuga.Mile}, {generarAccionTortuga().Name}");
                Thread.Sleep(1000);
            }
        }

        static Accion generarAccionLiebre()
        {
            Accion sig_accion_liebre = new Accion();
            int accion_liebre = r_liebre.Next(1, 101);

            if (accion_liebre >= 1 && accion_liebre < 20)
            {
                sig_accion_liebre = liebre.Acciones[0];
            }
            else if (accion_liebre >= 20 && accion_liebre < 40)
            {
                sig_accion_liebre = liebre.Acciones[1];
            }
            else if (accion_liebre >= 40 && accion_liebre < 50)
            {
                sig_accion_liebre = liebre.Acciones[2];
            }
            else if (accion_liebre >= 50 && accion_liebre < 80)
            {
                sig_accion_liebre = liebre.Acciones[3];
            }
            else if (accion_liebre >= 80 && accion_liebre < 100)
            {
                sig_accion_liebre = liebre.Acciones[4];
            }
            return sig_accion_liebre;
        }

        static Accion generarAccionTortuga()
        {
            Accion sig_accion_tortuga = new Accion();
            int accion_tortuga = r_tortuga.Next(1, 101);

            if (accion_tortuga >= 1 && accion_tortuga < 50)
            {
                sig_accion_tortuga = tortuga.Acciones[0];
            }
            else if (accion_tortuga >= 50 && accion_tortuga < 70)
            {
                sig_accion_tortuga = tortuga.Acciones[1];
            }
            else if (accion_tortuga >= 70 && accion_tortuga < 100)
            {
                sig_accion_tortuga = tortuga.Acciones[2];
            }
            return sig_accion_tortuga;
        }
    }
}
