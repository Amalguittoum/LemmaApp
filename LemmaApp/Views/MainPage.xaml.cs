using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LemmaApp.Percistence;
using LemmaApp.Models;

namespace LemmaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
    {
		public MainPage ()
		{
			InitializeComponent ();
  
		}

       async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new registration()));
        }
        async void OnClickedLogin(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FamillePage()));
        }

    }
}