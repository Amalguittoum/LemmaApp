using LemmaApp.Percistence;
using System;
using System.Collections.Generic;
using SQLite;
using System.Text;
using System.IO;
using LemmaApp.Models;
using System.Threading.Tasks;

[assembly : Xamarin.Forms.Dependency(typeof(BDD))]
namespace LemmaApp.Percistence
{
    public class BDD : ISqlLitedb
    {
       
        readonly SQLiteAsyncConnection database;

        public BDD(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Famille>().Wait();
        }

     
        public Task<List<Famille>> GetFamillesAsync()
        {
            return database.Table<Famille>().ToListAsync();
        }


        public  Task<Famille> GetFamilleAsync(string id)
        {
            
            return database.Table<Famille>().Where(i => i.Id.CompareTo(id) == 0).FirstOrDefaultAsync();
        }

        public Task<int> SaveFamilleAsync(Famille item)
        {
           
                return database.InsertAsync(item);
            
        }

        public Task<int> DeleteFamilleAsync(Famille item)
        {
            return database.DeleteAsync(item);
        }
    }
}
