using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LemmaApp.Models;
 
namespace LemmaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewLemmaPage : ContentPage
    {
        public Lemma lemma { get; set; }

        public NewLemmaPage()
        {
            InitializeComponent();

           lemma = new Lemma
            {
               
              theme = "Thème.",
              lieu="Lieu",
              description="Description",
               date=DateTime.Now

           };

            BindingContext = this;
        }

       /*public void OnClickedLemma(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("test1", "test");
        }*/
    }
}