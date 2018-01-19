using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConnpassEventList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Event.EventItem eventItem)
		{
			InitializeComponent ();

            // HTML文字列
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = eventItem.description;
            //detail.Source = htmlSource;

            // Webページ
            detail.Source = new UrlWebViewSource { Url = eventItem.event_url };
        }
	}
}