
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;


namespace AppNotas
{
    class AdapterMateria : BaseAdapter
    {

        Activity context;
    
        List<Materia> lista;


        public AdapterMateria(Activity context, List<Materia> lista)
        {
            this.context = context;
            this.lista = lista;
        }
        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
            // return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //el elemento devuelto
            var item = lista[position];
            var listaEstudiantes = Global.estudiantes.Where(x => x.Idmateria == item.Id).ToList();
            var listaNotas = Global.nota.Where(x => x.IdMateria == item.Id).ToList();

            double suma = 0.0;
            foreach(var nota in listaNotas) {
                suma += nota.NotaFinal;
            }


            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.AdapterListViewMaterias, null);
            view.FindViewById<TextView>(Resource.Id.txtNombreMateria).Text = item.NombreMateria;
            view.FindViewById<TextView>(Resource.Id.).Text = $"Total de estudiantes: {listaEstudiantes.Count}    Nota Promedio: {System.Math.Round(suma/listaEstudiantes.Count,2)}";
            return view;

           
        }

        //Fill in cound here, currently 0
     

    }

}