using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Clasificador
    {
        private int ID;
        private String Nombre;
        private ArrayList Palabras = new ArrayList();

        public Clasificador(int id, String nom)
        {
            this.ID = id;
            this.Nombre = nom;
        }

        

        public int getID()
        {
            return this.ID;
        }

        public void setID(int id)
        {
            this.ID = id;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public void setNombre(String nom)
        {
            this.Nombre = nom;
        }

        public void setListaPalabras(ArrayList lst)
        {
            this.Palabras = lst;
        }

        public void addPalabra(Palabra p)
        {
            this.Palabras.Add(0);
        }

        public ArrayList getListaPalabras()
        {
            return this.Palabras;
        }
    }
}