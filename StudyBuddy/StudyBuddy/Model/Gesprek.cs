using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyBuddy.Model
{
    public class Gesprek
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        public List<Vraag> vraag { get; set; }
        
    }
}
