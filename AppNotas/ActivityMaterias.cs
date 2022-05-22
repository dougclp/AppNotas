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
    [Activity(Label = "ActivityMaterias")]
    public class ActivityMaterias : Activity
    {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListaMaterias);
          

            vlista = FindViewById<ListView>(Resource.Id.lista1);
            vlista.Adapter = new AdapterMateria(this, Global.materia.ToList());            
            vlista.ItemClick += Vlista_ItemClick;

          //  vlista = FindViewById<ListView>(Resource.Id.);

            // Create your application here
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityNombres));

            //Obtener el id de la region seleccionada
            Materia materia = Global.materia[e.Position];

            i.PutExtra("id", materia.Id);
            i.PutExtra("materia", materia.NombreMateria);
            StartActivity(i);
        }
    }
}