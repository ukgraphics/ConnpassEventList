using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConnpassEventList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var imageSource = ImageSource.FromResource("ConnpassEventList.connpass_logo_1.png", Assembly.GetExecutingAssembly());
            logo.Source = imageSource;
        }

        public void GetEvent(object sender, System.EventArgs e)
        {
            List<Event.EventItem> result;
            result = Event.GetEvent(keyword.Text);

            list.ItemsSource = result;
        }

        public void OnSelection(object sender, ItemTappedEventArgs  e)
        {
            var selecteditem = e.Item as Event.EventItem;

            Navigation.PushAsync(new DetailPage(selecteditem), true);
        }
    }
}
