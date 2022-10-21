using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyBuddy.Model
{
   public class Tip
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string tip { get; set; }
        public string link { get; set; }
    }
}
