using FrenchVersion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FrenchVersion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}