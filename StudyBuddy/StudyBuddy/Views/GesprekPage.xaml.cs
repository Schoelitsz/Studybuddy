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
    public partial class GesprekPage : ContentPage
    {
       
        public GesprekPage()
        {
            InitializeComponent();
           
        }

        private void SOS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SOSPage());
        }

        private void letstalkBut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetstalkPage1());
        }
    }
}