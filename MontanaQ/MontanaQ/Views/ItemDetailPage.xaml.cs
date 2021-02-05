using MontanaQ.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MontanaQ.Views
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