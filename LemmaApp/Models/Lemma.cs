using System;
using System.Collections.Generic;
using System.Text;

namespace LemmaApp.Models
{
   public class Lemma
    {
        public string Id { get; set; }
        public string theme { get; set; }
        public DateTime date { get; set; }
        public string lieu { get; set; }
        public string description{ get; set; }
  
        public string etat { get; set; }
    }
}
