using Xamarin.Forms;
using GreatQuotes.ViewModels;

namespace GreatQuotes
{
    public partial class QuoteListPage : ContentPage
    {
        public QuoteListPage()
        {
            BindingContext = App.MainViewModel;
            
            InitializeComponent();
        }
    }
}

