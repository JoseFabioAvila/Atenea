using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Idiomas : Clasificadores
    {
        private long v1;
        private string v2;

        public Idiomas(int id, String nom) : base(id, nom)
        {
             
        }
        public Idiomas() { }

        public Idiomas(long v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}