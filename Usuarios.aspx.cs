using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BC = BCrypt.Net.BCrypt;

namespace TiendaEnLinea
{
    public partial class Usuarios : System.Web.UI.Page
    {
        static List<Usuario> usuarios = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //obtener la identidad del usuario acutalmente logueado
            var identidad = (FormsIdentity)Context.User.Identity;

            //Verificar el nivel que se le asigno cuando se creo el ticket de autenticacion al momento 
            //de hacer el login. Esos datos son string entonces el 1 va entre comillas "1"
            if (identidad.Ticket.UserData == "1")
            {
                string archivo = Server.MapPath("usuarios.json");
                if (File.Exists(archivo))
                {
                    StreamReader jsonStream = File.OpenText(archivo);
                    string json = jsonStream.ReadToEnd();
                    jsonStream.Close();

                    usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
                }
            }
            else
                Response.Redirect("Login/Logout", true);


        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(usuarios);
            string archivo = Server.MapPath("usuarios.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Username = TextBoxUsuario.Text;

            string miPassword = TextBoxPassword.Text;
            string miSal = BC.GenerateSalt();           
            string miHash = BC.HashPassword(miPassword, miSal);            
            

            usuario.Password = miHash;
            usuario.Nivel = Convert.ToInt32(RadioButtonListNivel.SelectedValue);

            usuarios.Add(usuario);

            Guardar();

        }
    }
}