using System;
namespace Solucion_Lab_21_abril
{
    public class User
    {

        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("¿Desea verificar su correo?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    EmailVerified(this, EventArgs.Empty);
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }

    }
}
