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
using ListExercise.Core.Oige;
using Microsoft.AspNetCore.JsonPatch.Internal;

namespace ListExercise
{
    [Activity(Label = "StarWarsListActivity")]
    public class StarWarsListActivity : ListActivity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.starwars_people_layout);

            var searchField = FindViewById<EditText>(Resource.Id.editText1);
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var searchButton = FindViewById<Button>(Resource.Id.button1);

            searchButton.Click += async delegate
            {
                var SearchText = searchField.Text;
                var queryString = "https://swapi.co/api/people/?search=" + SearchText;
                var data = await Core.Oige.DataService.GetStarWarsPeople(queryString);
                listView.Adapter = new StarWarsPeopleAdapter(this, data.Results);
            };

        }
    }
}