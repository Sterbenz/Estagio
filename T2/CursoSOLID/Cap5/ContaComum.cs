﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSOLID.Cap5
{
    class ContaComum
    {
        private ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }
    }
}