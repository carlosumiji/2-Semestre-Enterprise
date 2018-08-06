using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWord.UI.Model
{
    //classe abstrata : não pode ser intanciada e pode conter métodos abstratos
    abstract class Pessoa
    {
        //Construtor
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        //Campos
        private string _nome;

        //Propriedades (gets e sets)
        public float Peso { get; set; }

        public Genero Genero { get; set; }

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

        //métodos
        //virtual -> permite a sobrescrita de métodos
        public virtual void Estudar()
        {
            Console.WriteLine("Pessoa estudante");
        }

        public abstract void FazerProva(); 
    }
}
