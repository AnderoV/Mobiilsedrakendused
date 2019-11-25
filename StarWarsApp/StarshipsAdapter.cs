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
    class StarshipsAdapter
    {
        public class StarWarsShipsAdapter : BaseAdapter<ResultStarships>
        {
            List<ResultStarships> _items;
            Activity _context;

            public StarWarsShipsAdapter(Activity context, List<ResultStarships> items) : base()
            {
                this._context = context;
                this._items = items;
            }

            public override ResultStarships this[int position]
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
                    view = _context.LayoutInflater.Inflate(Resource.Layout.starShips_row_layout, null);
                view.FindViewById<TextView>(Resource.Id.shipView1).Text = item.Name;
                view.FindViewById<TextView>(Resource.Id.shipView2).Text = item.Model;
                view.FindViewById<TextView>(Resource.Id.shipView3).Text = item.Manufacturer;

                return view;
            }
        }
    }
}