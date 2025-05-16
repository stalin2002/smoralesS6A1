using smoralesS6A1.Models;
using smoralesS6A1.PageModels;

namespace smoralesS6A1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}