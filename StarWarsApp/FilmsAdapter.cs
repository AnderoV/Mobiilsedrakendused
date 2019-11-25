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
using StarWarsApp.Core.Models;

namespace StarWarsApp
{
    class FilmsAdapter
    {
        public class StarWarsFilmsAdapter : BaseAdapter<FilmResult>
        {
            List<FilmResult> _items;
            Activity _context;

            public StarWarsFilmsAdapter(Activity context, List<FilmResult> items) : base()
            {
                this._context = context;
                this._items = items;
            }

            public override FilmResult this[int position]
            {
                get { return _items[position]; }
            }

            public override int Count
            {
                get { return _items.Count; }
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = _items[position];

                View view = convertView;
                if (view == null)
                    view = _context.LayoutInflater.Inflate(Resource.Layout.Films_Layout, null);
                view.FindViewById<TextView>(Resource.Id.filmi_Nimi).Text = item.Title;
                view.FindViewById<TextView>(Resource.Id.filmi_Aasta).Text = item.release_date.ToString();
                view.FindViewById<TextView>(Resource.Id.filmi_Kirjeldus).Text = item.opening_crawl;

                return view;
            }
        }
    }
}