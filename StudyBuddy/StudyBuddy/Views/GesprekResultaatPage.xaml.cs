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
    public partial class GesprekResultaatPage : ContentPage
    {
        private SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);

       

        public GesprekResultaatPage()
        {
            InitializeComponent();
           
            


        }

       

    }
}