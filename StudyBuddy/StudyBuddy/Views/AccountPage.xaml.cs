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
    public partial class AccountPage : ContentPage
    {
        private User user;
        public AccountPage(User user)
        {
            InitializeComponent();
            this.user = user; 
            UserNameLabel.Text = user.Naam;
            UserEmailLabel.Text = user.EmailAdres;
            //UserPasswordLabel.Text = user.Wachtwoord;
            UserEducationLabel.Text = user.Opleiding;
            UserStrongPointsLabel.Text = user.Sterkepunt;
            UserWeakPointsLabel.Text = user.Zwakkepunt;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<User>();
                var users = connection.Table<User>().ToList();
                //UserListView.ItemsSource = users;
              
            }
        }

        private void EditBut_Clicked(object sender, EventArgs e)
        {
            UserInfoEditStackLayout.IsVisible = true;
            UserNameEntry.Text = user.Naam;
            UserEducationEntry.Text = user.Opleiding;
            UserStrongPointsEntry.Text = user.Sterkepunt;
            UserWeakPointsEntry.Text = user.Zwakkepunt;
            UserInfoStackLayout.IsVisible = false;
        }

        private void CancelBut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage(user));
        }

        private void SaveInfoBut_Clicked(object sender, EventArgs e)
        {
            user.Naam = UserNameEntry.Text;
            //user.EmailAdres = UserEmailEntry.Text;
            user.Opleiding = UserEducationEntry.Text;
            user.Sterkepunt = UserStrongPointsEntry.Text;
            user.Zwakkepunt = UserWeakPointsEntry.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<User>();
                int rows = connection.Update(user);
                if (rows > 0)
                {
                    DisplayAlert("Succes", "UW profiel is succesvol aangepast", "OK");
                }
                else
                {
                    DisplayAlert("Mislukt", "UW profiel is niet succesvol aangepast", "OK");
                }
            }
            Navigation.PushAsync(new AccountPage(user));
        }
    }
    }
