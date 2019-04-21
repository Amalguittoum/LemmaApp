using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using LemmaApp.Models;
using LemmaApp.Views;

namespace LemmaApp.ViewModels
{
    public class FamilleViewModel : BaseViewModelF
    {
        public ObservableCollection<Famille> familles { get; set; }
        public Command LoadItemsCommand { get; set; }

        public FamilleViewModel()
        {
            Title = "Browse";
            familles = new ObservableCollection<Famille>();
           //Famille famille1 = new Famille { Id = "0", name = "Famille 02" };

           // App.Database.SaveFamilleAsync(famille1);
            // famille1 = new Famille { Id = "1", name = "Famille 01" };
           // App.Database.SaveItemAsync(famille1);
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewFamillePage, Famille>(this, "AddFamille", (obj, famille) =>
            {
                var _famille = famille as Famille;
                familles.Add(_famille);
                DataStore.AddFamilleAsync(_famille);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
               familles.Clear();
          
       
            var items = await DataStore.GetFamilleAsync(true);
                foreach (var item in items)
                {
                    familles.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}