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
    public partial class IngresoProducto : System.Web.UI.Page
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
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Codigo = TextBoxCodigo.Text;
            producto.Descripcion = TextBoxDescripcion.Text;
            producto.Marca = TextBoxMarca.Text;
            producto.Existencia = Convert.ToInt32(TextBoxExistencia.Text);


            //En donde está actualmente el archivo original
            string archivoOrigen = Path.GetFileName(FileUploadImagen.FileName);            

            //intentar subir el archivo a la carpeta de imagenes
            try
            {
                FileUploadImagen.SaveAs(Server.MapPath("~/imagenes/") + archivoOrigen);
                LabelEstado.Text = "Exitosamente Subido";
            }
            //si el intento falló
            catch (Exception ex)
            {
                LabelEstado.Text = "No se pudo subir, se generó el siguiente error:  " + ex.Message;
            }

            //En donde quedo guardado el archivo para ese dato guardar en el json
            string archivo = "~/imagenes/"+FileUploadImagen.FileName;
            producto.Imagen = archivo;




            productos.Add(producto);

            Guardar();

        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(productos);
            string archivo = Server.MapPath("productos.json");
            System.IO.File.WriteAllText(archivo, json);
            
        }
    }
}