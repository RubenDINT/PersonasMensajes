﻿using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;

namespace Personas.mensajeria
{
    internal class AgregarNacionalidadMessage : ValueChangedMessage<String>
    {
        public AgregarNacionalidadMessage(String texto) : base(texto)
        {
        }
    }
}