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

namespace CarListExercise
{
    public class BasicAdapter : BaseAdapter<CarInfo>
    {
        List<CarInfo> _items;
        Activity _context;

        public BasicAdapter(Activity context, List<CarInfo> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override CarInfo this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.car_row, null);
            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Manufacturer;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = item.Model;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = item.Year;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = item.kW;

            return view;
        }
    }
}