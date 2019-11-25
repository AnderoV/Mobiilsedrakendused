using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;
using static StarWarsApp.PeopleAdapter;
using static StarWarsApp.StarshipsAdapter;
using static StarWarsApp.PlanetsAdapter;
using Android.Content;
using System;

namespace StarWarsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var starShipsButton = FindViewById<Button>(Resource.Id.StarShipsButton);
            var planetsButton = FindViewById<Button>(Resource.Id.planetsButton);
            var peopleButton = FindViewById<Button>(Resource.Id.peopleSearch);
            var filmsButton = FindViewById<Button>(Resource.Id.filmsButton);

            starShipsButton.Click += StarShips_search;

            void StarShips_search(object sender, EventArgs e) 
            {
                var shipsActivity = new Intent(this, typeof(StarShipsActivity));
                StartActivity(shipsActivity);
            };

            peopleButton.Click += people_Search;

            void people_Search(object sender, EventArgs e)
            {
                var peopleActivity = new Intent(this, typeof(PeopleActivity));
                StartActivity(peopleActivity);
            }

            planetsButton.Click += planets_Search;

            void planets_Search(object sender, EventArgs e)
            {
                var planetsActivity = new Intent(this, typeof(PlanetsActivity));
                StartActivity(planetsActivity);
            }

            filmsButton.Click += films_Search;

            void films_Search(object sender, EventArgs e)
            {
                var filmsActivity = new Intent(this, typeof(FilmsActivity));
                StartActivity(filmsActivity);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}