using System;
using System.Collections.Generic;
using System.Text;

namespace LemmaApp.Models
{
    class Invitation
    {
        public string Id { get; set; }
        public Auteur auteur { get; set; }
        public string etat { get; set; }
    }
}
