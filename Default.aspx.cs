using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eparcial2
{
    public partial class _Default : Page
    {
        static List<Animal> animals = new List<Animal>();
        static List<Aves> aves1= new List<Aves>();
        static List<Serpientes>serpientes1= new List<Serpientes>();

        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(animals);
            string archivo = Server.MapPath("animales.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1animal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Nombrea=TextBox1.Text;
            animal.Especie = TextBox2.Text;
            animal.Tipoanimal= TextBox3.Text;
            animal.Vidamax = TextBox4.Text;
            GuardarJson();
            animals.Add(animal);
        }

        protected void Button1ave_Click(object sender, EventArgs e)
        {
            Aves aves = new Aves();
            aves.Vuela1= TextBox5.Text;
            aves.Periodoincubacion= TextBox6.Text;
            aves1.Add(aves);
            GuardarJson();

        }

        protected void Button1serpiente_Click(object sender, EventArgs e)
        {
            Serpientes serpientes = new Serpientes();
            serpientes.Venenosa=TextBox7.Text;
            serpientes.Lingitudmaxima=TextBox8.Text;
            serpientes1.Add(serpientes);
            GuardarJson();

        }
    }
}