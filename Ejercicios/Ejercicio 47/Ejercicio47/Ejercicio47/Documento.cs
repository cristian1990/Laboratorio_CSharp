﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Documento
    {
        protected int _numero;

        public int Numero
        {
            get{ return this._numero; }
        }

        public Documento(int numero)
        {
            this._numero = numero;
        }
    }
}
