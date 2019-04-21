using System;
using System.Collections.Generic;
using System.Text;

namespace LemmaApp.Models
{
    class Commentaire
    {
        public string Id { get; set; }
        public string description{ get; set; }
        public Auteur auteur { get; set; }
    }
}
