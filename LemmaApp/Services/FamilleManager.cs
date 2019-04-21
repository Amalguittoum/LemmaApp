using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LemmaApp.Percistence;
using LemmaApp.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;

[assembly: Xamarin.Forms.Dependency(typeof(LemmaApp.Services.FamilleManager))]
namespace LemmaApp.Services
{
    class FamilleManager : IDataStoreObj<Famille>
    {

       
        public  FamilleManager()
        {
        



            var mockItems = new List<Famille>
            {
               new Famille { Id = Guid.NewGuid().ToString(), name = "Famille 02" },
               new Famille { Id = Guid.NewGuid().ToString(), name = "Famille 01" },


            };
         

        }

public  Task<bool> AddFamilleAsync(Famille famille)
{
            

           App.Database.SaveFamilleAsync(famille);

            return  Task.FromResult(true);
}

public async Task<bool> UpdateFamilleAsync(Famille famille)
{
     

    return await Task.FromResult(true);
}

public async Task<bool> DeleteFamilleAsync(Famille item)
{
    

    return await Task.FromResult(true);
}

public async Task<Famille> GetFamilleAsync(string id)
{
    return await App.Database.GetFamilleAsync(id);
}

public async Task<IEnumerable<Famille>> GetFamilleAsync(bool forceRefresh = false)
{
          return await App.Database.GetFamillesAsync();
 }
    }
}
