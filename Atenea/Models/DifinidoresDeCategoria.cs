using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class DifinidoresDeCategoria : Palabras
    {
        Categorias cat;
        public DifinidoresDeCategoria(int id, String nom, Idiomas idioma, Categorias categoria) : base(id, nom, idioma)
        {
            this.cat = categoria;
        }

        public DifinidoresDeCategoria() { }
    }
}