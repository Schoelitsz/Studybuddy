using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StudyBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SOSPage : ContentPage
    {
        public SOSPage()
        {
            InitializeComponent();
        }


        private void Phone_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("+31454006857");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

      



        private async void Email1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Email.ComposeAsync(string.Empty, string.Empty, "rianne.boumans@zuyd.nl");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private async void Sms1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Sms.ComposeAsync( new SmsMessage( string.Empty, "+31454006857"));
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}