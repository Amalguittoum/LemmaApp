using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LemmaApp.Models;

namespace LemmaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPublicationPage : ContentPage
    {
        public Publication pub { get; set; }

        public NewPublicationPage()
        {
            InitializeComponent();

          pub = new Publication
            {
               
              
              description="Description"
          

           };

            BindingContext = this;
        }

      /*  async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddFamille",famille);
            await Navigation.PopModalAsync();
        }*/
    }
}