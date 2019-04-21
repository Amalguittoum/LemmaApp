using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LemmaApp.Models
{
    public class Famille
    {
        [PrimaryKey,AutoIncrement]
        public string Id { get; set; }
        public string name { get; set; }
        //public Auteur auteur { get; set; }
    }
}
