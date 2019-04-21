using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LemmaApp.Models;

namespace LemmaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewFamillePage : ContentPage
    {
        public Famille famille { get; set; }

        public NewFamillePage()
        {
            InitializeComponent();

           famille = new Famille
            {
               
               name = "give familly name."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddFamille",famille);
            await Navigation.PopModalAsync();
        }
    }
}