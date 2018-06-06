using DepServices.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DepServices
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnMessage.Clicked += BtnMessage_Clicked;
            btnTextoVoz.Clicked += BtnTextoVoz_Clicked;
		}

        private void BtnTextoVoz_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextVoz>();
            service.Spek("Hola compañeritos Sena equisdé equisdé equisdé, tengo mucha hambre dos puntos v");
        }

        private async void BtnMessage_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatMessage>();
            var message = service.GetMessage();
            await DisplayAlert("Service", message, "ok");
        }
    }
}
