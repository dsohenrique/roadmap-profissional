using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Mvc.Models
{
    public class Curso
    {
        public int CursoID { get; set; }

        public string Nome { get; set; }

        public int UniversidadeID { get; set; }

        public virtual Universidade Universidade { get; set; }
    }
}