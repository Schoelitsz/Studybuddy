using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudyBuddy.Service
{
   public class VraagHumeurDatabase
    {
        private static ObservableCollection<Vraag> vragenHumeur = new ObservableCollection<Vraag>(intitVragenStudie);

        public static ObservableCollection<Vraag> getAllVragenHumeur()
        {
            return vragenHumeur;
        }

        private static List<Vraag> intitVragenStudie
        {
            get
            {
                return new List<Vraag>
                    {
                    new Vraag { ID=1,vraag= " Wat voel je?",vraagkeuze1= "Verdriet",vraagkeuze2= "Boos" , vraagkeuze3= "Zenuwachtig", vraagkeuze4= "Leeg"},
                    new Vraag { ID=2,vraag= " Hoelang voel je je al zo?",vraagkeuze1= " Niet zo lang.",vraagkeuze2= "Een tijdje." , vraagkeuze3= "Best lang", vraagkeuze4= "Weet ik niet." },
                     new Vraag { ID=3,vraag= "Heeft het met een van de onderstaande te maken?",vraagkeuze1= "School",vraagkeuze2= "thuis" , vraagkeuze3= " Gezondheid", vraagkeuze4= "Weet ik niet" },

                };
            }
        }
    }
}
