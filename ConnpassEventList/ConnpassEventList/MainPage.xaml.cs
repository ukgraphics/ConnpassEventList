using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ConnpassEventList
{
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

        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //{
            //    return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            //}
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            ////((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.

            var selecteditem = e.SelectedItem as Event.EventItem;

            Navigation.PushAsync(new DetailPage(selecteditem), true);
        }
    }
}
