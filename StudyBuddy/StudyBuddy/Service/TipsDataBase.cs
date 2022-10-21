using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StudyBuddy.Service
{
    class TipsDataBase
    {
        private static ObservableCollection<Tip> tipsStudie = new ObservableCollection<Tip>(intitTipsStudie);

        public static ObservableCollection<Tip> getAllTipsStudie()
        {
            return tipsStudie;
        }

        private static List<Tip> intitTipsStudie
        {
            get
            {
                return new List<Tip>
                    {
                    new Tip { ID=1, tip= " Twijfels over je studie? Het is dan echt hoog tijd om eens met je SLB te gaan praten om te overleggen of je studie nog bij je past. De conclusie kan alle kanten op gaan, soms is het bespreken van het probleem genoeg om van de twijfels af te komen. Het heeft overigens ook geen zin om je tijd te verspillen aan iets dat je niet leuk vind. Moeite met studeren? Probeer deze app!",link="https://quizlet.com/" },
                    new Tip { ID=2, tip= "Stress en energie heeft invloed op je humeur. Sluit eerst uit dat je niet hongerig of gestrest bent. Eet een volle maaltijd met eiwitten en koolhydraten, neem wat rust en kijk of je je dan beter voelt.Voel je je toch constant ongelukkig? Dan is deze pagina interessant om eens te bekijken. ",link="https://www.optimalegezondheid.com/stemmingswisselingen-oorzaken-en-gevolgen/" },
                   new Tip { ID=3, tip= "Insomnia of slecht slapen is heel ingewikkeld. Het is nogal een reis om te zoeken waar het probleem ligt. Probeer deze meditatie, als dit helpt, geeft dat aan dat je hoofd te druk is.Denk je dat het probleem ergens anders ligt? Overweeg om een gesprek aan te gaan met je SLB.  ",link="https://youtu.be/aEqlQvczMJQ " },
                   new Tip { ID=4, tip= "Is het je humeur dat je afleidt? Probeer voor een week lang op te schrijven wat je de hele dag doet en voel je je voelt. Dit laat misschien een patroon zien van wat je humeur zo omlaag haalt.Leidt je omgeving je af? Hier zijn wat tips om van je thuis omgeving een werk omgeving te maken.  ",link="https://www.werktrends.nl/10-kenmerken-prettige-werkomgeving/  " },

                };
            }
        }
    }
}
