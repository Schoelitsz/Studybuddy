using StudyBuddy.Model;
using StudyBuddy.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Xamarin.Essentials;

namespace StudyBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetstalkPage1 : ContentPage
    {
       private SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
        
        
        private ObservableCollection<Vraag> vraagStudieDatabase;
        private ObservableCollection<Vraag> vraagHumeurDatabase;
        private ObservableCollection<Vraag> vraagSlapenDatabase;
        private ObservableCollection<Vraag> vraagConcentratieDatabase;
        private ObservableCollection<Tip> tipsDatabase;
        public LetstalkPage1()
        {
            InitializeComponent();

           
            

            Device.StartTimer(new TimeSpan(0, 0, 2), () =>
            {
                Fram2.IsVisible = true;
                IconsStackLayout.IsVisible = true;
                return false;
            });
            

        }
        
        private void Prima_Clicked(object sender, EventArgs e)
        {
            PrimaStackLayout.IsVisible = true;
            Fram3.IsVisible = true;
            Slecht.IsEnabled = false;
            Device.StartTimer(new TimeSpan(0, 0, 2), () =>
            {
                Fram4.IsVisible = true;
                return false;
            });



            //using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            //{
            //    Vraag vraag = new Vraag() { vraag = vraag1.Text, antwoord = "Prima" };
            //    Gesprek gesprek = new Gesprek();
            //    connection.CreateTable<Gesprek>();
            //    gesprek.vraag.Add(vraag);
                
            //    connection.Insert(gesprek);

            //    //connection.CreateTable<Vraag>();
            //    //connection.Insert(vraag);

            //}

        }
    

        private void Goed_Clicked(object sender, EventArgs e)
        {

        }

        private void NietGoed_Clicked(object sender, EventArgs e)
        {

        }

        private void Slecht_Clicked(object sender, EventArgs e)
        {
            slechtStackLayout.IsVisible = true;
            Prima.IsEnabled = false;
            Device.StartTimer(new TimeSpan(0, 0, 2), () =>
            {
                StackLayoutHelpen.IsVisible = true;

                return false;
            });
        }

        private void PrimaAntwoordVraag1_Clicked(object sender, EventArgs e)
        {
            Fram5.IsVisible = true;

         


        }

        private void PrimaAntwoordVraag2_Clicked(object sender, EventArgs e)
        {
            Fram6.IsVisible = true;
          
        }

        private void PrimaAntwoordVraag3_Clicked(object sender, EventArgs e)
        {
            
            Fram7.IsVisible = true;
          
        }

        private void PrimaAntwoordVraag4_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Stuidevragen_Clicked(object sender, EventArgs e)
        {
            SlapenvragenBut.IsEnabled = false;
            HumeurvragenBut.IsEnabled = false;
            ConcentratievragenBut.IsEnabled = false;
            VragenStackLayout.IsVisible = true;
            vraag1StackLayout.IsVisible = true;
            vraagStudieDatabase = VraagStudieDatabase.getAllVragenStudie();
            LabVraag1.Text = vraagStudieDatabase[0].vraag;
            Labelkeuze1.Text = vraagStudieDatabase[0].vraagkeuze1;
            Labelkeuze2.Text = vraagStudieDatabase[0].vraagkeuze2;
            Labelkeuze3.Text = vraagStudieDatabase[0].vraagkeuze3;
            Labelkeuze4.Text = vraagStudieDatabase[0].vraagkeuze4;
            LabVraag2.Text = vraagStudieDatabase[1].vraag;
            Labelkeuze12.Text = vraagStudieDatabase[1].vraagkeuze1;
            Labelkeuze22.Text = vraagStudieDatabase[1].vraagkeuze2;
            Labelkeuze32.Text = vraagStudieDatabase[1].vraagkeuze3;
            Labelkeuze42.Text = vraagStudieDatabase[1].vraagkeuze4;
            LabVraag3.Text = vraagStudieDatabase[2].vraag;
            Labelkeuze13.Text = vraagStudieDatabase[2].vraagkeuze1;
            Labelkeuze23.Text = vraagStudieDatabase[2].vraagkeuze2;
            Labelkeuze33.Text = vraagStudieDatabase[2].vraagkeuze3;
            Labelkeuze43.Text = vraagStudieDatabase[2].vraagkeuze4;
            

        }

        private void sendAntwoord1_Clicked(object sender, EventArgs e)
        {
            vraag2StackLayout.IsVisible = true;  
           
        }

        private void sendAntwoord2_Clicked(object sender, EventArgs e)
        {
            vraag3StackLayout.IsVisible = true;
        }

      

       

        private void HumeurvragenBut_Clicked(object sender, EventArgs e)
        {
            Stuidevragen.IsEnabled = false;
            SlapenvragenBut.IsEnabled = false;
            ConcentratievragenBut.IsEnabled = false;
            VragenStackLayout.IsVisible = true;
            vraag1StackLayout.IsVisible = true;
            vraagHumeurDatabase = VraagHumeurDatabase.getAllVragenHumeur();
            LabVraag1.Text = vraagHumeurDatabase[0].vraag;
            Labelkeuze1.Text = vraagHumeurDatabase[0].vraagkeuze1;
            Labelkeuze2.Text = vraagHumeurDatabase[0].vraagkeuze2;
            Labelkeuze3.Text = vraagHumeurDatabase[0].vraagkeuze3;
            Labelkeuze4.Text = vraagHumeurDatabase[0].vraagkeuze4;
            LabVraag2.Text = vraagHumeurDatabase[1].vraag;
            Labelkeuze12.Text = vraagHumeurDatabase[1].vraagkeuze1;
            Labelkeuze22.Text = vraagHumeurDatabase[1].vraagkeuze2;
            Labelkeuze32.Text = vraagHumeurDatabase[1].vraagkeuze3;
            Labelkeuze42.Text = vraagHumeurDatabase[1].vraagkeuze4;
            LabVraag3.Text = vraagHumeurDatabase[2].vraag;
            Labelkeuze13.Text = vraagHumeurDatabase[2].vraagkeuze1;
            Labelkeuze23.Text = vraagHumeurDatabase[2].vraagkeuze2;
            Labelkeuze33.Text = vraagHumeurDatabase[2].vraagkeuze3;
            Labelkeuze43.Text = vraagHumeurDatabase[2].vraagkeuze4;

        }

        private void SlapenvragenBut_Clicked(object sender, EventArgs e)
        {
            Stuidevragen.IsEnabled = false;
            HumeurvragenBut.IsEnabled = false;
            ConcentratievragenBut.IsEnabled = false;
            VragenStackLayout.IsVisible = true;
            vraag1StackLayout.IsVisible = true;
            vraagSlapenDatabase = VraagSlapenDatabase.getAllVragenSlapen();
            LabVraag1.Text = vraagSlapenDatabase[0].vraag;
            Labelkeuze1.Text = vraagSlapenDatabase[0].vraagkeuze1;
            Labelkeuze2.Text = vraagSlapenDatabase[0].vraagkeuze2;
            Labelkeuze3.Text = vraagSlapenDatabase[0].vraagkeuze3;
            Labelkeuze4.Text = vraagSlapenDatabase[0].vraagkeuze4;
            LabVraag2.Text = vraagSlapenDatabase[1].vraag;
            Labelkeuze12.Text = vraagSlapenDatabase[1].vraagkeuze1;
            Labelkeuze22.Text = vraagSlapenDatabase[1].vraagkeuze2;
            Labelkeuze32.Text = vraagSlapenDatabase[1].vraagkeuze3;
            Labelkeuze42.Text = vraagSlapenDatabase[1].vraagkeuze4;
            LabVraag3.Text = vraagSlapenDatabase[2].vraag;
            Labelkeuze13.Text = vraagSlapenDatabase[2].vraagkeuze1;
            Labelkeuze23.Text = vraagSlapenDatabase[2].vraagkeuze2;
            Labelkeuze33.Text = vraagSlapenDatabase[2].vraagkeuze3;
            Labelkeuze43.Text = vraagSlapenDatabase[2].vraagkeuze4;

        }

        private void ConcentratievragenBut_Clicked(object sender, EventArgs e)
        {
            Stuidevragen.IsEnabled = false;
            HumeurvragenBut.IsEnabled = false;
            SlapenvragenBut.IsEnabled = false;
            VragenStackLayout.IsVisible = true;
            vraag1StackLayout.IsVisible = true;
            vraagConcentratieDatabase = VraagConcentratieDatabase.getAllVragenConcentratie();
            LabVraag1.Text = vraagConcentratieDatabase[0].vraag;
            Labelkeuze1.Text = vraagConcentratieDatabase[0].vraagkeuze1;
            Labelkeuze2.Text = vraagConcentratieDatabase[0].vraagkeuze2;
            Labelkeuze3.Text = vraagConcentratieDatabase[0].vraagkeuze3;
            Labelkeuze4.Text = vraagConcentratieDatabase[0].vraagkeuze4;
            LabVraag2.Text = vraagConcentratieDatabase[1].vraag;
            Labelkeuze12.Text = vraagConcentratieDatabase[1].vraagkeuze1;
            Labelkeuze22.Text = vraagConcentratieDatabase[1].vraagkeuze2;
            Labelkeuze32.Text = vraagConcentratieDatabase[1].vraagkeuze3;
            Labelkeuze42.Text = vraagConcentratieDatabase[1].vraagkeuze4;
            LabVraag3.Text = vraagConcentratieDatabase[2].vraag;
            Labelkeuze13.Text = vraagConcentratieDatabase[2].vraagkeuze1;
            Labelkeuze23.Text = vraagConcentratieDatabase[2].vraagkeuze2;
            Labelkeuze33.Text = vraagConcentratieDatabase[2].vraagkeuze3;
            Labelkeuze43.Text = vraagConcentratieDatabase[2].vraagkeuze4;
        }

        private void sendAntwoord3_Clicked(object sender, EventArgs e)
        {
            TipsStackLayout.IsVisible = true;
            tipsDatabase = TipsDataBase.getAllTipsStudie();
            if (Stuidevragen.IsEnabled)
            {
                tipsLabel.Text = tipsDatabase[0].tip;
                linklabel.Text = tipsDatabase[0].link;
                Device.StartTimer(new TimeSpan(0, 0, 2), () =>
                {
                    linklabelFrame.IsVisible = true;
                    return false;
                });

            }
            if (HumeurvragenBut.IsEnabled)
            {
                tipsLabel.Text = tipsDatabase[1].tip;
                linklabel.Text = tipsDatabase[1].link;
                Device.StartTimer(new TimeSpan(0, 0, 2), () =>
                {
                    linklabelFrame.IsVisible = true;
                    return false;
                });

            }
            if (SlapenvragenBut.IsEnabled)
            {
                tipsLabel.Text = tipsDatabase[2].tip;
                linklabel.Text = tipsDatabase[2].link;
                Device.StartTimer(new TimeSpan(0, 0, 2), () =>
                {
                    linklabelFrame.IsVisible = true;
                    return false;
                });

            }
            if (ConcentratievragenBut.IsEnabled)
            {
                tipsLabel.Text = tipsDatabase[3].tip;
                linklabel.Text = tipsDatabase[3].link;
                Device.StartTimer(new TimeSpan(0, 0, 2), () =>
                {
                    linklabelFrame.IsVisible = true;
                    return false;
                });

            }

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(linklabel.Text), BrowserLaunchMode.SystemPreferred);
        }



        //private void sendAntwoord3_Clicked(object sender, EventArgs e)
        //{
        //    vraag4StackLayout.IsVisible = true;
        //}
    }
}