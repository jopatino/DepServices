using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepServices.DependencyServices;
using DepServices.iOS.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;
[assembly:Dependency(typeof(IOSMessage))]
namespace DepServices.iOS.DependencyServices
{
    public class IOSMessage: IPlatMessage
    {
        public string GetMessage()
        {
            return "Esto es desde IOS";
        }
    }
}