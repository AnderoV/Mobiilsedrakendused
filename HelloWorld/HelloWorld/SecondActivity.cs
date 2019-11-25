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

namespace HelloWorld
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        TextView _textView;
        Button _button;
        EditText _textField;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            // Create your application here
            _textView = FindViewById<TextView>(Resource.Id.textView1);
            _button = FindViewById<Button>(Resource.Id.button1);
            _textField = FindViewById<EditText>(Resource.Id.editText1);

        }

        private void Button_Click(object sender, EventArgs e)
        {
            _textView.Text = "Teskt muutus!";
            _textView.Text = _textField.Text;
        }
    }
}