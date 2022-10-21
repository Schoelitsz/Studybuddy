using StudyBuddy.Model;
using StudyBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        private User user;
        List<MenuItems> menuItems;
        public HomePage(User user)
        {
           
            InitializeComponent();
            this.user = user;
            NavigationPage.SetHasNavigationBar(this, false);
            
            menuItems = new List<MenuItems>();

            menuItems.Add(new MenuItems { OptionName = "Home" });
            menuItems.Add(new MenuItems { OptionName = "GesprekResultaat" });
            
            menuItems.Add(new MenuItems { OptionName = "Contact" });
            menuItems.Add(new MenuItems { OptionName = "Account" });
            menuItems.Add(new MenuItems { OptionName = "FAQ" });
            menuItems.Add(new MenuItems { OptionName = "Log uit" });

            navigationList.ItemsSource = menuItems;
            Detail = new NavigationPage(new GesprekPage());

        }

        private void SOS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SOSPage());
        }

        private void letstalkBut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GesprekPage());
        }

        private void navigationList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;
                switch (item.OptionName)
                {
                    case "Home":
                        {
                            Detail = new NavigationPage(new HomePage(user));
                            IsPresented = false;
                        }
                        break;

                    case "GesprekResultaat":
                        {
                            Detail = new NavigationPage(new GesprekResultaatPage());
                            IsPresented = false;
                        }
                        break;
                    
                    case "Contact":
                        {
                            Detail = new NavigationPage(new SOSPage ());
                            IsPresented = false;
                        }
                        break;
                    case "Account":
                        {
                            Detail = new NavigationPage(new AccountPage(user));
                            IsPresented = false;
                        }
                        break;
                    case "FAQ":
                        {
                            Detail.Navigation.PushAsync(new FAQPage());
                            IsPresented = false;
                        }
                        break;
                    case "Log uit":
                        {
                            Detail.Navigation.PushAsync(new MainPage());
                            IsPresented = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public class MenuItems
        {
            public string OptionName { get; set; }
        }

    }
    
    
}