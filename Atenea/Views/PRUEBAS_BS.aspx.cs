using Atenea.Controllers;
using Atenea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atenea.Views
{
    public partial class PRUEBAS_BS : System.Web.UI.Page
    {
        Label txtIdioma;
        CIdiomas    cidioma     = new CIdiomas();
        CCategorias ccategoria  = new CCategorias();
        CPalabras   cpalabra    = new CPalabras();
        CDifinidoresDeCategoria cPDifCat    = new CDifinidoresDeCategoria();
        CDifinidoresDeIdioma    cPDifIdioma = new CDifinidoresDeIdioma();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Idioma
        protected void addBTNidioma(object sender, EventArgs e)
        {
            bool res = cidioma.Agregar(3,"MEXICANO");
            Idiomas x = new Idiomas();
            String txt;
            if (res == true && x != null)
            {
                x = cidioma.Select(3);
                txt = "Se agrego un idioma de ID: " + x.getID() + " Nombre:" + x.getNombre();
            }
            else
            {
                txt = "No se agrego ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void deleteBTNidioma(object sender, EventArgs e)
        {
            Idiomas x = cidioma.Select(3);
            bool res = cidioma.Borrar(3);
            String txt;
            if (res == true && x != null)
            {
                txt = "Se borro el idioma de ID: " + x.getID() + " Nombre:" + x.getNombre();
            }
            else
            {
                txt = "No se borro ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void modifyBTNidioma(object sender, EventArgs e)
        {
            Idiomas x1 = cidioma.Select(3);
            bool res = cidioma.Editar(3, "Frances");
            String txt;
            if (res == true && x1 != null)
            {
                Idiomas x2 = cidioma.Select(3);
                txt = "Se modifico el nombre del idioma de ID: " + x1.getID() + " Nombre:" + x1.getNombre()+ " a Nombre: "+ x2.getNombre();
            }
            else
            {
                txt = "No se cambio ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        // Categoria
        protected void addBTNcat(object sender, EventArgs e)
        {
            bool res = ccategoria.Agregar(0, "Deporte");
            Categorias[] x = new Categorias[1];
            String txt;
            if (res == true)
            {
                x = ccategoria.Select(0);
                txt = "Se agrego una categoria de ID: " + x[0].getID() + " Nombre:" + x[0].getNombre();
            }
            else
            {
                txt = "No se agrego ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void deleteBTNcat(object sender, EventArgs e)
        {
            Categorias[] x = ccategoria.Select(0);
            bool res = ccategoria.Borrar(0);
            String txt;
            if (res == true && x.Length != 0)
            {
                txt = "Se borro la categoria de ID: " + x[0].getID() + " Nombre:" + x[0].getNombre();
            }
            else
            {
                txt = "No se borro ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void modifyBTNcat(object sender, EventArgs e)
        {
            Categorias[] x1 = ccategoria.Select(0);
            bool res = ccategoria.Editar(0, "Farandula"); 
            String txt;
            if (res == true && x1.Length != 0)
            {
                Categorias[] x2 = ccategoria.Select(0);
                txt = "Se modifico la categoria de ID: " + x1[0].getID() + " Nombre:" + x1[0].getNombre() + " a Nombre: " + x2[0].getNombre();
            }
            else
            {
                txt = "No se cambio ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        // Palabras
        protected void addBTNplb(object sender, EventArgs e)
        {
            bool res = cpalabra.Agregar(0, "pelota",cidioma.Select(1));
            Palabras x = new Palabras();
            String txt;
            if (res == true)
            {
                x = cpalabra.Select(0);
                txt = "Se agrego una palabra de ID: " + x.getId() + " Nombre:" + x.getNombre() + " Idioma: " + x.getIdioma().getNombre();
            }
            else
            {
                txt = "No se agrego ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void deleteBTNplb(object sender, EventArgs e)
        { 
            Palabras x = cpalabra.Select(0);
            bool res = cpalabra.Borrar(0);
            String txt;
            if (res == true && x != null)
            {
                txt = "Se borro la palabra de ID: " + x.getId() + " Nombre:" + x.getNombre() + " Idioma: " + x.getIdioma().getNombre();
            }
            else
            {
                txt = "No se borro ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }

        protected void modifyBTNplb(object sender, EventArgs e)
        {
            Palabras x1 = cpalabra.Select(0);
            bool res = cpalabra.EditarNombre(0, "balon");
            String txt;
            if (res == true && x1 != null)
            {
                Palabras x2 = cpalabra.Select(0);
                txt = "Se modifico la categoria de ID: " + x1.getId() + " Nombre:" + x1.getNombre() + " a Nombre: " + x2.getNombre();
            }
            else
            {
                txt = "No se cambio ni picha";
            }
            Page.ClientScript.RegisterClientScriptBlock(typeof(string), "Popup", "window.alert(\"" + txt + "\");", true);
        }
    }
}