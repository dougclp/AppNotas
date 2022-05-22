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
    class AdapterNotas : BaseAdapter
    {


        Activity context;
        List<Nota> lista;

        public AdapterNotas(Activity context, List<Nota>lista)
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
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = $"Primer nota: {item.PrimerNota}    Segunda Nota: {item.SegundaNota}";
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = $"Promedio de nota: {item.NotaFinal}";


            return view;
        }

        //Fill in cound here, currently 0
       

    }

    class AdapterNotasViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}