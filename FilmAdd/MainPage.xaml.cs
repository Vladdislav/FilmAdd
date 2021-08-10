using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FilmAdd.Models;

namespace FilmAdd
{
    public partial class MainPage : ContentPage
    {
        public IList<Film> Films { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            Films = new List<Film>();

            Films.Add(new Film
            {
                Id = "1",
                Name = "Astral",
                Description = "This cool film",
                Rating = 10,
                ImageURL = "https://www.film.ru/sites/default/files/filefield_paths/16361569-1006838.jpg"
            });
            Films.Add(new Film
            {
                Id = "2",
                Name = "Форсаж",
                Description = "This cool film",
                Rating = 8,
                ImageURL = "https://images.kinorium.com/movie/shot/1561985/w1500_47188924.jpg"
            });
            Films.Add(new Film
            {
                Id = "3",
                Name = "Оно",
                Description = "This cool film",
                Rating = 9,
                ImageURL = "https://avatars.mds.yandex.net/get-zen_doc/61795/pub_5d7792d47cccba00ad0f2668_5d77942ee6cb9b00ae2c53a2/scale_1200"
            });
            Films.Add(new Film
            {
                Id = "4",
                Name = "Зомби ленд",
                Description = "This cool film",
                Rating = 10,
                ImageURL = "https://avatars.mds.yandex.net/get-zen_doc/1866022/pub_5db2f56198930900ad0567a3_5db2f71b8600e100b084faa5/scale_1200"
            });
            BindingContext = this;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Film selectedItem = e.CurrentSelection[0] as Film;
            
        }
    }
}
