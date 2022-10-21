using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudyBuddy.Service
{
    public class VraagSlapenDatabase
    {
        private static ObservableCollection<Vraag> vragenSlapen = new ObservableCollection<Vraag>(intitVragenStudie);

        public static ObservableCollection<Vraag> getAllVragenSlapen()
        {
            return vragenSlapen;
        }

        private static List<Vraag> intitVragenStudie
        {
            get
            {
                return new List<Vraag>
                    {
                    new Vraag { ID=1,vraag= " Wat bedoel je precies met niet slapen?",vraagkeuze1= "Ik lig de hele nacht wakker.",vraagkeuze2= "Ik wordt meerdere keren per nacht wakker." , vraagkeuze3= "Het duurt lang voordat ik slaap val, maar slaap wel in de ochtend", vraagkeuze4= "Een beetje van alles eigenlijk." },
                    new Vraag { ID=2,vraag= " Hoelang is dat al zo?",vraagkeuze1= " Niet zo lang.",vraagkeuze2= "Een tijdje." , vraagkeuze3= "Best lang", vraagkeuze4= "Weet ik niet." },
                     new Vraag { ID=3,vraag= "Klinkt een van deze situaties bekend?",vraagkeuze1= "Er spoken veel gedachten rond in mijn hoofd als ik in bed lig.",vraagkeuze2= " Ik heb hoofdpijn aan het eind van de dag." , vraagkeuze3= " Ik let op alles wat om me heen gebeurd als ik probeer te slapen.", vraagkeuze4= "Mijn humeur veranderd als ik probeer te slapen." },

                };
            }
        }
    }
}

