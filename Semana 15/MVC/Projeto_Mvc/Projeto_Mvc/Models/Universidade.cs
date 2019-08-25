﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Mvc.Models
{
    public class Universidade
    {
        public int UniversidadeID { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}