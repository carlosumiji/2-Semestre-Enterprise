﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWord.UI.Model
{
    class Professor : Pessoa
    {
        public string Pf { get; set; }
        public IList<string> Disciplinas { get; set; }

    }
}
