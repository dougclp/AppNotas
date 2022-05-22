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
    class AdapterNombres : BaseAdapter
    {

        Activity context;
        List<Estudiante> lista;

        public AdapterNombres(Activity context, List<Estudiante> lista)
        {
            this.context = context;
            this.lista = lista;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override int Count => lista.Count;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            //el elemento devuelto
            var item = lista[position];

            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItemActivated1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.PrimerNombre +" "+ item.SegundoNombre +" "+ item.Apellidos;
           
            return view;
        }

        //Fill in cound here, currently 0
       

    }

    class AdapterNombresViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}