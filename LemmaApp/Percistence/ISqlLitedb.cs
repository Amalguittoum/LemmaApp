using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LemmaApp.Models;
using SQLite;

namespace LemmaApp.Percistence
{
    interface ISqlLitedb
    {
        Task<List<Famille>> GetFamillesAsync();
        Task<Famille> GetFamilleAsync(string id);
        Task<int> SaveFamilleAsync(Famille item);

    }
}
