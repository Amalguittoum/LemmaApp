using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LemmaApp.Models;
[assembly: Xamarin.Forms.Dependency(typeof(LemmaApp.Services.LemmaManager))]
namespace LemmaApp.Services
{
    class LemmaManager
    {
        
        
            List<Lemma> lemmas;
            public LemmaManager()
            {
                lemmas = new List<Lemma>();
                var mockItems = new List<Lemma>
                {
                    /* new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                     new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                     new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                     new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                     */
                };

                foreach (var item in mockItems)
                {
                lemmas.Add(item);
                }
            }

            public async Task<bool> AddLemmaAsync(Lemma lemma)
            {
                  lemmas.Add(lemma);

                return await Task.FromResult(true);
            }

            public async Task<bool> UpdateLemmaAsync(Lemma lemma)
            {


                return await Task.FromResult(true);
            }

            public async Task<bool> CancelLemmaAsync(Lemma item)
            {


                return await Task.FromResult(true);
            }

            public async Task<Lemma> GetLemmaAsync(string id)
            {
                return await Task.FromResult(lemmas.FirstOrDefault(s => s.Id == id));
            }

            public async Task<IEnumerable<Lemma>> GetLemmaAsync(bool forceRefresh = false)
            {
                return await Task.FromResult(lemmas);
            }
            public async Task<bool> ActiverModeLemmaAsync()
            {
              return await Task.FromResult(true);
            }
            public async Task<bool> AcceptLemmaAsync(Lemma item)
        {


            return await Task.FromResult(true);
        }
    }
    }

