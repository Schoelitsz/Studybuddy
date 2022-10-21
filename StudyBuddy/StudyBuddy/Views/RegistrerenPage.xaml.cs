using SQLite;
using StudyBuddy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisrerenPage : ContentPage
    {
        public RegisrerenPage()
        {
            InitializeComponent();
        }

        private void RegistrerenOpslanButton_Clicked(object sender, EventArgs e)
        {
            if (emailEntry.Text != null & WachtwoordEntry.Text != null & BevestigWachtwoordEntry.Text != null)
            {
                if (WachtwoordEntry.Text == BevestigWachtwoordEntry.Text)
                {
                    User user = new User() { Naam = NaamEntry.Text, EmailAdres = emailEntry.Text, Wachtwoord = WachtwoordEntry.Text, 
                        Opleiding = opleidingEntry.Text, Sterkepunt = SterkePuntEntry.Text, Zwakkepunt = ZwakkePuntEntry.Text };
                    using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
                    {
                        connection.CreateTable<User>();
                        int rows = connection.Insert(user);
                        if (rows > 0)
                        {
                            DisplayAlert("Registreren", "U heeft Geregistreerd", "OK");
                        }
                        else
                        {
                            DisplayAlert("Registreren", "U heeft niet Geregistreerd ", "OK");
                        }

                    }
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("Fout", "Wachtwoord en bevestig wachtwoord moeten gelijk zijn ", "OK");

                }

            }
            else
            {
                DisplayAlert("Fout", "E Mailadres, wachtwoord en bevestig wachtwoord moet vullen", "OK");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}