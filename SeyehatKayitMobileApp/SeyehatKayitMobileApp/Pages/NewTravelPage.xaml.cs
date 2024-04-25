using SeyehatKayitMobileApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeyehatKayitMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Description = descriptionEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

            conn.CreateTable<Post>();

            int rows = conn.Insert(post);

            if (rows > 0)
                DisplayAlert("Başarılı", "Açıklama başarı ile eklendi", "Tamam");
            else
                DisplayAlert("Hata", "Açıklama eklenirken bir hata oluştu", "Tamam");
            
            
        }
    }
}