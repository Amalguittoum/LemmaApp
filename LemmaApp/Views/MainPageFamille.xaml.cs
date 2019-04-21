using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LemmaApp.Percistence;
using LemmaApp.Models;

namespace LemmaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageFamille : TabbedPage
    {
		public MainPageFamille()
		{
			InitializeComponent ();
  
		}

      /* async void go_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FamillePage()));
        }
        async void go1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AboutPage()));
        }
        async void go2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewLemmaPage()));
        }*/
    }
}