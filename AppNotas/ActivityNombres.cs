using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNotas
{
    [Activity(Label = "ActivityNombres")]
    public class ActivityNombres : Activity
    {
        ListView vlista;
        TextView txtMateria;
        int idMateria;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListaNombres);

            vlista = FindViewById<ListView>(Resource.Id.lista1);
            txtMateria = FindViewById<TextView>(Resource.Id.nombreMateria);

            idMateria =Intent.GetIntExtra("id", 0);
            string materia = Intent.GetStringExtra("materia");

            txtMateria.Text = materia;

            vlista.Adapter = new AdapterNombres(this, Global.estudiantes.Where(x=>x.Idmateria==idMateria).ToList());
            vlista.ItemClick += Vlista_ItemClick;

            // Create your application here
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityNotas));

            //Obtener el id de la region seleccionada
            Estudiante estudiante = Global.estudiantes[e.Position];

            i.PutExtra("id", estudiante.Id);
            i.PutExtra("idMateria", idMateria);
            i.PutExtra("nombre", estudiante.PrimerNombre + " " + estudiante.SegundoNombre + " " + estudiante.Apellidos);
            StartActivity(i);
        }
    }
}