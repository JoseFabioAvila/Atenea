using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Palabra
    {
        private int ID;
        private String Nombre, Idioma;

        public Palabra(int id, String nom, String idioma)
        {
            this.ID = id;
            this.Nombre = nom;
            this.Idioma = idioma;
        }

        public void setID(int id)
        {
            this.ID = id;
        }

        public int getID()
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