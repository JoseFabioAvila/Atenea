using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class DifinidoresDeCategoria : Palabras
    {
        Categoria cat;
        public DifinidoresDeCategoria(int id, String nom, Idioma idioma, Categoria categoria) : base(id, nom, idioma)
        {
            this.cat = categoria;
        }
    }
}