using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmAdd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert", "OK");
        }
        private async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool responce = await DisplayAlert("Save", "Would you like to save your Data?", "Yes", "No");

            Console.WriteLine("Save data:" + responce);

            if(responce != true)
                await DisplayAlert("Error", "Don't save your changes", "Quit");
            else
                await DisplayAlert("Done", "Data saved", "Quit");
        }
    }
}