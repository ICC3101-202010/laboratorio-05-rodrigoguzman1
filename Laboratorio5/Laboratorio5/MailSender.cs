﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    public class MailSender
    {
        public delegate void EmailSentEventHandler(object source, EventArgs args);

        public event EmailSentEventHandler EmailSent;

        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
            EmailSent(this, EventArgs.Empty);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }

    }
}