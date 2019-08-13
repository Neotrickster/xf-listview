using Xamarin.Forms;

namespace SearchListView
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            this.BindingContext = this.viewModel;

        }

        private async void _ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var model = e.Item as ItemObj;
            await Navigation.PushAsync(new Page1(model));
        }
    }
}
