using _01.Fiap.HelloWord.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWord.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um aluno
            Aluno aluno = new Aluno();
            aluno.Nome = "Jefty";//set
            Console.WriteLine(aluno.Nome);//get

        }
    }
}
