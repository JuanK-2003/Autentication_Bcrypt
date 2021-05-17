using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaEnLinea
{
    public partial class Tienda : System.Web.UI.Page
    {
        static List<Producto> productos = new List<Producto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("productos.json");

                if (File.Exists(archivo))
                {
                    StreamReader jsonStream = File.OpenText(archivo);

                    //se lee todo el contenido del archivo y el contenido se guarda en la variable json
                    string json = jsonStream.ReadToEnd();

                    jsonStream.Close();

                    //Se deserializa (convierte) la cadena json en la estructura que tiene la lista universidades
                    productos = JsonConvert.DeserializeObject<List<Producto>>(json);

                    GridViewProductos.DataSource = productos;
                    GridViewProductos.DataBind();

                    GridView1.DataSource = productos;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridViewProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}