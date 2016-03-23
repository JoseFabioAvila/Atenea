using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Categorias : Clasificadores
    {
        public Categorias() { }

        public Categorias(int id, String nom) : base(id, nom)
        {

        }

    }
}