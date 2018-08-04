﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWord.UI.Model
{
    class Pessoa
    {
        //Campos
        private string _nome;

        //Propriedades (gets e sets)

        public float Peso { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }
    }
}
