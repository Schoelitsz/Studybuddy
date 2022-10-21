using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudyBuddy.Service
{
  public class VraagConcentratieDatabase
    {
        private static ObservableCollection<Vraag> vragenConcentratie = new ObservableCollection<Vraag>(intitVragenStudie);

        public static ObservableCollection<Vraag> getAllVragenConcentratie()
        {
            return vragenConcentratie;
        }

        private static List<Vraag> intitVragenStudie
        {
            get
            {
                return new List<Vraag>
                    {
                    new Vraag { ID=1,vraag= " Wat gebeurd er precies?",vraagkeuze1= "Ik raak snel afgeleid",vraagkeuze2= "Mijn gedachte zijn ergens anders." , vraagkeuze3= "Mijn omgeving is onrustig.", vraagkeuze4= "Ik voel me niet goed." },
                    new Vraag { ID=2,vraag= " Is dit alleen met school of ook met andere dingen?",vraagkeuze1= " Alleen met school.",vraagkeuze2= "Ik kan me ook niet op andere dingen concentreren." , vraagkeuze3= " ", vraagkeuze4= " " },
                     new Vraag { ID=3,vraag= "Heb je ook last van een van deze?",vraagkeuze1= "Nare gevoelens",vraagkeuze2= "Hoofdpijnen" , vraagkeuze3= " Negatieve gevoelens over de opleiding.", vraagkeuze4= "Andere dingen zijn interessaner." },

                };
            }
        }
    }
}
