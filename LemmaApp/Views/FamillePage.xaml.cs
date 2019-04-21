using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LemmaApp.Models;
using LemmaApp.Views;
using LemmaApp.ViewModels;
using System.Collections.ObjectModel;

namespace LemmaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FamillePage : ContentPage
	{
       FamilleViewModel viewModel1;

        public FamillePage()
        {
            InitializeComponent();

            BindingContext = viewModel1 = new FamilleViewModel();
        }

        async void OnItemSelected(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPageFamille()));
        }
        
        async void AddFamille_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewFamillePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel1.familles.Count == 0)
                viewModel1.LoadItemsCommand.Execute(null);
        
        }
    }
}