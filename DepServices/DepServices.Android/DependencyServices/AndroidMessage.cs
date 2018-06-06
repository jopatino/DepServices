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
using Xamarin.Forms;
using DepServices.DependencyServices;
using DepServices.Droid.DependencyServices;

[assembly:Dependency(typeof(AndroidMessage))]
namespace DepServices.Droid.DependencyServices
{
    public class AndroidMessage: IPlatMessage
    {
        public string GetMessage()
        {
            return "Estoy desde Android";
        }
    }
}