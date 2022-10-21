using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudyBuddy.Service
{
    public class VraagStudieDatabase
    {


        private static ObservableCollection<Vraag> vragenStudie = new ObservableCollection<Vraag>(intitVragenStudie);
       
        public static ObservableCollection<Vraag> getAllVragenStudie()
        {
            return vragenStudie;
        }
     
        private static List<Vraag> intitVragenStudie
        {
            get
            {
                return new List<Vraag>
                    {
                    new Vraag { ID=1,vraag= " Op welke vlakken heb je moeite met studeren?",vraagkeuze1= "Concentratie",vraagkeuze2= "Studeren voor een toets." , vraagkeuze3= "Praktisch begrip van de opdrachten.", vraagkeuze4= "Samenwerking met anderen." },
                    new Vraag { ID=2,vraag= "Met wie praat je het liefst hierover?",vraagkeuze1= "Medestudenten",vraagkeuze2= "Ouders" , vraagkeuze3= "Docenten", vraagkeuze4= "Niemand, eigenlijk." },
                     new Vraag { ID=3,vraag= "Hoe voel je je nu over de opleiding??",vraagkeuze1= "Mijn opleiding hoort bij mijn passie.",vraagkeuze2= "Ik hou mij er graag mee bezig." , vraagkeuze3= " Ik ben liever met andere dingen bezig.", vraagkeuze4= " De opleiding irriteert me of zit mij dwars" },

                };
            }
        }

    }
}
