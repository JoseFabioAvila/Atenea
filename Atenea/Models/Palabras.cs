using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Palabras
    {
        private int ID;
        private String Nombre;
        private Idiomas Idioma;

        public Palabras(int id, String nom, Idiomas idioma)
        {
            this.ID = id;
            this.Nombre = nom;
            this.Idioma = idioma;
        }

        public Palabras() { }

        public void setId(int ID)
        {
            this.ID = ID;
        }

        public int getId()
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