using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Clasificadores
    {
        public int ID;
        public String Nombre;

        public Clasificadores(int id,String nom)
        {
            this.ID = id;
            this.Nombre = nom;
        }

        public int getID()
        {
            return this.ID;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public void setID(int id)
        {
            this.ID = id;
        }

        public void setNom(String nom)
        {
            this.Nombre = nom;
        }
    }
}