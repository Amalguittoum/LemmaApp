using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LemmaApp.Services
{
    public interface IDataStoreObj<F>
    {
        Task<bool> AddFamilleAsync(F famille);
        Task<bool> UpdateFamilleAsync(F famille);
        //Task<bool> DeleteFamilleAsync(F famille);
        Task<F> GetFamilleAsync(string id);
        Task<IEnumerable<F>> GetFamilleAsync(bool forceRefresh = false);
    }
}
