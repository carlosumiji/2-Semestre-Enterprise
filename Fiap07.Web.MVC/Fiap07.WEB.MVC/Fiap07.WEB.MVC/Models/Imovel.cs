using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.WEB.MVC.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public string Endereco { get; set; }
        public decimal Valor { get; set; }

        //Relacionamento 1:1
        public Escritura Escritura { get; set; }
        //Foreign key
        public int EscrituraId { get; set; }

        //Relacionamento 1:N
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        //Relacionamento N:N
        public IList<Corretor> Corretores { get; set; }
    }
}