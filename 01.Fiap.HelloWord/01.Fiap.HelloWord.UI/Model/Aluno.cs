﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWord.UI.Model
{
    class Aluno : Pessoa
    {
        //Construtor
        //ctor -> tab tabS
        public Aluno(string nome):base(nome)
        {   
        }

        //Propriedades
        public string Rm { get; set; }
        public bool Bolsista { get; set; }

        //Métodos sobrescrito
        public override void FazerProva()
        {
            Console.WriteLine("Aluno respondendo o teste");
        }

        public void Estudar()
        {
            Console.WriteLine("Aluno estudando muito");
        }
    }
}
