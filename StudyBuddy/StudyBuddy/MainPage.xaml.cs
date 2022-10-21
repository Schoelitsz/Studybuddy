using SQLite;
using StudyBuddy.Model;
using StudyBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudyBuddy
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
        }

        private void inloggenBut_Clicked(object sender, EventArgs e)
        {
           
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<User>();

                User myquery = connection.Table<User>().Where(u => u.EmailAdres.Equals(emailInput.Text) && u.Wachtwoord.Equals(wachtwoorInput.Text)).FirstOrDefault();
                
                if (myquery != null)
                {
                   

                    Navigation.PushAsync(new HomePage(myquery));                   

                }
                else
                {
                    DisplayAlert("Inloggen", " Failed email en wachtwoord  ", "OK");

                }

            }

            
        }

        private void registrerenBut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisrerenPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WachtwoordVergetenPage());
        }
    }
}
