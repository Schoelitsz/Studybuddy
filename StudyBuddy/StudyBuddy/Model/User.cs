using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyBuddy.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(25)]
        public string Naam { get; set; }
        [MaxLength(100)]
        public string EmailAdres { get; set; }
        [MaxLength(100)]
        public string Wachtwoord { get; set; }
        [MaxLength(15)]
        public string Opleiding { get; set; }
        [MaxLength(100)]
        public string Sterkepunt { get; set; }
        [MaxLength(100)]
        public string Zwakkepunt { get; set; }

        
    }
}
