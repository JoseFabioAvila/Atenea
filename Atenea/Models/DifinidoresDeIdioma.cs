using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class DifinidoresDeIdioma : Palabras
    {
        public DifinidoresDeIdioma(int id, String nom, Idiomas idioma) : base(id, nom, idioma)
        {

        }

        public DifinidoresDeIdioma() { }
    }
}