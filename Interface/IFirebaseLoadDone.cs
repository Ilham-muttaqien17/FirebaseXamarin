using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirebaseXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirebaseXamarin.Interface
{
    public interface IFirebaseLoadDone
    {
        void OnFirebaseLoadSuccess(List<ItemMovie> movieList);
        void OnFirebaseLoadFailed(string message);
    }
}