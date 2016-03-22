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
        private String Idioma;

        public Palabras(int id, String nom, Idioma idioma)
        {
            this.ID = id;
            this.Nombre = nom;
            this.Idioma = idioma;
        }

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

        public void setIdioma(String idioma)
        {
            this.Idioma = idioma;
        }

        public String getIdioma()
        {
            return this.Idioma;
        }
    }
}