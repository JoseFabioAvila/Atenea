using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Palabras
    {
        private long ID;
        private String Nombre;
        private Idiomas Idioma;

        public Palabras(long id, String nom, Idiomas idioma)
        {
            this.ID = id;
            this.Nombre = nom;
            this.Idioma = idioma;
        }

        public Palabras() { }

        public void setId(long id)
        {
            this.ID = id;
        }

        public long getId()
        {
            return this.ID;
        }

        public void setNombre(String nom)
        {
            this.Nombre = nom;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public void setIdioma(Idiomas idioma)
        {
            this.Idioma = idioma;
        }

        public Idiomas getIdioma()
        {
            return this.Idioma;
        }
    }
}