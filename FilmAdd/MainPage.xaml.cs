using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FilmAdd.Models;
using FilmAdd.Views;

namespace FilmAdd
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenLibrary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LibraryPage());
        }
    }
}
