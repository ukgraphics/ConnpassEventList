using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = eventItem.description;
            detail.Source = htmlSource;

            //detail.Source = eventItem.event_url;

        }
	}
}