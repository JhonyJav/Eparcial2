using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eparcial2
{
    public class Aves : Animal
    {
       
        string vuela1;
        string periodoincubacion;

        public string Vuela1 { get => vuela1; set => vuela1 = value; }
        public string Periodoincubacion { get => periodoincubacion; set => periodoincubacion = value; }
    }
    public class Serpientes : Animal
    {
        string serpiente;

        string venenosa;
        string lingitudmaxima;

        public string Serpiente { get => serpiente; set => serpiente = value; }
       
        public string Venenosa { get => venenosa; set => venenosa = value; }
        public string Lingitudmaxima { get => lingitudmaxima; set => lingitudmaxima = value; }

    }
    public class Animal
    {
        string animal1;
        string animal2;
        List<Aves>aves=new List<Aves>();
        List<Serpientes> serpientes=new List<Serpientes>();
        string nombrea;
        string especie;
        string tipoanimal;
        string vidamax;

        public string Nombrea { get => nombrea; set => nombrea = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Tipoanimal { get => tipoanimal; set => tipoanimal = value; }
        public string Vidamax { get => vidamax; set => vidamax = value; }
        public string Animal1 { get => animal1; set => animal1 = value; }   
        public string Animal2 { get => animal2; set => animal2 = value; }
        public List<Aves> Aves { get => aves; set => aves = value; }
        public List<Serpientes> Serpientes { get => serpientes; set => serpientes = value; }
       

        public Animal()
        {
            aves= new List<Aves> { };
            serpientes= new List<Serpientes> { };
        }



    }
}