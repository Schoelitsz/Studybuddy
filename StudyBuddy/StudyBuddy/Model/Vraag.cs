using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyBuddy.Model
{
    public class Vraag
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string vraag { get; set; }
        public string vraagkeuze1 { get; set; }
        public string vraagkeuze2 { get; set; }
        public string vraagkeuze3 { get; set; }
        public string vraagkeuze4 { get; set; }

        public string antwoord { get; set; }


    }
}
