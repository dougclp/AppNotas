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
    [Activity(Label = "ActivityNotas")]
    public class ActivityNotas : Activity
    {
        ListView vlista;
        TextView txtNombreEst;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListaNotas);

            int idMateria = Intent.GetIntExtra("idMateria", 0);
            vlista = FindViewById<ListView>(Resource.Id.lista1);

            int idEstudiante = Intent.GetIntExtra("id", 0);
       

            vlista.Adapter = new AdapterNotas(this, Global.nota.Where(x=>x.IdMateria==idMateria).Where(y=>y.IdEstudiante==idEstudiante).ToList());
          

        }

        
    }
}